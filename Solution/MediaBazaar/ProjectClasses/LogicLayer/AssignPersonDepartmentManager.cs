using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClasses
{
    public class AssignPersonDepartmentManager
    {
        private List<AssignPersonDepartment> assignPersonDepartments;
        private DBMediatorAssignPersonDepartment dbMediator;
        //private List<AssignDepartmentManagerDepartment> dmd;

        public AssignPersonDepartmentManager(DatabaseType databaseType)
        {
            this.assignPersonDepartments = new List<AssignPersonDepartment>();
            this.dbMediator = new DBMediatorAssignPersonDepartment(databaseType);
            //this.dmd = new List<AssignDepartmentManagerDepartment>();
        }

        public void AssignDeparmentManager(AssignPersonDepartment aDMDepartment)
        {
            if(this.dbMediator.CheckIfDepartmentManagerExist(aDMDepartment.Person.Id) == true)
            {
                throw new AssignDMDepartmentException(aDMDepartment.Person.GetEmployeeNames, aDMDepartment.Department.Name);
            }
            this.dbMediator.AssignDepartmentManagerToDepartment(aDMDepartment.Department.Code, aDMDepartment.Person.Id);
            //MIGHT WANT TO TEST THIS
            //this.dmDepartments.Add(dMDepartment);
        }

        public List<AssignPersonDepartment> GetDepartmentManager(int code)
        {
            this.assignPersonDepartments = this.dbMediator.GetDepartmentManagers(code);
            return this.assignPersonDepartments;
        }

        public void RemoveDepartmentManager(int id)
        {
            this.dbMediator.RemoveDepartmentManager(id);
        }

        //public List<AssignDepartmentManagerDepartment> Check()
        //{
        //    return this.dmd;
        //}

        public bool CheckIfDepartmentManagerExist(int id)
        {
            if(this.dbMediator.CheckIfDepartmentManagerExist(id) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //MIGHT REMOVE THIS
        public int GetDepartmentCode(int id)
        {
            int code = this.dbMediator.GetDepartmentCode(id);
            return code;
        }

        //MIGHT REMOVE THIS
        public string GetDepartmentName(int id)
        {
            string name = this.dbMediator.GetDepartmentName(id);
            return name;
        }

        public Department GetAssignDepartment(int id)
        {
            Department getAssignDepartment = this.dbMediator.GetAssignDepartment(id);
            return getAssignDepartment;
        }

        public void AssignStoreWorkerDepartment(AssignPersonDepartment aSWDepartment)
        {
            if(this.dbMediator.CheckIfStoreWorkerExist(aSWDepartment.Person.Id) == true)
            {
                throw new AssignDMDepartmentException(aSWDepartment.Person.GetEmployeeNames, aSWDepartment.Department.Name);
            }
            this.dbMediator.AssignStoreWorkerToDepartment(aSWDepartment.Department.Code, aSWDepartment.Person.Id);
        }

        public List<AssignPersonDepartment> GetStoreWorker(int code)
        {
            this.assignPersonDepartments = this.dbMediator.GetStoreWorkers(code);
            return this.assignPersonDepartments;
        }

        public void RemoveStoreWorker(int id)
        {
            this.dbMediator.RemoveStoreWorker(id);
        }
    }
}
