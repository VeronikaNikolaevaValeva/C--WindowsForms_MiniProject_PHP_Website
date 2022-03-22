using Microsoft.VisualStudio.TestTools.UnitTesting;

using ProjectClasses.LogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectClasses;


namespace UnitTests.LogicLayer.Tests
{
    [TestClass()]
    public class EmployeeStatisticsTest
    {
        EmpStatisticManager employeeStatsManager;

        //[TestMethod()]
        //public void GetListOfAllEmployeesTest()
        //{
        //    int i = 0;
        //    employeeStatsManager = new EmpStatisticManager(DatabaseType.TEST);
        //    foreach (Employee emp in employeeStatsManager.GetListOfAllEmployees())
        //    {
        //        Assert.AreEqual(emp.Id, this.GetEmployeeIDs()[i]);
        //        i++;
        //    }
        //}

        //public int[] GetEmployeeIDs()
        //{
        //    int[] empIDs = new int[] { 2, 3, 4, 6, 7, 8, 9, 12, 28, 40, 51, 57, 58, 59, 60, 61, 74, 75, 79, 81, 82, 83, 84, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143 };
        //    return empIDs;
        //}

        [TestMethod()]
        public void GetEmployeeContractualHoursTest()
        {
            employeeStatsManager = new EmpStatisticManager(DatabaseType.TEST);
            double[] listEightypercentFulltime = new double[] { 5.7, 40, 160, 2080 };
            double[] listFlexLeft = new double[] { 0, 0, 0, 0 };

            CollectionAssert.AreEqual(listEightypercentFulltime, employeeStatsManager.GetEmployeeContractualHours("FULLTIME"));
            CollectionAssert.AreEqual(listEightypercentFulltime, employeeStatsManager.GetEmployeeContractualHours("EIGHTYPERCENT"));
            CollectionAssert.AreEqual(listFlexLeft, employeeStatsManager.GetEmployeeContractualHours("LEFT"));
            CollectionAssert.AreEqual(listFlexLeft, employeeStatsManager.GetEmployeeContractualHours("FLEX"));
        }

        [TestMethod()]
        public void GetEmployeeHoursPerTimeUnitTest()
        {
            employeeStatsManager = new EmpStatisticManager(DatabaseType.TEST);
            DateTime date = new DateTime(2021, 06, 01, 9, 15, 0);
            int[] totalhoursWorkPaidTest = new int[] { 12, 40, 108, 120 };
            CollectionAssert.AreEqual(totalhoursWorkPaidTest, employeeStatsManager.GetEmployeeHoursPerTimeUnit(6, Convert.ToDateTime(date)));
        }

        [TestMethod()]
        public void ShowOverallStatisticsNoContractNoPositionSelectedTest()
        {
            employeeStatsManager = new EmpStatisticManager(DatabaseType.TEST);
            DateTime date = new DateTime(2021, 06, 01, 9, 15, 0);

            List<int> yearTotalSalary = employeeStatsManager.ShowOverallStatistics("Total salary", "year", date, "no contract", "all").ConvertAll(Convert.ToInt32);
            int[] totalYearSalaryTest = new int[] { 0, 0, 0, 0, 804, 5404, 0, 0, 0, 0, 0, 0 };
            CollectionAssert.AreEqual(yearTotalSalary, totalYearSalaryTest);

            List<int> yearAverageSalary = employeeStatsManager.ShowOverallStatistics("Average salary", "year", date, "no contract", "all").ConvertAll(Convert.ToInt32);
            int[] avgYearSalaryTest = new int[] { 0, 0, 0, 0, 42, 216, 0, 0, 0, 0, 0, 0 };
            CollectionAssert.AreEqual(yearAverageSalary, avgYearSalaryTest);

            List<int> yearTotalHoursWorked = employeeStatsManager.ShowOverallStatistics("Total hours worked", "year", date, "no contract", "all").ConvertAll(Convert.ToInt32);
            int[] totalHoursWorkedTest = new int[] { 0, 0, 0, 0, 120, 1096, 0, 0, 0, 0, 0, 0 };
            CollectionAssert.AreEqual(totalHoursWorkedTest, yearTotalHoursWorked);

            List<int> yearAvgTotalHoursWorked = employeeStatsManager.ShowOverallStatistics("Average hours worked", "year", date, "no contract", "all").ConvertAll(Convert.ToInt32);
            int[] avgHoursWorkedTest = new int[] { 0, 0, 0, 0, 6, 44, 0, 0, 0, 0, 0, 0 };
            CollectionAssert.AreEqual(avgHoursWorkedTest, yearAvgTotalHoursWorked);

            List<int> monthTotalSalary = employeeStatsManager.ShowOverallStatistics("Total salary", "month", date, "no contract", "all").ConvertAll(Convert.ToInt32);
            int[] totalMonthSalaryTest = new int[] { 804, 768, 312, 160, 160, 160, 120, 120, 80, 0, 0, 0, 0, 432, 432, 392, 104, 0, 0, 0, 432, 432, 392, 104, 0, 0, 0, 0, 0, 0 };
            CollectionAssert.AreEqual(monthTotalSalary, totalMonthSalaryTest);

            List<int> monthAvgSalary = employeeStatsManager.ShowOverallStatistics("Average salary", "month", date, "no contract", "all").ConvertAll(Convert.ToInt32);
            int[] avgMonthSalaryTest = new int[] { 47, 40, 14, 8, 8, 8, 60, 60, 40, 0, 0, 0, 0, 108, 108, 98, 35, 0, 0, 0, 108, 108, 98, 35, 0, 0, 0, 0, 0, 0 };
            CollectionAssert.AreEqual(avgMonthSalaryTest, monthAvgSalary);

            DateTime dateTwo = new DateTime(2021, 05, 01, 9, 15, 0);
            List<int> monthATotalHours = employeeStatsManager.ShowOverallStatistics("Total hours worked", "month", dateTwo, "no contract", "all").ConvertAll(Convert.ToInt32);
            Assert.AreEqual(120, monthATotalHours[30]);

            List<int> avgTotalHours = employeeStatsManager.ShowOverallStatistics("Average hours worked", "month", dateTwo, "no contract", "all").ConvertAll(Convert.ToInt32);
            Assert.AreEqual(6, avgTotalHours[30]);

            List<int> weekTotalHours = employeeStatsManager.ShowOverallStatistics("Total hours worked", "week", date, "no contract", "all").ConvertAll(Convert.ToInt32);
            int[] weekTest = new int[] { 120, 120, 120, 120, 160, 160, 0 };
            CollectionAssert.AreEqual(weekTest, weekTotalHours);

            List<int> weekAvgTotalHours = employeeStatsManager.ShowOverallStatistics("Average hours worked", "week", date, "no contract", "all").ConvertAll(Convert.ToInt32);
            int[] weekAvgTest = new int[] { 6, 7, 6, 5, 8, 8, 0 };
            CollectionAssert.AreEqual(weekAvgTest, weekAvgTotalHours);

            List<int> weekTotalSalary = employeeStatsManager.ShowOverallStatistics("Total salary", "week", date, "no contract", "all").ConvertAll(Convert.ToInt32);
            int[] weekSalaryTest = new int[] { 804, 804, 768, 312, 160, 160, 0 };
            CollectionAssert.AreEqual(weekTotalSalary, weekSalaryTest);

            List<int> weekAvgTotalSalary = employeeStatsManager.ShowOverallStatistics("Average salary", "week", date, "no contract", "all").ConvertAll(Convert.ToInt32);
            int[] weekAvgSalary = new int[] { 42, 47, 40, 14, 8, 8, 0 };
            CollectionAssert.AreEqual(weekAvgTotalSalary, weekAvgSalary);
        }

        [TestMethod()]
        public void ShowOverallStatisticsFilteredByContractFulltime()
        {
            employeeStatsManager = new EmpStatisticManager(DatabaseType.TEST);
            DateTime date = new DateTime(2021, 06, 01, 9, 15, 0);

            List<int> yearTotalSalary = employeeStatsManager.ShowOverallStatistics("Total salary", "year", date, "FULLTIME", "all").ConvertAll(Convert.ToInt32);
            int[] totalYearSalaryTest = new int[] { 0, 0, 0, 0, 636, 3564, 0, 0, 0, 0, 0, 0 };
            CollectionAssert.AreEqual(yearTotalSalary, totalYearSalaryTest);

            List<int> monthTotalSalary = employeeStatsManager.ShowOverallStatistics("Total salary", "month", date, "FULLTIME", "all").ConvertAll(Convert.ToInt32);
            int[] totalMonthSalaryTest = new int[] { 636, 636, 212, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 312, 312, 312, 104, 0, 0, 0, 312, 312, 312, 104, 0, 0, 0, 0, 0, 0 };
            CollectionAssert.AreEqual(monthTotalSalary, totalMonthSalaryTest);

            List<int> weekTotalSalary = employeeStatsManager.ShowOverallStatistics("Total salary", "week", date, "FULLTIME", "all").ConvertAll(Convert.ToInt32);
            int[] weekSalaryTest = new int[] { 636, 636, 636, 212, 0, 0, 0 };
            CollectionAssert.AreEqual(weekTotalSalary, weekSalaryTest);
        }

        [TestMethod()]
        public void ShowOverallStatisticsFilteredByContractEightyPercent()
        {
            employeeStatsManager = new EmpStatisticManager(DatabaseType.TEST);
            DateTime date = new DateTime(2021, 06, 01, 9, 15, 0);

            List<int> yearTotalSalary = employeeStatsManager.ShowOverallStatistics("Total salary", "year", date, "EIGHTYPERCENT", "all").ConvertAll(Convert.ToInt32);
            int[] totalYearSalaryTest = new int[] { 0, 0, 0, 0, 120, 1160, 0, 0, 0, 0, 0, 0 };
            CollectionAssert.AreEqual(yearTotalSalary, totalYearSalaryTest);

            List<int> monthTotalSalary = employeeStatsManager.ShowOverallStatistics("Total salary", "month", date, "EIGHTYPERCENT", "all").ConvertAll(Convert.ToInt32);
            int[] totalMonthSalaryTest = new int[] { 120, 80, 0, 0, 0, 0, 120, 120, 80, 0, 0, 0, 0, 120, 120, 80, 0, 0, 0, 0, 120, 120, 80, 0, 0, 0, 0, 0, 0, 0 };
            CollectionAssert.AreEqual(monthTotalSalary, totalMonthSalaryTest);

            List<int> weekTotalSalary = employeeStatsManager.ShowOverallStatistics("Total salary", "week", date, "EIGHTYPERCENT", "all").ConvertAll(Convert.ToInt32);
            int[] weekSalaryTest = new int[] { 120, 120, 80, 0, 0, 0, 0 };
            CollectionAssert.AreEqual(weekTotalSalary, weekSalaryTest);
        }

        [TestMethod()]
        public void ShowOverallStatisticsFilteredByContractFlex()
        {
            employeeStatsManager = new EmpStatisticManager(DatabaseType.TEST);
            DateTime date = new DateTime(2021, 06, 01, 9, 15, 0);

            List<int> yearTotalSalary = employeeStatsManager.ShowOverallStatistics("Total salary", "year", date, "FLEX", "all").ConvertAll(Convert.ToInt32);
            int[] totalYearSalaryTest = new int[] { 0, 0, 0, 0, 180, 1868, 0, 0, 0, 0, 0, 0 };
            CollectionAssert.AreEqual(yearTotalSalary, totalYearSalaryTest);

            List<int> monthTotalSalary = employeeStatsManager.ShowOverallStatistics("Total salary", "month", date, "FLEX", "all").ConvertAll(Convert.ToInt32);
            int[] totalMonthSalaryTest = new int[] { 180, 144, 104, 160, 160, 160, 120, 120, 80, 0, 0, 0, 0, 120, 120, 80, 0, 0, 0, 0, 120, 120, 80, 0, 0, 0, 0, 0, 0, 0 };
            CollectionAssert.AreEqual(monthTotalSalary, totalMonthSalaryTest);

            List<int> weekTotalSalary = employeeStatsManager.ShowOverallStatistics("Total salary", "week", date, "FLEX", "all").ConvertAll(Convert.ToInt32);
            int[] weekSalaryTest = new int[] { 180, 180, 144, 104, 160, 160, 0 };
            CollectionAssert.AreEqual(weekTotalSalary, weekSalaryTest);
        }

        [TestMethod()]
        public void ShowOverallStatisticsFilteredByPosition()
        {
            employeeStatsManager = new EmpStatisticManager(DatabaseType.TEST);
            DateTime date = new DateTime(2021, 06, 01, 9, 15, 0);

            List<int> hr = employeeStatsManager.ShowOverallStatistics("Total salary", "week", date, "no contract", "HR").ConvertAll(Convert.ToInt32);
            int[] hrTest = new int[] { 0, 0, 0, 0, 0, 0, 0 };
            CollectionAssert.AreEqual(hr, hrTest);

            List<int> sTOREWORKER = employeeStatsManager.ShowOverallStatistics("Total salary", "week", date, "no contract", "STORE_WORKER").ConvertAll(Convert.ToInt32);
            int[] sTOREWORKERTEST = new int[] { 936, 936, 860, 316, 160, 160, 0 };
            CollectionAssert.AreEqual(sTOREWORKER, sTOREWORKERTEST);

            List<int> storeManager = employeeStatsManager.ShowOverallStatistics("Total salary", "week", date, "no contract", "STORE_MANAGER").ConvertAll(Convert.ToInt32);
            int[] storeManagerTest = new int[] { 0, 0, 0, 0, 0, 0, 0 };
            CollectionAssert.AreEqual(storeManager, storeManagerTest);

            List<int> stockWORKER = employeeStatsManager.ShowOverallStatistics("Total salary", "week", date, "no contract", "STOCK_WORKER").ConvertAll(Convert.ToInt32);
            int[] stockWORKERTest = new int[] { 0, 0, 0, 0, 0, 0, 0 };
            CollectionAssert.AreEqual(stockWORKER, stockWORKERTest);

            List<int> stockManager = employeeStatsManager.ShowOverallStatistics("Total salary", "week", date, "no contract", "STOCK_MANAGER").ConvertAll(Convert.ToInt32);
            int[] stockManagerTest = new int[] { 0, 0, 0, 0, 0, 0, 0 };
            CollectionAssert.AreEqual(stockManager, stockManagerTest);
        }

        [TestMethod()]
        public void ShowOverallStatisticsFilteredByDepartment()
        {
            employeeStatsManager = new EmpStatisticManager(DatabaseType.TEST);
            DateTime date = new DateTime(2021, 06, 01, 9, 15, 0);

            List<int> yearTotalSalary = employeeStatsManager.ShowDepartmentOverallStatistics("Total salary", "year", date, "2678", "no contract").ConvertAll(Convert.ToInt32);
            int[] totalYearSalaryTest = new int[] { 0, 0, 0, 0, 804, 5404, 0, 0, 0, 0, 0, 0 };
            CollectionAssert.AreEqual(yearTotalSalary, totalYearSalaryTest);

            List<int> monthTotalSalary = employeeStatsManager.ShowDepartmentOverallStatistics("Total salary", "month", date, "2678", "no contract").ConvertAll(Convert.ToInt32);
            int[] totalMonthSalaryTest = new int[] { 804, 768, 312, 160, 160, 160, 120, 120, 80, 0, 0, 0, 0, 432, 432, 392, 104, 0, 0, 0, 432, 432, 392, 104, 0, 0, 0, 0, 0, 0 };
            CollectionAssert.AreEqual(monthTotalSalary, totalMonthSalaryTest);

            List<int> weekTotalSalary = employeeStatsManager.ShowDepartmentOverallStatistics("Total salary", "week", date, "2678", "no contract").ConvertAll(Convert.ToInt32);
            int[] weekSalaryTest = new int[] { 804, 804, 768, 312, 160, 160, 0 };
            CollectionAssert.AreEqual(weekTotalSalary, weekSalaryTest);

            List<int> yearTotalSalaryD = employeeStatsManager.ShowDepartmentOverallStatistics("Total salary", "year", date, "1000", "no contract").ConvertAll(Convert.ToInt32);
            int[] totalYearSalaryTestD = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            CollectionAssert.AreEqual(yearTotalSalaryD, totalYearSalaryTestD);

            List<int> monthTotalSalaryD = employeeStatsManager.ShowDepartmentOverallStatistics("Total salary", "month", date, "1000", "no contract").ConvertAll(Convert.ToInt32);
            int[] totalMonthSalaryTestD = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            CollectionAssert.AreEqual(monthTotalSalaryD, totalMonthSalaryTestD);

            List<int> weekTotalSalaryD = employeeStatsManager.ShowDepartmentOverallStatistics("Total salary", "week", date, "1000", "no contract").ConvertAll(Convert.ToInt32);
            int[] weekSalaryTestD = new int[] { 0, 0, 0, 0, 0, 0, 0 };
            CollectionAssert.AreEqual(weekTotalSalaryD, weekSalaryTestD);
        }

        [TestMethod()]
        public void GetWeekNumberTest()
        {
            employeeStatsManager = new EmpStatisticManager(DatabaseType.TEST);
            DateTime date = new DateTime(2021, 06, 01, 9, 15, 0);
            Assert.AreEqual(22, employeeStatsManager.GetWeekNumber(date));
        }

         [TestMethod()]
        public void GetDaysOfWeekTest()
        {
            employeeStatsManager = new EmpStatisticManager(DatabaseType.TEST);
            DateTime date = new DateTime(2021, 06, 01, 9, 15, 0);
            int i = 31;
            foreach(DateTime day in employeeStatsManager.GetDaysOfWeek(date))
            {
                Assert.AreEqual(day.Day.ToString() , i.ToString());
                if(i==31)
                {
                    i=1;
                }
                else { i++; }
            }
        }


    }
}
