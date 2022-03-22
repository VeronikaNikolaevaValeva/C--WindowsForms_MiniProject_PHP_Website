using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClasses
{
    class DBMediatorAssignPersonDepartment : DBMediator
    {
        public DBMediatorAssignPersonDepartment(DatabaseType databaseType) : base(databaseType) { }

        //ASSIGN DEPARTMENT MANAGER TO DEPARTMENT
        public void AssignDepartmentManagerToDepartment(int code, int managerId)
        {
            string sqlStatement = "INSERT INTO mb_department_dmanager (dept_code, dmanager_id) VALUES (@c, @i);";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection);
            sqlCommand.Parameters.AddWithValue("@c", code);
            sqlCommand.Parameters.AddWithValue("@i", managerId);

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

        //GET DEPARTMENT MANAGER FROM DEPARTMENT
        public List<AssignPersonDepartment> GetDepartmentManagers(int code)
        {
            string sqlStatement = "SELECT e.*, d.*, IF(now() >= c.startdate and now() < c.lastdate, c.contract, 'LEFT') AS 'contracttype', " +
                "IF(now() >= c.startdate and now() < c.lastdate, c.startdate, '1/1/0001 12:00:00') AS 'contractstartdate' " +
                "FROM `mb_employee` as e LEFT JOIN mb_employee_contract AS c on e.id = c.empid INNER JOIN mb_department_dmanager as m " +
                "on e.id = m.dmanager_id INNER JOIN mb_department as d on m.dept_code = d.code WHERE lastdate IN(SELECT max(c2.lastdate) " +
                "FROM mb_employee_contract AS c2 WHERE c2.empid = c.empid) AND m.dept_code = @c group by e.id";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection);
            List<AssignPersonDepartment> assignPerson = new List<AssignPersonDepartment>();

            try
            {
                MySqlDataReader reader;
                sqlCommand.Parameters.AddWithValue("@c", code);
                DbConnection.Open();
                reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    Enum.TryParse(reader["contracttype"].ToString(), out ContractType contracttype);
                    Enum.TryParse(reader["position"].ToString(), out EmployeeType position);
                    Enum.TryParse(reader["gender"].ToString(), out Gender gender);
               

                    assignPerson.Add(new AssignDepartmentManagerDepartment(new Department((int)reader["code"],(string)reader["dept_name"]),
                        new Employee(Convert.ToInt32(reader["id"]), reader["bsn"].ToString(),
                        reader["fname"].ToString(), reader["lname"].ToString(), gender,
                        reader["email"].ToString(), reader["uname"].ToString(),
                        Convert.ToDateTime(reader["birthdate"].ToString()), reader["street"].ToString(),
                        reader["streetnumber"].ToString(), reader["zipcode"].ToString(), reader["town"].ToString(),
                        reader["country"].ToString(), Convert.ToDateTime(reader["firstworkingday"].ToString()),
                        reader["emergphonenumber"].ToString(), reader["iban"].ToString(),
                        Convert.ToDouble(reader["hourlywage"]),
                        Convert.ToDateTime(reader["contractstartdate"].ToString()), contracttype, position)));
                }
                return assignPerson;
            }
            finally
            {
                DbConnection.Close();
            }
        }

        //REMOVE/UNASSIGN DEPARTMENT MANAGER
        public void RemoveDepartmentManager(int id)
        {
            string sqlStatement = "DELETE FROM mb_department_dmanager WHERE dmanager_id = @i";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection);
            sqlCommand.Parameters.AddWithValue("@i", id);

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

        //CHECK IF THIS DEPARTMENT MANAGER EXIST
        public bool CheckIfDepartmentManagerExist(int id)
        {
            string sqlStatement = "SELECT* FROM mb_department AS d INNER JOIN mb_department_dmanager AS m " +
                "ON d.code = m.dept_code INNER JOIN mb_employee AS e ON m.dmanager_id = e.id WHERE m.dmanager_id = @i";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection);
            sqlCommand.Parameters.AddWithValue("@i", id);

            try
            {
                DbConnection.Open();
                Object person = sqlCommand.ExecuteScalar();

                if (person != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            finally
            {
                DbConnection.Close();
            }
        }

        //public bool CheckIfDempartmentManagerIsUnassign()
        //{
        //    string sqlStatement = "SELECT* FROM mb_department AS d INNER JOIN mb_department_dmanager AS m " +
        //        "ON d.code = m.dept_code INNER JOIN mb_employee AS e ON m.dmanager_id = e.id";
        //    MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection);

        //}

        //MIGHT REMOVE THIS METHOD
        //GET DEPARTMENT CODE BY GIVING DEPARTMENT MANAGER ID
        public int GetDepartmentCode(int id)
        {
            string sqlStatement = "SELECT dept_code FROM mb_department_dmanager WHERE dmanager_id = @i";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection);
            sqlCommand.Parameters.AddWithValue("@i", id);

            try
            {
                DbConnection.Open();
                Object code = sqlCommand.ExecuteScalar();

                if (code != null)
                {
                    return Convert.ToInt32(code);
                }
                else
                {
                    return 0;
                }
            }
            finally
            {
                DbConnection.Close();
            }
        }

        //MIGHT REMOVE THIS METHOD
        //GET DEPARTMENT NAME BY GIVING A DEPARTMENT MANAGER ID
        public string GetDepartmentName(int id)
        {
            string sqlStatement = "SELECT d.dept_name FROM mb_department AS d INNER JOIN mb_department_dmanager AS m " +
                "ON d.code = m.dept_code WHERE m.dmanager_id = @i";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection);
            sqlCommand.Parameters.AddWithValue("@i", id);

            try
            {
                DbConnection.Open();
                Object departmentName = sqlCommand.ExecuteScalar();

                if (departmentName != null)
                {
                    return departmentName.ToString();
                }
                else
                {
                    return null;
                }
            }
            finally
            {
                DbConnection.Close();
            }
        }

        public Department GetAssignDepartment(int id)
        {

            string sqlStatement = "SELECT * FROM mb_department AS d INNER JOIN mb_department_dmanager AS m " +
                "ON d.code = m.dept_code WHERE m.dmanager_id = @i";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection);
            sqlCommand.Parameters.AddWithValue("@i", id);
            Department department = null;

            try
            {
                MySqlDataReader reader;
                DbConnection.Open();
                reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    department = new Department((int)reader["code"], (string)reader["dept_name"]);
                }
                return department;
            }
            finally
            {
                DbConnection.Close();
            }
        }

        // ASSIGN STORE WORKER TO DEPARTMENT
        public void AssignStoreWorkerToDepartment(int code, int id)
        {
            string sqlStatement = "INSERT INTO mb_department_storeworker (dept_code, storeworker_id) VALUES (@c, @i)";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection);
            sqlCommand.Parameters.AddWithValue("@c", code);
            sqlCommand.Parameters.AddWithValue("@i", id);

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

        //GET STORE WORKER FROM DEPARTMENT
        public List<AssignPersonDepartment> GetStoreWorkers(int code)
        {
            string sqlStatement = "SELECT e.*, d.*, IF(now() >= c.startdate and now() < c.lastdate, c.contract, 'LEFT') AS " +
                "'contracttype', IF(now() >= c.startdate and now() < c.lastdate, c.startdate, '1/1/0001 12:00:00') AS " +
                "'contractstartdate' FROM `mb_employee` as e LEFT JOIN mb_employee_contract AS c on e.id = c.empid " +
                "INNER JOIN mb_department_storeworker as s on e.id = s.storeworker_id INNER JOIN mb_department as d " +
                "on s.dept_code = d.code WHERE lastdate IN(SELECT max(c2.lastdate) FROM mb_employee_contract AS c2 " +
                "WHERE c2.empid = c.empid) AND s.dept_code = @c group by e.id";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection);
            List<AssignPersonDepartment> assignPerson = new List<AssignPersonDepartment>();

            try
            {
                MySqlDataReader reader;
                sqlCommand.Parameters.AddWithValue("@c", code);
                DbConnection.Open();
                reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    Enum.TryParse(reader["contracttype"].ToString(), out ContractType contracttype);
                    Enum.TryParse(reader["position"].ToString(), out EmployeeType position);
                    Enum.TryParse(reader["gender"].ToString(), out Gender gender);

                    assignPerson.Add(new AssignStoreWorkerDepartment(new Department((int)reader["code"], (string)reader["dept_name"]),
                        new Employee(Convert.ToInt32(reader["id"]), reader["bsn"].ToString(),
                        reader["fname"].ToString(), reader["lname"].ToString(), gender,
                        reader["email"].ToString(), reader["uname"].ToString(),
                        Convert.ToDateTime(reader["birthdate"].ToString()), reader["street"].ToString(),
                        reader["streetnumber"].ToString(), reader["zipcode"].ToString(), reader["town"].ToString(),
                        reader["country"].ToString(), Convert.ToDateTime(reader["firstworkingday"].ToString()),
                        reader["emergphonenumber"].ToString(), reader["iban"].ToString(),
                        Convert.ToDouble(reader["hourlywage"]),
                        Convert.ToDateTime(reader["contractstartdate"].ToString()), contracttype, position)));
                }
                return assignPerson;
            }
            finally
            {
                DbConnection.Close();
            }
        }
        
        //REMOVE STORE WORKER/UNASSIGN STORE WORKER
        public void RemoveStoreWorker(int id)
        {
            string sqlStatement = "DELETE FROM mb_department_storeworker WHERE storeworker_id = @i";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection);
            sqlCommand.Parameters.AddWithValue("@i", id);

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

        public bool CheckIfStoreWorkerExist(int id)
        {
            string sqlStatement = "SELECT* FROM mb_department AS d INNER JOIN mb_department_storeworker AS s " +
                "ON d.code = s.dept_code INNER JOIN mb_employee AS e ON s.storeworker_id = e.id WHERE s.storeworker_id = @i";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection);
            sqlCommand.Parameters.AddWithValue("@i", id);

            try
            {
                DbConnection.Open();
                Object person = sqlCommand.ExecuteScalar();

                if (person != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            finally
            {
                DbConnection.Close();
            }
        }
    }
}
