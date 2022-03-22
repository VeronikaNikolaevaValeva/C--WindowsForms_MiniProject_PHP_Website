using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClasses
{
    public class DepartmentManager
    {
        DBMediatorDepartment dbMediator;
        List<Department> departments;
        List<Employee> employees;

        public DepartmentManager(DatabaseType databaseType)
        {
            this.dbMediator = new DBMediatorDepartment(databaseType);
            departments = new List<Department>();
            this.employees = new List<Employee>();
        }


        public void AddDepartment(Department newDept)//ADD DEPT
        {
            if (dbMediator.CheckIfDeptExist(newDept.Code, newDept.Name))
            {
                throw new RepeatingObjectException();
            }

            this.dbMediator.AddDepartment(newDept.Code, newDept.Name);
        }

        //public void AssignDManagerToDept(Department newDept, int mngId)
        //{
        //    if (dbMediator.CheckIfDManagerToDeptExists(newDept.Code, mngId))
        //    {
        //        throw new RepeatingObjectException();
        //    }

        //    this.dbMediator.AssignDManagerToDept(newDept.Code, mngId);
        //}

        public void DeleteDepartment(Department newDept)//DELETE A DEPT
        {
           this.dbMediator.DeleteDepartment(newDept.Code);
        }

        public List<Department> GetDepartments()//GET ALL DEPT
        {
            departments = this.dbMediator.GetDepartment();
            return departments;
        }

        public void UpdateDepartment(Department newDept)
        {
            this.dbMediator.UpdateDepartment(newDept.Code, newDept.Name);
        }

        //public List<Department> GetDepartmentsWithDManagers()
        //{
        //    return this.dbMediator.GetDepartmentWithDManager();
        //}

        //public List<Department> GetDepartmentsWithPCategories()
        //{
        //    return this.dbMediator.GetDepartmentWithPCategory();
        //}

        //fix these stuff after.
        public int GetDepartmentCode(string deptName)
        {
            foreach (Department depart in departments)
            {
                if (depart.Name== deptName)
                {
                    return depart.Code;
                }
            }
            return 0;
        }

        public void AddCategoryDB(string name)
        {
            if (name == "")
            {
                throw new ArgumentNullException();
            }
            else
            {
                if (dbMediator.CheckIfCategoryExist(name) == true)
                {
                    throw new RepeatingObjectException();
                }
                dbMediator.AddCategory(name);
            }
        }

        public void AssignCategory(int id, string name)
        {
            dbMediator.AssignCategory(id, name);
        }

        public void AddSubCategoryDB(string name)
        {
            if (name == "")
            {
                throw new ArgumentNullException();
            }
            else
            {
                if (dbMediator.CheckIfSubCategoryExist(name) == true)
                {
                    throw new RepeatingObjectException();
                }
                dbMediator.AddSubCategory(name);
            }
        }

        public void AssignSubcategoryDB(int id, string name)
        {
            dbMediator.AssignSubCategory(id, name);
        }

        public void AssignProductDB(int id, int pNUm)
        {
            dbMediator.AssignProduct(id, pNUm);
        }

        public bool DeleteCategoryByName(string name)
        {
            return this.dbMediator.DeleteCategoryByName(name);
        }

        public bool DeleteCategoryDB(int deptId, string name)
        {
            return dbMediator.DeleteCategory(deptId, name);
        }

        public bool DeleteSubCategoryByName(string name)
        {
            return this.dbMediator.DeleteSubCategoryByName(name);
        }

        public bool DeleteSubcategoryDB(int deptId, string catName, string name)
        {
            return dbMediator.DeleteSubcategory(deptId, catName, name);
        }

        public List<Employee> GetDepartmentManagersDB(int deptId)
        {
            this.employees = dbMediator.GetDepartmentManagers(deptId);
            return this.employees;
        }

        public List<Employee> GetStoreWorkerDB(int deptId)
        {
            this.employees = dbMediator.GetStoreWorkers(deptId);
            return this.employees;
        }

        public List<Product> GetProducts()
        {
            return dbMediator.GetProducts();
        }

        public Dictionary<Product, int> GetProduct(int id)
        {
            return dbMediator.GetProduct(id);
        }

        public Dictionary<int, string> GetCategories()
        {
            return dbMediator.GetCategories();
        }

        public List<string> GetDepartmentCategorieDB(int deptId)
        {
            return dbMediator.GetDepartmentCategories(deptId);
        }

        public Dictionary<int, string> GetSubCategories()
        {
            return dbMediator.GetSubCategories();
        }

        public List<string> GetSubCategory(int id)
        {
            return dbMediator.GetSubCategory(id);
        }

        public List<string> GetDepartmentSubcategories(int deptId, string category)
        {
            return dbMediator.GetDepartmentSubcategories(deptId, category);
        }

        public List<Employee> GetAllStoreWorkersFormDepartment(string deptCode)
        {
            return dbMediator.GetStoreWorkersFromDepartment(deptCode);
        }
    }
}
