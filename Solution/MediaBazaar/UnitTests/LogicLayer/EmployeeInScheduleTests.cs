using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectClasses.LogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClasses.LogicLayer.Tests
{
    [TestClass()]
    public class EmployeeInScheduleTests
    {
        [TestMethod()]
        public void EmployeeInScheduleTest()
        {
            Employee employee = new Employee(1, "1", "1", "1", Gender.MALE, "11", "1", new DateTime(), "1", "1", "1", "1", "1", new DateTime(), "1", "1", 1, new DateTime(), ContractType.FULLTIME, EmployeeType.STORE_WORKER);
            EmployeeInSchedule e = new EmployeeInSchedule(employee);
            Assert.AreEqual(employee.Id,e.Employee.Id);
        }

        [TestMethod()]
        public void AddAvailabilityTest()
        {
            Shift newShift = new Shift(ShiftType.Morning, new DateTime(2021, 06, 01), new List<Employee>());
            Employee employee = new Employee(1, "1", "1", "1", Gender.MALE, "11", "1", new DateTime(), "1", "1", "1", "1", "1", new DateTime(), "1", "1", 1, new DateTime(), ContractType.FULLTIME, EmployeeType.STORE_WORKER);
            EmployeeInSchedule e = new EmployeeInSchedule(employee);
            e.AddAvailability(newShift);
            Assert.AreEqual(newShift.Type, e.AvailableShifts[0].Type);
            Assert.AreEqual(1, e.AvailableShifts.Count);
        }

        [TestMethod()]
        public void CheckAvailableShiftTest()
        {
            Shift newShift = new Shift(ShiftType.Morning, new DateTime(2021, 06, 01), new List<Employee>());
            Employee employee = new Employee(1, "1", "1", "1", Gender.MALE, "11", "1", new DateTime(), "1", "1", "1", "1", "1", new DateTime(), "1", "1", 1, new DateTime(), ContractType.FULLTIME, EmployeeType.STORE_WORKER);
            EmployeeInSchedule e = new EmployeeInSchedule(employee);
            e.AddAvailability(newShift);
            Assert.IsTrue(e.CheckAvailableShift(newShift));
        }
        [TestMethod()]
        public void CheckAvailableShiftTest1()
        {
            Shift newShift = new Shift(ShiftType.Morning, new DateTime(2021, 06, 01), new List<Employee>());
            Employee employee = new Employee(1, "1", "1", "1", Gender.MALE, "11", "1", new DateTime(), "1", "1", "1", "1", "1", new DateTime(), "1", "1", 1, new DateTime(), ContractType.FULLTIME, EmployeeType.STORE_WORKER);
            EmployeeInSchedule e = new EmployeeInSchedule(employee);
            Assert.IsFalse(e.CheckAvailableShift(newShift));
        }
        [TestMethod()]
        public void ToStringTest()
        {
            Shift newShift = new Shift(ShiftType.Morning, new DateTime(2021, 06, 01), new List<Employee>());
            Employee employee = new Employee(1, "1", "1", "1", Gender.MALE, "11", "1", new DateTime(), "1", "1", "1", "1", "1", new DateTime(), "1", "1", 1, new DateTime(), ContractType.FULLTIME, EmployeeType.STORE_WORKER);
            EmployeeInSchedule e = new EmployeeInSchedule(employee);
            e.AddAvailability(newShift);
            Assert.AreEqual("ID: 1 - (Morning, 2021-06-01)",e.ToString());
        }
    }
}