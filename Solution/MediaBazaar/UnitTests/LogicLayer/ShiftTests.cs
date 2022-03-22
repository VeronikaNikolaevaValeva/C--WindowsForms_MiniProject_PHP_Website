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
    public class ShiftTests
    {
        [TestMethod()]
        public void ShiftTest()
        {
            Shift newShift = new Shift(ShiftType.Morning, new DateTime(2021,06,01), new List<Employee>());
            Shift newShift1 = new Shift(ShiftType.Evening, new DateTime(2021, 06, 01), new List<Employee>());
            Shift newShift2 = new Shift(ShiftType.Night, new DateTime(2021, 06, 05), new List<Employee>());
            Assert.AreEqual(newShift.Type,ShiftType.Morning);
            Assert.AreEqual(newShift1.Type, ShiftType.Evening);
            Assert.AreEqual(newShift2.Type, ShiftType.Night);
            Assert.AreEqual(newShift.Date, new DateTime(2021, 06, 01));
            Assert.AreEqual(newShift1.Date, new DateTime(2021, 06, 01));
            Assert.AreEqual(newShift2.Date, new DateTime(2021, 06, 05));
            Assert.AreEqual(newShift.AssignableEmployees, 5);
            Assert.AreEqual(newShift1.AssignableEmployees, 10);
            Assert.AreEqual(newShift2.AssignableEmployees, 10);
            CollectionAssert.AreEqual(newShift.GetAssignedEmployees(), new List<Employee>());
        }

        [TestMethod()]
        public void GetAssignedEmployeesTest()
        {
            Shift newShift = new Shift(ShiftType.Morning, new DateTime(2021, 06, 01), new List<Employee>());
            Employee employee= new Employee(1, "1", "1", "1", Gender.MALE, "11", "1", new DateTime(), "1", "1", "1", "1", "1", new DateTime(), "1", "1", 1, new DateTime(), ContractType.FULLTIME, EmployeeType.STORE_WORKER);
            newShift.AssignEmployee(employee);
            Assert.AreEqual(1, newShift.GetAssignedEmployees().Count);
            Assert.AreEqual(employee.Id,newShift.GetAssignedEmployees()[0].Id);
        }

        [TestMethod()]
        public void GetAssignedEmployeesIdsTest()
        {
            Shift newShift = new Shift(ShiftType.Morning, new DateTime(2021, 06, 01), new List<Employee>());
            Employee employee = new Employee(1, "1", "1", "1", Gender.MALE, "11", "1", new DateTime(), "1", "1", "1", "1", "1", new DateTime(), "1", "1", 1, new DateTime(), ContractType.FULLTIME, EmployeeType.STORE_WORKER);
            newShift.AssignEmployee(employee);
            Assert.AreEqual(1, newShift.GetAssignedEmployeesIds().Count);
            Assert.AreEqual(employee.Id, newShift.GetAssignedEmployeesIds()[0]);
            newShift.RemoveEmployee(1);
            Assert.AreEqual(-1, newShift.GetAssignedEmployeesIds()[0]);
        }

        [TestMethod()]
        public void AssignEmployeeTest()
        {
            Shift newShift = new Shift(ShiftType.Morning, new DateTime(2021, 06, 01), new List<Employee>());
            Employee employee = new Employee(1, "1", "1", "1", Gender.MALE, "11", "1", new DateTime(), "1", "1", "1", "1", "1", new DateTime(), "1", "1", 1, new DateTime(), ContractType.FULLTIME, EmployeeType.STORE_WORKER);
            newShift.AssignEmployee(employee);
            Assert.AreEqual(1, newShift.GetAssignedEmployees().Count);
        }

        [TestMethod()]
        public void RemoveEmployeeTest()
        {
            Shift newShift = new Shift(ShiftType.Morning, new DateTime(2021, 06, 01), new List<Employee>());
            Employee employee = new Employee(1, "1", "1", "1", Gender.MALE, "11", "1", new DateTime(), "1", "1", "1", "1", "1", new DateTime(), "1", "1", 1, new DateTime(), ContractType.FULLTIME, EmployeeType.STORE_WORKER);
            newShift.AssignEmployee(employee);
            Assert.IsTrue(newShift.RemoveEmployee(1));
        }
    }
}