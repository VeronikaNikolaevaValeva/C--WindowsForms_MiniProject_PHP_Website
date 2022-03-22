using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClasses
{
     class DBMediatorDepartment: DBMediator
     {
        public DBMediatorDepartment(DatabaseType databaseType) : base(databaseType) { }

        //ADD DEPARTMENT
        public Department AddDepartment(int code,string name)
        {
            string sqlStatement = "INSERT INTO `mb_department` (code, dept_name) VALUES (@c, @n);";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection);
            sqlCommand.Parameters.AddWithValue("@c", code);
            sqlCommand.Parameters.AddWithValue("@n", name);

            try
            {
                int n = 0;
                DbConnection.Open();
                n = sqlCommand.ExecuteNonQuery();
                if (n == 1)
                {
                    return new Department(code, name);
                }
                return null;
            }
            catch (MySqlException)
            {
                return null;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                DbConnection.Close();
            }
        }
        //DELETE DEPARTMENT
        public void DeleteDepartment(int code)
        {
            string sqlStatement = "DELETE FROM `mb_department` WHERE code= @c";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection); ;
            sqlCommand.Parameters.AddWithValue("@c", code);
            try
            {
                int n = 0;
                DbConnection.Open();
                n = sqlCommand.ExecuteNonQuery();
            }
            finally
            {
                DbConnection.Close();
            }
        }

        //GET DEPARTMENT
        public List<Department> GetDepartment()
        {
            string sqlStatement = "SELECT code, dept_name FROM mb_department";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection);
            List<Department> d = new List<Department>();

            try
            {
                MySqlDataReader reader;
                DbConnection.Open();
                reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    d.Add(new Department((int)reader["code"], (string)reader["dept_name"]));
                }
                return d;
            }
            catch (MySqlException e)
            {
                return d;
            }
            finally
            {
                DbConnection.Close();
            }
        }

        //MODIFY DEPARTMENT
        public void UpdateDepartment(int code, string name)
        {
            string sqlStatement = "UPDATE `mb_department` SET `dept_name` = @n WHERE `code` = @c";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection);
            sqlCommand.Parameters.AddWithValue("@n", name);
            sqlCommand.Parameters.AddWithValue("@c", code);

            try
            {
                int n = 0;
                DbConnection.Open();
                n = sqlCommand.ExecuteNonQuery();
            }
            finally
            {
                DbConnection.Close();
            }
        }

        //CHECK IF THE CREATED DEPARTMENT EXIST
        public bool CheckIfDeptExist(int code, string name)
        {
            string sqlStatement = "SELECT code FROM mb_department WHERE code = @c OR dept_name = @n;";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection); ;
            sqlCommand.Parameters.AddWithValue("@c", code);
            sqlCommand.Parameters.AddWithValue("@n", name);

            try
            {
                DbConnection.Open();
                Object test = sqlCommand.ExecuteScalar();

                if (test != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (MySqlException)
            {
                return false;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                DbConnection.Close();
            }
        }

        //ADD CATEGORY
        public void AssignCategory(int id, string name)
        {
            string sqlStatement = "UPDATE mb_dept_category SET dept_id = @i WHERE mb_dept_category. name = @n";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection);
            sqlCommand.Parameters.AddWithValue("@i", id);
            sqlCommand.Parameters.AddWithValue("@n", name);

            try
            {
                int n = 0;
                DbConnection.Open();
                n = sqlCommand.ExecuteNonQuery();
            }
            finally
            {
                DbConnection.Close();
            }
        }

        public bool CheckIfCategoryExist(string name)
        {
            string sqlStatement = "Select name FROM mb_dept_category where name = @n";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection);
            sqlCommand.Parameters.AddWithValue("@n", name);

            try
            {
                DbConnection.Open();
                Object test = sqlCommand.ExecuteScalar();

                if (test != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (MySqlException)
            {
                return false;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                DbConnection.Close();
            }
        }

        public void AddCategory(string name)
        {
            string sqlStatement = "INSERT INTO `mb_dept_category` (name) VALUES (@n);";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection);
            sqlCommand.Parameters.AddWithValue("@n", name);

            try
            {
                int n = 0;
                DbConnection.Open();
                n = sqlCommand.ExecuteNonQuery();
            }
            finally
            {
                DbConnection.Close();
            }
        }

        public bool CheckIfSubCategoryExist(string name)
        {
            string sqlStatement = "Select name FROM mb_dept_subcategory where name = @n";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection);
            sqlCommand.Parameters.AddWithValue("@n", name);

            try
            {
                DbConnection.Open();
                Object test = sqlCommand.ExecuteScalar();

                if (test != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (MySqlException)
            {
                return false;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                DbConnection.Close();
            }
        }

        public void AssignProduct(int id, int pNum)
        {
            string sqlStatement = "UPDATE mb_product SET subcat_id = @i WHERE mb_product . pNum  = @p";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection);
            sqlCommand.Parameters.AddWithValue("@i", id);
            sqlCommand.Parameters.AddWithValue("@p", pNum);

            try
            {
                int n = 0;
                DbConnection.Open();
                n = sqlCommand.ExecuteNonQuery();
            }
            finally
            {
                DbConnection.Close();
            }
        }

        public void AssignSubCategory(int id, string name)
        {
            string sqlStatement = "UPDATE mb_dept_subcategory SET cat_id = @i WHERE mb_dept_subcategory. name = @n";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection);
            sqlCommand.Parameters.AddWithValue("@i", id);
            sqlCommand.Parameters.AddWithValue("@n", name);

            try
            {
                int n = 0;
                DbConnection.Open();
                n = sqlCommand.ExecuteNonQuery();
            }
            finally
            {
                DbConnection.Close();
            }
        }

        //ADD Subcategory
        public void AddSubCategory(string name)
        {
            string sqlStatement = "INSERT INTO `mb_dept_subcategory` (name) VALUES (@n);";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection);
            sqlCommand.Parameters.AddWithValue("@n", name);

            try
            {
                int n = 0;
                DbConnection.Open();
                n = sqlCommand.ExecuteNonQuery();
            }
            finally
            {
                DbConnection.Close();
            }
        }

        //public bool AssignSubcategory(int deptId, string catName, string name)
        //{
        //    string sqlStatement = "INSERT INTO `mb_dept_subcategory` ( `cat_id`, `name`) VALUES " +
        //        "((SELECT id FROM mb_dept_category where dept_id=@deptId AND name = @catName), @name);";
        //    MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection);
        //    sqlCommand.Parameters.AddWithValue("@deptId", deptId);
        //    sqlCommand.Parameters.AddWithValue("@catName", catName);
        //    sqlCommand.Parameters.AddWithValue("@name", name);

        //    try
        //    {
        //        int n = 0;

        //        DbConnection.Open();
        //        n = sqlCommand.ExecuteNonQuery();
        //        if (n == 1)
        //        {
        //            return true;
        //        }
        //        return false;
        //    }
        //    catch (MySqlException)
        //    {
        //        return false;
        //    }
        //    catch (Exception)
        //    {
        //        return false;
        //    }
        //    finally
        //    {
        //        DbConnection.Close();
        //    }
        //}

        //DELETE Category
        public bool DeleteCategoryByName(string name)
        {
            string sqlStatement = "DELETE FROM `mb_dept_category` WHERE name = @name";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection); ;
            sqlCommand.Parameters.AddWithValue("@name", name);
            try
            {
                int n = 0;
                DbConnection.Open();
                n = sqlCommand.ExecuteNonQuery();

                if (n == 1)
                {
                    return true;
                }
                return false;
            }
            catch (MySqlException)
            {
                return false;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                DbConnection.Close();
            }
        }

        public bool DeleteCategory(int deptId, string name)
        {
            string sqlStatement = "DELETE FROM `mb_dept_category` WHERE dept_id=@deptId and name = @name";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection); ;
            sqlCommand.Parameters.AddWithValue("@deptId", deptId);
            sqlCommand.Parameters.AddWithValue("@name", name);
            try
            {
                int n = 0;
                DbConnection.Open();
                n = sqlCommand.ExecuteNonQuery();

                if (n == 1)
                {
                    return true;
                }
                return false;
            }
            catch (MySqlException)
            {
                return false;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                DbConnection.Close();
            }
        }

        public bool DeleteSubCategoryByName(string name)
        {
            string sqlStatement = "DELETE FROM `mb_dept_subcategory` WHERE name = @name";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection); ;
            sqlCommand.Parameters.AddWithValue("@name", name);
            try
            {
                int n = 0;
                DbConnection.Open();
                n = sqlCommand.ExecuteNonQuery();

                if (n == 1)
                {
                    return true;
                }
                return false;
            }
            catch (MySqlException)
            {
                return false;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                DbConnection.Close();
            }
        }

        //DELETE Subcategory
        public bool DeleteSubcategory(int deptId, string catName, string name)
        {
            string sqlStatement = "DELETE FROM `mb_dept_subcategory` WHERE cat_id = " +
                "(SELECT c.id FROM mb_dept_category as c WHERE dept_id = @deptId AND name = @catName) AND name = @name";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection); ;
            sqlCommand.Parameters.AddWithValue("@deptId", deptId);
            sqlCommand.Parameters.AddWithValue("@catName", catName);
            sqlCommand.Parameters.AddWithValue("@name", name);
            try
            {
                int n = 0;
                DbConnection.Open();
                n = sqlCommand.ExecuteNonQuery();

                if (n == 1)
                {
                    return true;
                }
                return false;
            }
            catch (MySqlException e)
            {
                //MessageBox.Show(sqlExceptionMessage(e.Message));
                return false;
            }
            catch (Exception e)
            {
                //MessageBox.Show(sqlExceptionMessage(e.Message));
                return false;
            }
            finally
            {
                DbConnection.Close();
            }
        }

        //Get Dept Managers
        public List<Employee> GetDepartmentManagers(int deptId)
        {
            string sqlStatement = "SELECT e.*, d.*, IF(now() >= c.startdate and now() < c.lastdate, c.contract, 'LEFT') " +
                "AS contracttype, IF(now() >= c.startdate and now() < c.lastdate, c.startdate, '1/1/0001 12:00:00') AS " +
                "contractstartdate FROM mb_employee as e LEFT JOIN mb_employee_contract AS c on e.id = c.empid " +
                "INNER JOIN mb_department_dmanager as m on e.id = m.dmanager_id INNER JOIN mb_department as d " +
                "on m.dept_code = d.code WHERE lastdate IN(SELECT max(c2.lastdate) FROM mb_employee_contract AS c2 " +
                "WHERE c2.empid = c.empid) AND m.dept_code = @i group by e.id";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection);
            sqlCommand.Parameters.AddWithValue("@i", deptId);
            List<Employee> managers = new List<Employee>();
            try
            {
                MySqlDataReader EmployeeReader;
                DbConnection.Open();

                EmployeeReader = sqlCommand.ExecuteReader();
                while (EmployeeReader.Read())
                {
                    Enum.TryParse(EmployeeReader["contracttype"].ToString(), out ContractType contracttype);
                    Enum.TryParse(EmployeeReader["position"].ToString(), out EmployeeType position);
                    Enum.TryParse(EmployeeReader["gender"].ToString(), out Gender gender);
                    managers.Add(new Employee(Convert.ToInt32(EmployeeReader["id"]), EmployeeReader["bsn"].ToString(),
                    EmployeeReader["fname"].ToString(), EmployeeReader["lname"].ToString(), gender,
                    EmployeeReader["email"].ToString(), EmployeeReader["uname"].ToString(),
                    Convert.ToDateTime(EmployeeReader["birthdate"].ToString()), EmployeeReader["street"].ToString(),
                    EmployeeReader["streetnumber"].ToString(), EmployeeReader["zipcode"].ToString(), EmployeeReader["town"].ToString(),
                    EmployeeReader["country"].ToString(), Convert.ToDateTime(EmployeeReader["firstworkingday"].ToString()),
                    EmployeeReader["emergphonenumber"].ToString(), EmployeeReader["iban"].ToString(),
                    Convert.ToDouble(EmployeeReader["hourlywage"]),
                    Convert.ToDateTime(EmployeeReader["contractstartdate"].ToString()), contracttype, position));
                }
                return managers;
            }
            catch (MySqlException)
            {
                return managers;
            }
            finally
            {
                DbConnection.Close();
            }

        }

        public List<Employee> GetStoreWorkers(int deptId)
        {
            string sqlStatement = "SELECT e.*, d.*, IF(now() >= c.startdate and now() < c.lastdate, c.contract, 'LEFT') AS " +
                "'contracttype', IF(now() >= c.startdate and now() < c.lastdate, c.startdate, '1/1/0001 12:00:00') AS " +
                "'contractstartdate' FROM `mb_employee` as e LEFT JOIN mb_employee_contract AS c on e.id = c.empid " +
                "INNER JOIN mb_department_storeworker as s on e.id = s.storeworker_id INNER JOIN mb_department as d " +
                "on s.dept_code = d.code WHERE lastdate IN(SELECT max(c2.lastdate) FROM mb_employee_contract AS c2 " +
                "WHERE c2.empid = c.empid) AND s.dept_code = @i group by e.id";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection);
            sqlCommand.Parameters.AddWithValue("@i", deptId);
            List<Employee> managers = new List<Employee>();
            try
            {
                MySqlDataReader EmployeeReader;
                DbConnection.Open();

                EmployeeReader = sqlCommand.ExecuteReader();
                while (EmployeeReader.Read())
                {
                    Enum.TryParse(EmployeeReader["contracttype"].ToString(), out ContractType contracttype);
                    Enum.TryParse(EmployeeReader["position"].ToString(), out EmployeeType position);
                    Enum.TryParse(EmployeeReader["gender"].ToString(), out Gender gender);
                    managers.Add(new Employee(Convert.ToInt32(EmployeeReader["id"]), EmployeeReader["bsn"].ToString(),
                    EmployeeReader["fname"].ToString(), EmployeeReader["lname"].ToString(), gender,
                    EmployeeReader["email"].ToString(), EmployeeReader["uname"].ToString(),
                    Convert.ToDateTime(EmployeeReader["birthdate"].ToString()), EmployeeReader["street"].ToString(),
                    EmployeeReader["streetnumber"].ToString(), EmployeeReader["zipcode"].ToString(), EmployeeReader["town"].ToString(),
                    EmployeeReader["country"].ToString(), Convert.ToDateTime(EmployeeReader["firstworkingday"].ToString()),
                    EmployeeReader["emergphonenumber"].ToString(), EmployeeReader["iban"].ToString(),
                    Convert.ToDouble(EmployeeReader["hourlywage"]),
                    Convert.ToDateTime(EmployeeReader["contractstartdate"].ToString()), contracttype, position));
                }
                return managers;
            }
            catch (MySqlException)
            {
                return managers;
            }
            finally
            {
                DbConnection.Close();
            }

        }

        public Dictionary<int, string> GetCategories()
        {
            string sqlStatement = "SELECT * FROM mb_dept_category";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection);
            Dictionary<int, string> categories = new Dictionary<int, string>();

            try
            {
                MySqlDataReader reader;
                DbConnection.Open();
                reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    categories.Add((int)reader["id"], (string)reader["name"]);
                }
                return categories;
            }
            catch (MySqlException e)
            {
                return categories;
            }
            finally
            {
                DbConnection.Close();
            }
        }

        //Get Department categories
        public List<string> GetDepartmentCategories(int deptId)
        {
            string sqlStatement = "SELECT name FROM `mb_dept_category` WHERE dept_id = @id";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection);
            sqlCommand.Parameters.AddWithValue("@id", deptId);
            List<string> categories = new List<string>();

            try
            {
                MySqlDataReader reader;
                DbConnection.Open();
                reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    categories.Add((string)reader["name"]);
                }
                return categories;
            }
            catch (MySqlException e)
            {
                return categories;
            }
            finally
            {
                DbConnection.Close();
            }
        }

        public List<Product> GetProducts()
        {
            string sqlStatement = "SELECT * FROM mb_product";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection);
            List<Product> p = new List<Product>();

            try
            {
                MySqlDataReader reader;
                DbConnection.Open();
                reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    p.Add(new Product((int)reader["pNum"], (string)reader["brand"], (string)reader["type"], (string)reader["model"],
                        (string)reader["description"], (string)reader["barcode"], (decimal)reader["cost_price"], (decimal)reader["sales_price"],
                        (int)reader["amount_in_store"], (int)reader["amount_in_warehouse"], (int)reader["minimum_amount_in_store"], (string)reader["supplier_phone_number"], (string)reader["supplier_email"]));
                }
                return p;
            }
            catch (MySqlException e)
            {
                return p;
            }
            finally
            {
                DbConnection.Close();
            }
        }

        public Dictionary<Product, int>GetProduct(int id)
        {
            string sqlStatement = "SELECT * FROM mb_product WHERE subcat_id = @i";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection);
            sqlCommand.Parameters.AddWithValue("@i", id);
            Dictionary<Product, int> p = new Dictionary<Product, int>();

            try
            {
                MySqlDataReader reader;
                DbConnection.Open();
                reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    p.Add(new Product((int)reader["pNum"], (string)reader["brand"], (string)reader["type"], (string)reader["model"],
                        (string)reader["description"], (string)reader["barcode"], (decimal)reader["cost_price"], (decimal)reader["sales_price"],
                        (int)reader["amount_in_store"], (int)reader["amount_in_warehouse"], (int)reader["minimum_amount_in_store"], (string)reader["supplier_phone_number"], (string)reader["supplier_email"]), (int)reader["subcat_id"]);
                }
                return p;
            }
            catch (MySqlException e)
            {
                return p;
            }
            finally
            {
                DbConnection.Close();
            }
        }

        public Dictionary<int,string> GetSubCategories()
        {
            string sqlStatement = "SELECT * FROM mb_dept_subcategory";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection);
            Dictionary<int, string> categories = new Dictionary<int, string>();

            try
            {
                MySqlDataReader reader;
                DbConnection.Open();
                reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    categories.Add((int)reader["id"], (string)reader["name"]);
                }
                return categories;
            }
            catch (MySqlException e)
            {
                return categories;
            }
            finally
            {
                DbConnection.Close();
            }
        }

        public List<string> GetSubCategory(int id)
        {
            string sqlStatement = "SELECT name FROM `mb_dept_subcategory` WHERE cat_id = @id";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection);
            sqlCommand.Parameters.AddWithValue("@id", id);
            List<string> categories = new List<string>();

            try
            {
                MySqlDataReader reader;
                DbConnection.Open();
                reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    categories.Add((string)reader["name"]);
                }
                return categories;
            }
            catch (MySqlException e)
            {
                return categories;
            }
            finally
            {
                DbConnection.Close();
            }
        }

        //Get Department subcategories
        public List<string> GetDepartmentSubcategories(int deptId, string category)
        {
            string sqlStatement = "SELECT name FROM `mb_dept_subcategory` WHERE cat_id = " +
                "(SELECT c.id FROM mb_dept_category as c WHERE dept_id = @dept_id AND name = @cat)";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection);
            sqlCommand.Parameters.AddWithValue("@dept_id", deptId);
            sqlCommand.Parameters.AddWithValue("@cat", category);
            List<string> categories = new List<string>();

            try
            {
                MySqlDataReader reader;
                DbConnection.Open();
                reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    categories.Add((string)reader["name"]);
                }
                return categories;
            }
            catch (MySqlException e)
            {
                return categories;
            }
            finally
            {
                DbConnection.Close();
            }
        }

        public List<Employee> GetStoreWorkersFromDepartment(string deptCode)
        {
            string sqlStatement = "SELECT e.*, c.contract as contracttype, c.startdate as contractstartdate FROM `mb_department_storeworker` AS d " +
                                  "INNER JOIN `mb_employee` AS e " +
                                  "ON d.storeworker_id = e.id " +
                                  "LEFT JOIN `mb_employee_contract` AS c on e.id = c.empid " +
                                  "WHERE d.dept_code = @deptCode";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection);
            sqlCommand.Parameters.AddWithValue("@deptCode", deptCode);
            List<Employee> employees = new List<Employee>();
            try
            {
                MySqlDataReader EmployeeReader;
                DbConnection.Open();

                EmployeeReader = sqlCommand.ExecuteReader();
                while (EmployeeReader.Read())
                {
                    Enum.TryParse(EmployeeReader["contracttype"].ToString(), out ContractType contracttype);
                    Enum.TryParse(EmployeeReader["position"].ToString(), out EmployeeType position);
                    Enum.TryParse(EmployeeReader["gender"].ToString(), out Gender gender);
                    employees.Add(new Employee(Convert.ToInt32(EmployeeReader["id"]), EmployeeReader["bsn"].ToString(),
                    EmployeeReader["fname"].ToString(), EmployeeReader["lname"].ToString(), gender,
                    EmployeeReader["email"].ToString(), EmployeeReader["uname"].ToString(),
                    Convert.ToDateTime(EmployeeReader["birthdate"].ToString()), EmployeeReader["street"].ToString(),
                    EmployeeReader["streetnumber"].ToString(), EmployeeReader["zipcode"].ToString(), EmployeeReader["town"].ToString(),
                    EmployeeReader["country"].ToString(), Convert.ToDateTime(EmployeeReader["firstworkingday"].ToString()),
                    EmployeeReader["emergphonenumber"].ToString(), EmployeeReader["iban"].ToString(),
                    Convert.ToDouble(EmployeeReader["hourlywage"]),
                    Convert.ToDateTime(EmployeeReader["contractstartdate"].ToString()), contracttype, position));
                }
                return employees;
            }
            catch (MySqlException)
            {
                return employees;
            }
            finally
            {
                DbConnection.Close();
            }
        }
    }
}
