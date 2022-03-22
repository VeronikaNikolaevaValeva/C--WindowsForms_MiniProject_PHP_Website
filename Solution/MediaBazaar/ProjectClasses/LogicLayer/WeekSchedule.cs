using ProjectClasses.Exceptions;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClasses.LogicLayer
{
    public class WeekSchedule
    {
        private int weekNumber;
        private List<Shift> shiftsInWeek;
        private Department department;
        private List<EmployeeInSchedule> employeesInDepartment;
        DBMediatorShifts dbMediator;
        public int WeekNumber
        {
            get { return this.weekNumber; }
        }
        public DateTime WeekStartDate
        {
            get { return this.shiftsInWeek[0].Date; }
        }
        public DateTime WeekEndDate
        {
            get { return this.shiftsInWeek[shiftsInWeek.Count - 1].Date; }
        }
        public Department Department
        {
            get { return this.department; }
        }
        public Shift GetShift(ShiftType type, DayOfWeek day)
        {
            foreach (Shift shift in shiftsInWeek)
            {
                if (shift.Date.DayOfWeek==day && shift.Type == type)
                {
                    return shift;
                }
            }
            return null;
        }
        public int GetAssignedHoursPerWeek(Employee employee)
        {
            foreach (EmployeeInSchedule emp in employeesInDepartment)
            {
                if (emp.Employee.Id == employee.Id)
                {
                    return GetAssignedHoursPerWeek(emp);
                }
            }
            return 0;
        }
        private void Initialize(DateTime selectedDate, Department department)
        {
            this.weekNumber = GetWeekNumber(selectedDate);
            this.department = department;
            this.employeesInDepartment = dbMediator.GetEmployeesAvailabilityPerDepartmentAndWeekNumber(department, weekNumber);
            CreateShiftsInWeek(selectedDate);

            FillSchedule();
        }
        private void Initialize(DateTime selectedDate)
        {
            this.weekNumber = GetWeekNumber(selectedDate);
            this.employeesInDepartment = dbMediator.GetStockWorkersAvailabilityPerWeekNumber(weekNumber);

            CreateShiftsInWeek(selectedDate);
            FillSchedule();
        }
        private void CreateShiftsInWeek(DateTime selectedDate)
        {
            DateTime startDate = selectedDate;
            DateTime endDate = startDate.AddDays(7);
            shiftsInWeek = new List<Shift>();

            for (DateTime i = startDate; i > selectedDate.AddDays(-7); i = i.AddDays(-1))
            {
                if (GetWeekNumber(i.AddDays(-1)) != weekNumber)
                {
                    startDate = i;
                    endDate = startDate.AddDays(6);
                    break;
                }
            }

            for (DateTime i = startDate; i <= endDate; i = i.AddDays(1))
            {
                for (int j = 0; j < 4; j++)
                {
                    shiftsInWeek.Add(new Shift((ShiftType)j, i, new List<Employee>()));
                }
            }
        }
        

        public WeekSchedule(DateTime selectedDate, Department department, DBMediatorShifts dBMediator)
        {
            this.dbMediator = dBMediator;
            Initialize(selectedDate, department);
        }

        public WeekSchedule(DateTime selectedDate, Department department)
        {
            dbMediator = new DBMediatorShifts(DatabaseType.MAIN);
            Initialize(selectedDate,department);
            
        }
        public WeekSchedule(DateTime date)
        {
            dbMediator = new DBMediatorShifts(DatabaseType.MAIN);
            Initialize(date);

        }
        private int GetWeekNumber(DateTime date)
        {
            return CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(date, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);

        }
        public List<Shift> GetAllShifts()
        {
            return shiftsInWeek.OrderBy(x => x.Date).ThenBy(x=>x.Type).ToList();
        }
        public List<EmployeeInSchedule> GetAllAvailableEmployees(Shift shift)
        {
            List<EmployeeInSchedule> allAvailableEmployees = new List<EmployeeInSchedule>();
            foreach (EmployeeInSchedule employee in dbMediator.GetAllFlexContractEmployees(this.weekNumber,this.department))
            {
                if (GetAssignedHoursPerDay(employee, shift) < 3)
                {
                    allAvailableEmployees.Add(employee);
                }
            }
            foreach (EmployeeInSchedule employeeInDepartment in employeesInDepartment)
            {
                if (!allAvailableEmployees.Contains(employeeInDepartment)&& !shift.GetAssignedEmployees().Contains(employeeInDepartment.Employee) && GetAssignedHoursPerDay(employeeInDepartment, shift) < 3)
                {
                    allAvailableEmployees.Add(employeeInDepartment);
                }
            }
            return allAvailableEmployees.OrderBy(x=>x.Employee.Id).ToList();
        }
        public List<EmployeeInSchedule> GetAllAvailableStockWorker(Shift shift)
        {
            List<EmployeeInSchedule> allAvailableEmployees = new List<EmployeeInSchedule>();
            foreach (EmployeeInSchedule employee in dbMediator.GetAllFlexContractStockWorkers(this.weekNumber,shift.GetAssignedEmployeesIds()))
            {
                if (GetAssignedHoursPerDay(employee, shift) < 3){
                    allAvailableEmployees.Add(employee);
                }
            }
            foreach (EmployeeInSchedule employeeInDepartment in employeesInDepartment)
            {
                foreach (EmployeeInSchedule employee in allAvailableEmployees)
                    {
                        if ((employee.Employee.Id != employeeInDepartment.Employee.Id) && !shift.GetAssignedEmployees().Contains(employeeInDepartment.Employee)&& GetAssignedHoursPerDay(employeeInDepartment, shift) < 3)
                        {
                            allAvailableEmployees.Add(employeeInDepartment);
                        }
                    }
            }
            return allAvailableEmployees.OrderBy(x => x.Employee.Id).ToList();
        }
        private void ReorderList(List<EmployeeInSchedule> employees)
        {
            // sort by
            // 1. contract fulltime, 80% before flex
            // 2. in case 1 equal, avail hours
            // if a has to be before b in the list, return -1
            // if equal, return 0
            // if b has to be before a in the list, return 1

            employees.Sort(delegate (EmployeeInSchedule a, EmployeeInSchedule b)
            {
                int aAssignedHours = GetAssignedHoursPerWeek(a);
                int bAssignedHours = GetAssignedHoursPerWeek(b);

                if (
                (a.Employee.Contract == ContractType.FULLTIME
                || a.Employee.Contract == ContractType.EIGHTYPERCENT)
                && b.Employee.Contract == ContractType.FLEX)
                {
                    return -1;
                }

                if (
                    (b.Employee.Contract == ContractType.FULLTIME
                    || b.Employee.Contract == ContractType.EIGHTYPERCENT)
                    && a.Employee.Contract == ContractType.FLEX)
                {
                    return 1;
                }

                return aAssignedHours - bAssignedHours;
            });
        }
        private int GetAssignedHoursPerWeek(EmployeeInSchedule employeeInSchedule)
        {
            int employeeAssignedHoursPerWeek = 0;
            foreach (Shift shift1 in shiftsInWeek)
            {
                foreach (Employee employee in shift1.GetAssignedEmployees())
                {
                    if (employee.Id == employeeInSchedule.Employee.Id)
                    {
                    employeeAssignedHoursPerWeek++;
                    }
                }
               
            }

            return employeeAssignedHoursPerWeek * 4;
        }
        private int GetAssignedHoursPerDay(EmployeeInSchedule employeeInSchedule, Shift shift)
        {
            int employeeAssignedHoursPerDay = 0;
            foreach (Shift shift1 in shiftsInWeek)
            {
                foreach (Employee employee in shift1.GetAssignedEmployees())
                {
                    if (shift1.Date == shift.Date && employee.Id==employeeInSchedule.Employee.Id)
                    {
                        employeeAssignedHoursPerDay++;
                    }
                }
            }
            return employeeAssignedHoursPerDay;
        }

        private void FillSchedule()
        {
            List<EmployeeInSchedule> employeesInDepartmentModifiedList = new List<EmployeeInSchedule>(employeesInDepartment);
            foreach(Shift shift in shiftsInWeek)
            {
                ReorderList(employeesInDepartmentModifiedList);
                List<EmployeeInSchedule> employeesReachedMaxWorkingHoursPerWeek = new List<EmployeeInSchedule>();

                foreach(EmployeeInSchedule employee in employeesInDepartmentModifiedList)
                {
                    if (CanEmployeeBeAssignedToShift(employee, shift))
                    {
                        shift.AssignEmployee(employee.Employee);
                    }

                    if (HasEmployeeReachedWeeklyHoursLimit(employee))
                    {
                        employeesReachedMaxWorkingHoursPerWeek.Add(employee);
                    }

                    if (shift.AssignableEmployees == shift.GetAssignedEmployees().Count)
                    {
                        break;
                    }
                }

                // check if shift assigned employees are enough
                //if (shift.AssignableEmployees > shift.GetAssignedEmployees().Count)
                //{
                //    throw new NotEnoughEmmployeesException();
                //}
                
                // remove all employees that have reached the maximum working hours
                foreach(EmployeeInSchedule employee in employeesReachedMaxWorkingHoursPerWeek)
                {
                    employeesInDepartmentModifiedList.Remove(employee);
                }
            }
        }

        private bool CanEmployeeBeAssignedToShift(EmployeeInSchedule employee, Shift shift)
        {
            // check to how many shifts is assigned for the day
            if (GetAssignedHoursPerDay(employee, shift) == 3)
            {
                return false;
            }
            // check max assignable employees per shift
            if (shift.GetAssignedEmployees().Count == shift.AssignableEmployees)
            {
                return false;
            }
            // check if shifts contains employee
            if (shift.GetAssignedEmployees().Contains(employee.Employee))
            {
                return false;
            }
            // check if employee available shifts contains shift
            if (!EmployeeIsAvailableAtShift(employee, shift))
            {
                return false;
            }

            return true;
        }
        public bool HasEmployeeReachedWeeklyHoursLimit(EmployeeInSchedule employee)
        {
            int assignedHours = GetAssignedHoursPerWeek(employee);

            if (employee.Employee.GetMaxContractualHours() == assignedHours)
            {
                return true;
            }

            return false;
        }

        private bool EmployeeIsAvailableAtShift(EmployeeInSchedule employee, Shift shift)
        {
            foreach(Shift availableShift in employee.AvailableShifts)
            {
                if (availableShift.Date.Equals(shift.Date) && availableShift.Type == shift.Type)
                {
                    return true;
                }
            }

            return false;
        }
        public EmployeeInSchedule GetEmployeeFromAvailableEmployees(Shift shift,int employeeId,EmployeeType position)
        {
            if (position == EmployeeType.STORE_WORKER)
            {
                    foreach (EmployeeInSchedule employee in GetAllAvailableEmployees(shift))
                {
                    if (employee.Employee.Id == employeeId)
                    {
                        return employee;
                    }
                }
                return null;
            }
            else
            {
                foreach (EmployeeInSchedule employee in GetAllAvailableStockWorker(shift))
                {
                    if (employee.Employee.Id == employeeId)
                    {
                        return employee;
                    }
                }
                return null;
            }
        }
        public bool AssignEmployeeToShift(Shift shift,EmployeeInSchedule employee)
        {
            if (shift.AssignableEmployees - shift.GetAssignedEmployees().Count > 0 && !shift.GetAssignedEmployees().Contains(employee.Employee)&&employee!=null)
            {
                foreach (Shift shift1 in employee.AvailableShifts)
                {
                    if (shift1.Date.Equals(shift.Date) && shift1.Type == shift.Type)
                    {
                        shift.AssignEmployee(employee.Employee);
                        return true;
                    }
                }
            }
            return false;
        }
    }
}

