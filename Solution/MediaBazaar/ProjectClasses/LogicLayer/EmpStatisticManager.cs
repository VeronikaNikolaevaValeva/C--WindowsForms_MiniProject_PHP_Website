using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ProjectClasses
{
    public class EmpStatisticManager
    {
        //Employee employee;
        EmployeeManager employeeManager;
        DBMediatorEmpStatistic dbMediator;
        DatabaseType databaseType;
        
        public EmpStatisticManager(DatabaseType databaseType)
        {
            dbMediator = new DBMediatorEmpStatistic(databaseType);
            this.databaseType = databaseType;
        }

        public List<Employee> GetListOfAllEmployees()
        {
            employeeManager = new EmployeeManager(databaseType);
            return employeeManager.GetListOFAllEmployees();
        }


        public List<double> GetEmployeeContractualHours(string contract)   //IndividualEmpStatistics
        {
            List<double> ContractualHours = new List<double>();
            switch (contract)
            {
                case "FULLTIME":
                    ContractualHours.Add(5.7);
                    ContractualHours.Add(40);
                    ContractualHours.Add(160);
                    ContractualHours.Add(2080);
                    return ContractualHours;
                case "EIGHTYPERCENT":
                    ContractualHours.Add(5.7);
                    ContractualHours.Add(40);
                    ContractualHours.Add(160);
                    ContractualHours.Add(2080);
                    return ContractualHours;
                case "FLEX":
                    ContractualHours.Add(0);
                    ContractualHours.Add(0);
                    ContractualHours.Add(0);
                    ContractualHours.Add(0);
                    return ContractualHours; 
                case "LEFT":
                    ContractualHours.Add(0);
                    ContractualHours.Add(0);
                    ContractualHours.Add(0);
                    ContractualHours.Add(0);
                    return ContractualHours;
            }
            return ContractualHours;
        }

        public List<int> GetEmployeeHoursPerTimeUnit(int empId, DateTime date)  //IndividualEmpStatistics
        {
            List<int> EmpHoursPerTimeUnit = new List<int>();
            EmpHoursPerTimeUnit.Add(dbMediator.GetEmployeeAssignedHoursForStatPerDay(empId, date.Day.ToString()));
            EmpHoursPerTimeUnit.Add(dbMediator.GetEmployeeAssignedHoursForStatPerWeek(empId, GetWeekNumber(date)));
            EmpHoursPerTimeUnit.Add(dbMediator.GetEmployeeAssignedHoursForStatPerMonth(empId, date.Month.ToString()));
            EmpHoursPerTimeUnit.Add(dbMediator.GetEmployeeAssignedHoursForStatPerYear(empId, date.Year.ToString()));
            return EmpHoursPerTimeUnit;
        }

        // //Overview of EmpStatistics
        public List<double> ShowOverallStatistics(string typeOfStats, string period, DateTime date, string contract, string position)
        {
            List<double> EmpStats = new List<double>();
            try 
            {
                List<DateTime> DaysOfTHeWeek = GetDaysOfWeek(date);
                int WeekNumber = GetWeekNumber(date);
                switch (period)
                {
                    case "year":
                        if (typeOfStats == "Total salary")
                        {
                            EmpStats = dbMediator.GetOverallEmpStatTotalSalaryForYear(date.Year.ToString(), "Total salary", "None", contract, position);
                        }
                        else if (typeOfStats == "Average salary")
                        {
                            EmpStats = dbMediator.GetOverallEmpStatTotalSalaryForYear(date.Year.ToString(), "Total salary", "Average", contract, position);
                        }
                        else if (typeOfStats == "Total hours worked")
                        {
                            EmpStats = dbMediator.GetOverallEmpStatTotalSalaryForYear(date.Year.ToString(), "Total hours worked", "None", contract, position);
                        }
                        else if (typeOfStats == "Average hours worked")
                        {
                            EmpStats = dbMediator.GetOverallEmpStatTotalSalaryForYear(date.Year.ToString(), "Total hours worked", "Average", contract, position);
                        }
                        return EmpStats;
                    case "month":
                        if (typeOfStats == "Total salary")
                        {
                            EmpStats = dbMediator.GetOverallEmpStatTotalSalaryForMonth(date, "Total salary", "None", contract, position);
                        }
                        else if (typeOfStats == "Average salary")
                        {
                            EmpStats = dbMediator.GetOverallEmpStatTotalSalaryForMonth(date, "Total salary", "Average", contract, position);
                        }
                        else if (typeOfStats == "Total hours worked")
                        {
                            EmpStats = dbMediator.GetOverallEmpStatTotalSalaryForMonth(date, "Total hours worked", "None", contract, position);
                        }
                        else if (typeOfStats == "Average hours worked")
                        {
                            EmpStats = dbMediator.GetOverallEmpStatTotalSalaryForMonth(date, "Total hours worked", "Average", contract, position);
                        }
                        return EmpStats;
                    case "week":
                        if (typeOfStats == "Total salary")
                        {
                            EmpStats = dbMediator.GetOverallEmpStatTotalSalaryForWeek(DaysOfTHeWeek, WeekNumber, date, "Total salary", "None", contract, position);
                        }
                        else if (typeOfStats == "Average salary")
                        {
                            EmpStats = dbMediator.GetOverallEmpStatTotalSalaryForWeek(DaysOfTHeWeek, WeekNumber, date, "Total salary", "Average", contract, position);
                        }
                        else if (typeOfStats == "Total hours worked")
                        {
                            EmpStats = dbMediator.GetOverallEmpStatTotalSalaryForWeek(DaysOfTHeWeek, WeekNumber, date, "Total hours worked", "None", contract, position);
                        }
                        else if (typeOfStats == "Average hours worked")
                        {
                            EmpStats = dbMediator.GetOverallEmpStatTotalSalaryForWeek(DaysOfTHeWeek, WeekNumber, date, "Total hours worked", "Average", contract, position);
                        }
                        return EmpStats;
                }
                
            }
            catch (Exception e)
            {

            }
            return EmpStats;
        }

        public List<double> ShowDepartmentOverallStatistics(string typeOfStats, string period, DateTime date, string deptCode, string contract)
        {
            List<double> EmpStats = new List<double>();
            List<DateTime> DaysOfTHeWeek = GetDaysOfWeek(date);
            int WeekNumber = GetWeekNumber(date);
            switch (period)
            {
                case "year":
                    if (typeOfStats == "Total salary")
                    {
                        EmpStats = dbMediator.GetDepartmentEmpStatTotalSalaryForYear(date.Year.ToString(), "Total salary", "None", deptCode, contract);
                    }
                    else if (typeOfStats == "Average salary")
                    {
                        EmpStats = dbMediator.GetDepartmentEmpStatTotalSalaryForYear(date.Year.ToString(), "Total salary", "Average", deptCode, contract);
                    }
                    else if (typeOfStats == "Total hours worked")
                    {
                        EmpStats = dbMediator.GetDepartmentEmpStatTotalSalaryForYear(date.Year.ToString(), "Total hours worked", "None", deptCode, contract);
                    }
                    else if (typeOfStats == "Average hours worked")
                    {
                        EmpStats = dbMediator.GetDepartmentEmpStatTotalSalaryForYear(date.Year.ToString(), "Total hours worked", "Average", deptCode, contract);
                    }
                    return EmpStats;
                case "month":
                    if (typeOfStats == "Total salary")
                    {
                        EmpStats = dbMediator.GetDepartmentEmpStatTotalSalaryForMonth(date, "Total salary", "None", deptCode, contract);
                    }
                    else if (typeOfStats == "Average salary")
                    {
                        EmpStats = dbMediator.GetDepartmentEmpStatTotalSalaryForMonth(date, "Total salary", "Average", deptCode, contract);
                    }
                    else if (typeOfStats == "Total hours worked")
                    {
                        EmpStats = dbMediator.GetDepartmentEmpStatTotalSalaryForMonth(date, "Total hours worked", "None", deptCode, contract);
                    }
                    else if (typeOfStats == "Average hours worked")
                    {
                        EmpStats = dbMediator.GetDepartmentEmpStatTotalSalaryForMonth(date, "Total hours worked", "Average", deptCode, contract);
                    }
                    return EmpStats;
                case "week":
                    if (typeOfStats == "Total salary")
                    {
                        EmpStats = dbMediator.GetDepartmentEmpStatTotalSalaryForWeek(DaysOfTHeWeek, WeekNumber, date, "Total salary", "None", deptCode, contract);
                    }
                    else if (typeOfStats == "Average salary")
                    {
                        EmpStats = dbMediator.GetDepartmentEmpStatTotalSalaryForWeek(DaysOfTHeWeek, WeekNumber, date, "Total salary", "Average", deptCode, contract);
                    }
                    else if (typeOfStats == "Total hours worked")
                    {
                        EmpStats = dbMediator.GetDepartmentEmpStatTotalSalaryForWeek(DaysOfTHeWeek, WeekNumber, date, "Total hours worked", "None", deptCode, contract);
                    }
                    else if (typeOfStats == "Average hours worked")
                    {
                        EmpStats = dbMediator.GetDepartmentEmpStatTotalSalaryForWeek(DaysOfTHeWeek, WeekNumber, date, "Total hours worked", "Average", deptCode, contract);
                    }
                    return EmpStats;
            }
            return EmpStats;
        }


        public int GetWeekNumber(DateTime date)
        {
            return CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(date, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
        }
        public List<DateTime> GetDaysOfWeek(DateTime date)
        {
            DateTime startDate = date;
            DateTime endDate = startDate.AddDays(7);
            List<DateTime> dates = new List<DateTime>();
            for (DateTime i = startDate; i > date.AddDays(-7); i = i.AddDays(-1))
            {
                if(GetWeekNumber(i.AddDays(-1))!= GetWeekNumber(date))
                {
                    startDate = i;
                    endDate = startDate.AddDays(7);
                    break;
                }
            }
            for (DateTime i = startDate; i < endDate; i = i.AddDays(1))
            {
                dates.Add(i);
            }
            return dates;
        }
    }
}
