using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClasses.Tests
{
    [TestClass()]
    public class DBMediatorShiftsTests
    {
        [TestMethod()]
        public void GetEmployeesAvailabilityPerDepartmentAndWeekNumberTest()
        {
            DBMediatorShifts mediator = new DBMediatorShifts(DatabaseType.MAIN);
            Department department = new Department(2678, "test");
            var result = mediator.GetEmployeesAvailabilityPerDepartmentAndWeekNumber(department, 22);

            Assert.IsNotNull(result);
        }
    }
}