using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClasses
{
    public class EmployeeManager
    {
        //Instance variables
        private List<Employee> employees;
        private DBMediatorEmployee dbMediator;

        //Constructor
        public EmployeeManager(DatabaseType databaseType)
        {
            employees = new List<Employee>();
            dbMediator = new DBMediatorEmployee(databaseType);
        }

        //Methods
        public bool AddEmployee(Employee newEmp)
        {
            foreach (Employee employee in employees)
            {
                if (employee.BSN == newEmp.BSN)
                {
                    throw new RepeatingObjectException();
                }
            }
            return AddEmployeeToDb(newEmp);
        }
        public List<Employee> GetEmployees()
        {
            return this.employees;
        }
        public bool ChangePassword(string password, int id)
        {
            return dbMediator.ChangePassword(password, id);
        }
        public bool DeleteEmployeeFromDb(int id)
        {
            return dbMediator.DeleteEmployee(id);
        }
        public List<Employee> GetListOFAllEmployees()
        {
            this.employees = dbMediator.GetEmployees();
            return employees;
        }
        public bool DeleteEmployee(Employee emp)
        {
            return employees.Remove(emp);
        }
        public Employee Login(string username, string password)
        {
            return dbMediator.FindMatchingLoginInfo(username, password);
        }
        public void UpdateEmployees()
        {
            this.employees = dbMediator.GetEmployees();
        }
        public bool ChangeWorkContractDB(ContractType contract, Employee employee)//<3
        {
            return dbMediator.ChangeWorkContract(contract, employee);
        }
        public bool UpdateEmployeeInfoDB(Employee newEmpInfo)
        {
            return dbMediator.EditPersonalInfo(newEmpInfo);
        }
        public bool AddEmployeeToDb(Employee newEmp)
        {
            if (dbMediator.CheckIfExists(newEmp.BSN))
            {
                throw new RepeatingObjectException();
            }
            employees.Add(newEmp);
            return dbMediator.AddEmployee(newEmp);
        }

    }
}
