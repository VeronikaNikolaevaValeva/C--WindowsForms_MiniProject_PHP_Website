using Microsoft.VisualStudio.TestTools.UnitTesting;

using ProjectClasses.LogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectClasses;

namespace ProjectClasses.LogicLayer.Tests
{
    [TestClass()]
    public class WeekScheduleTests
    {
        private List<Shift> shifts = new List<Shift>();
        private int employeeIdCounter = 1;

        [TestMethod()]
        public void GenerateWeekSchedule()
        {
            for (DateTime i = new DateTime(2021, 5, 31); i <= new DateTime(2021, 6, 6); i = i.AddDays(1))
            {
                for (int j = 0; j < 4; j++)
                {
                    shifts.Add(new Shift((ShiftType)j, i, new List<Employee>()));
                }
            }

            DBMediatorShifts dBMediator = new DbMediatorShiftsTest(
                CreateFulltimeEmployees(0)
                .Concat(
                    CreateEightyPercentEmployees(0)
                )
                .Concat(
                     CreateFlexEmployees(20)
                ).ToList()
            );

            WeekSchedule ws = new WeekSchedule(new DateTime(2021, 6, 1), new Department(2678, "test"), dBMediator);

            Assert.AreEqual(22, ws.WeekNumber);
            Assert.AreEqual(new DateTime(2021, 05, 31), ws.WeekStartDate);
            Assert.AreEqual(new DateTime(2021, 06, 06), ws.WeekEndDate);
            Assert.AreEqual(2678, ws.Department.Code);
            foreach (Shift shift in ws.GetAllShifts())
            {
                foreach (Employee employee in shift.GetAssignedEmployees())
                {
                    Assert.AreEqual(ContractType.FLEX,employee.Contract);
                }
            }
            foreach (Shift shift in ws.GetAllShifts())
            {
                Assert.AreEqual(shift.GetAssignedEmployees().Count, shift.AssignableEmployees);
            }
        }
        [TestMethod()]
        public void GetShiftTest()
        {
            for (DateTime i = new DateTime(2021, 5, 31); i <= new DateTime(2021, 6, 6); i = i.AddDays(1))
            {
                for (int j = 0; j < 4; j++)
                {
                    shifts.Add(new Shift((ShiftType)j, i, new List<Employee>()));
                }
            }

            DBMediatorShifts dBMediator = new DbMediatorShiftsTest(
                CreateFulltimeEmployees(0)
                .Concat(
                    CreateEightyPercentEmployees(0)
                )
                .Concat(
                     CreateFlexEmployees(0)
                ).ToList()
            );

            WeekSchedule ws = new WeekSchedule(new DateTime(2021, 6, 1), new Department(2678, "test"), dBMediator);
            Shift shift = new Shift(ShiftType.Morning, new DateTime(2021, 05, 31), new List<Employee>());
            Assert.AreEqual(shift.Type, ws.GetShift(ShiftType.Morning, DayOfWeek.Monday).Type);
            Assert.AreEqual(shift.Date, ws.GetShift(ShiftType.Morning, DayOfWeek.Monday).Date);
            CollectionAssert.AreEqual(shift.GetAssignedEmployees(), ws.GetShift(ShiftType.Morning, DayOfWeek.Monday).GetAssignedEmployees());
            Assert.AreEqual(shift.AssignableEmployees, ws.GetShift(ShiftType.Morning, DayOfWeek.Monday).AssignableEmployees);
        }
        private List<EmployeeInSchedule> CreateFulltimeEmployees(int count)
        {
            return CreateEmployees(count, ContractType.FULLTIME);
        }

        private List<EmployeeInSchedule> CreateEightyPercentEmployees(int count)
        {
            return CreateEmployees(count, ContractType.EIGHTYPERCENT);
        }

        private List<EmployeeInSchedule> CreateFlexEmployees(int count)
        {
            return CreateEmployees(count, ContractType.FLEX);
        }

        private List<EmployeeInSchedule> CreateEmployees(int count, ContractType contract)
        {
            List<EmployeeInSchedule> employees = new List<EmployeeInSchedule>();
            for (int i = 0; i < count; i++)
            {
                EmployeeInSchedule employee = new EmployeeInSchedule(CreateEmployee(contract));
                AddShiftsToEmployee(employee);
                employees.Add(employee);
            }

            return employees;
        }

        private void AddShiftsToEmployee(EmployeeInSchedule employee)
        {
            foreach (Shift shift in shifts)
            {
                employee.AddAvailability(shift);
            }
        }

        private Employee CreateEmployee(ContractType contract)
        {
            return new Employee(this.employeeIdCounter++, "1", "1", "1", Gender.MALE, "11", "1", new DateTime(), "1", "1", "1", "1", "1", new DateTime(), "1", "1", 1, new DateTime(), contract, EmployeeType.STORE_WORKER);
        }

        [TestMethod()]
        public void GetAssignedHoursPerWeekTest()
        {
            for (DateTime i = new DateTime(2021, 5, 31); i <= new DateTime(2021, 6, 6); i = i.AddDays(1))
            {
                for (int j = 0; j < 4; j++)
                {
                    shifts.Add(new Shift((ShiftType)j, i, new List<Employee>()));
                }
            }

            DBMediatorShifts dBMediator = new DbMediatorShiftsTest(
                CreateFulltimeEmployees(0)
                .Concat(
                    CreateEightyPercentEmployees(0)
                )
                .Concat(
                     CreateFlexEmployees(0)
                ).ToList()
            );

            WeekSchedule ws = new WeekSchedule(new DateTime(2021, 6, 1), new Department(2678, "test"), dBMediator);
            Shift shift = new Shift(ShiftType.Morning, new DateTime(2021, 05, 31), new List<Employee>());
            Assert.AreEqual(shift.Type, ws.GetShift(ShiftType.Morning, DayOfWeek.Monday).Type);
            Assert.AreEqual(shift.Date, ws.GetShift(ShiftType.Morning, DayOfWeek.Monday).Date);
            CollectionAssert.AreEqual(shift.GetAssignedEmployees(), ws.GetShift(ShiftType.Morning, DayOfWeek.Monday).GetAssignedEmployees());
            Assert.AreEqual(shift.AssignableEmployees, ws.GetShift(ShiftType.Morning, DayOfWeek.Monday).AssignableEmployees);
        }
    }

    class DbMediatorShiftsTest : DBMediatorShifts
    {
        private List<EmployeeInSchedule> employeeInSchedules;

        public DbMediatorShiftsTest(List<EmployeeInSchedule> employeeInSchedules): base(DatabaseType.MAIN)
        {
            this.employeeInSchedules = employeeInSchedules;
        }

        public override List<EmployeeInSchedule> GetEmployeesAvailabilityPerDepartmentAndWeekNumber(Department department, int week)
        {
            return employeeInSchedules;
        }
    }

}