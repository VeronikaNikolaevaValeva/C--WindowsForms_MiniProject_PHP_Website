using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectClasses;

namespace EmployeeUnitTests
{
    [TestClass]
    public class EmployeeTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EmployeeIdLessThanZero()
        {
            new Employee(-1, "Bsn", "FirstName", "LastName", Gender.MALE,
                        "Email", "Username", DateTime.Now.AddYears(-10),
                        "Street", "StreetNumber", "Zipcode", "Town", "Country",
                        DateTime.Now, "PhoneNumber", "iban", 20, DateTime.Now,
                        ContractType.EIGHTYPERCENT, EmployeeType.HR);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EmployeeEmptyBsn()
        {
            new Employee(0, "", "FirstName", "LastName", Gender.MALE,
                        "Email", "Username", DateTime.Now.AddYears(-10),
                        "Street", "StreetNumber", "Zipcode", "Town", "Country",
                        DateTime.Now, "PhoneNumber", "iban", 20, DateTime.Now,
                        ContractType.EIGHTYPERCENT, EmployeeType.HR);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EmployeeEmptyFName()
        {
            new Employee(0, "Bsn", "", "LastName", Gender.MALE,
                        "Email", "Username", DateTime.Now.AddYears(-10),
                        "Street", "StreetNumber", "Zipcode", "Town", "Country",
                        DateTime.Now, "PhoneNumber", "iban", 20, DateTime.Now,
                        ContractType.EIGHTYPERCENT, EmployeeType.HR);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EmployeeEmptyLName()
        {
            new Employee(0, "Bsn", "FirstName", "", Gender.MALE,
                        "Email", "Username", DateTime.Now.AddYears(-10),
                        "Street", "StreetNumber", "Zipcode", "Town", "Country",
                        DateTime.Now, "PhoneNumber", "iban", 20, DateTime.Now,
                        ContractType.EIGHTYPERCENT, EmployeeType.HR);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EmployeeEmptyEmail()
        {
            new Employee(0, "Bsn", "FirstName", "LastName", Gender.MALE,
                        "", "Username", DateTime.Now.AddYears(-10),
                        "Street", "StreetNumber", "Zipcode", "Town", "Country",
                        DateTime.Now, "PhoneNumber", "iban", 20, DateTime.Now,
                        ContractType.EIGHTYPERCENT, EmployeeType.HR);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EmployeeEmptyUName()
        {
            new Employee(0, "Bsn", "FirstName", "LastName", Gender.MALE,
                        "Email", "", DateTime.Now.AddYears(-10),
                        "Street", "StreetNumber", "Zipcode", "Town", "Country",
                        DateTime.Now, "PhoneNumber", "iban", 20, DateTime.Now,
                        ContractType.EIGHTYPERCENT, EmployeeType.HR);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EmployeeEmptyStreet()
        {
            new Employee(0, "Bsn", "FirstName", "LastName", Gender.MALE,
                        "Email", "Username", DateTime.Now.AddYears(-10),
                        "", "StreetNumber", "Zipcode", "Town", "Country",
                        DateTime.Now, "PhoneNumber", "iban", 20, DateTime.Now,
                        ContractType.EIGHTYPERCENT, EmployeeType.HR);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EmployeeEmptyStreetNumber()
        {
            new Employee(0, "Bsn", "FirstName", "LastName", Gender.MALE,
                        "Email", "Username", DateTime.Now.AddYears(-10),
                        "Street", "", "Zipcode", "Town", "Country",
                        DateTime.Now, "PhoneNumber", "iban", 20, DateTime.Now,
                        ContractType.EIGHTYPERCENT, EmployeeType.HR);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EmployeeEmptyZipcode()
        {
            new Employee(0, "Bsn", "FirstName", "LastName", Gender.MALE,
                        "Email", "Username", DateTime.Now.AddYears(-10),
                        "Street", "StreetNumber", "", "Town", "Country",
                        DateTime.Now, "PhoneNumber", "iban", 20, DateTime.Now,
                        ContractType.EIGHTYPERCENT, EmployeeType.HR);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EmployeeEmptyTown()
        {
            new Employee(0, "Bsn", "FirstName", "LastName", Gender.MALE,
                        "Email", "Username", DateTime.Now.AddYears(-10),
                        "Street", "StreetNumber", "Zipcode", "", "Country",
                        DateTime.Now, "PhoneNumber", "iban", 20, DateTime.Now,
                        ContractType.EIGHTYPERCENT, EmployeeType.HR);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EmployeeEmptyCountry()
        {
            new Employee(0, "Bsn", "FirstName", "LastName", Gender.MALE,
                        "Email", "Username", DateTime.Now.AddYears(-10),
                        "Street", "StreetNumber", "Zipcode", "Town", "",
                        DateTime.Now, "PhoneNumber", "iban", 20, DateTime.Now,
                        ContractType.EIGHTYPERCENT, EmployeeType.HR);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EmployeeEmptyPhoneNumber()
        {
            new Employee(0, "Bsn", "FirstName", "LastName", Gender.MALE,
                        "Email", "Username", DateTime.Now.AddYears(-10),
                        "Street", "StreetNumber", "Zipcode", "Town", "Country",
                        DateTime.Now, "", "iban", 20, DateTime.Now,
                        ContractType.EIGHTYPERCENT, EmployeeType.HR);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EmployeeEmptyIban()
        {
            new Employee(0, "Bsn", "FirstName", "LastName", Gender.MALE,
                        "Email", "Username", DateTime.Now.AddYears(-10),
                        "Street", "StreetNumber", "Zipcode", "Town", "Country",
                        DateTime.Now, "PhoneNumber", "", 20, DateTime.Now,
                        ContractType.EIGHTYPERCENT, EmployeeType.HR);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EmployeeHSalaryLessThanOne()
        {
            new Employee(0, "Bsn", "FirstName", "LastName", Gender.MALE,
                        "Email", "Username", DateTime.Now.AddYears(-10),
                        "Street", "StreetNumber", "Zipcode", "Town", "Country",
                        DateTime.Now, "PhoneNumber", "iban", 0, DateTime.Now,
                        ContractType.EIGHTYPERCENT, EmployeeType.HR);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EmployeeFirstWorkingDayBeforeBirthDay()
        {
            new Employee(0, "Bsn", "FirstName", "LastName", Gender.MALE,
                        "Email", "Username", DateTime.Now.AddDays(1),
                        "Street", "StreetNumber", "Zipcode", "Town", "Country",
                        DateTime.Now, "PhoneNumber", "iban", 20, DateTime.Now,
                        ContractType.EIGHTYPERCENT, EmployeeType.HR);
        }
        [TestMethod]
        [ExpectedException(typeof(RepeatingObjectException))]
        public void CreateSameEmployeesTestDatabase()
        {
            EmployeeManager employeeManager = new EmployeeManager(DatabaseType.TEST);
            employeeManager.AddEmployee(new Employee(0, "Bsn", "FirstName", "LastName", Gender.MALE,
                        "Email", "Username", DateTime.Now.AddYears(-10),
                        "Street", "StreetNumber", "Zipcode", "Town", "Country",
                        DateTime.Now, "PhoneNumber", "iban", 20, DateTime.Now,
                        ContractType.EIGHTYPERCENT, EmployeeType.HR));
            employeeManager.AddEmployee(new Employee(0, "Bsn", "FirstName", "LastName", Gender.MALE,
                        "Email", "Username", DateTime.Now.AddYears(-10),
                        "Street", "StreetNumber", "Zipcode", "Town", "Country",
                        DateTime.Now, "PhoneNumber", "iban", 20, DateTime.Now,
                        ContractType.EIGHTYPERCENT, EmployeeType.HR));
        }
        [TestMethod]
        public void DeletNonexistentEmployee()
        {
            EmployeeManager employeeManager = new EmployeeManager(DatabaseType.TEST);
            Assert.IsFalse(employeeManager.DeleteEmployee(new Employee(0, "Bsn", "FirstName", "LastName", Gender.MALE,
                            "Email", "Username", DateTime.Now.AddYears(-10),
                            "Street", "StreetNumber", "Zipcode", "Town", "Country",
                            DateTime.Now, "PhoneNumber", "iban", 20, DateTime.Now,
                            ContractType.EIGHTYPERCENT, EmployeeType.HR)));
        }


    }
}
