using MySql.Data.MySqlClient;
using ProjectClasses.LogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClasses
{
    public class DBMediatorEmployee : DBMediator
    {
        //Constructor
        public DBMediatorEmployee(DatabaseType databaseType) : base(databaseType) { }

        //Methods
        public Employee FindMatchingLoginInfo(string username, string password)
        {
            string sqlStatement = $"SELECT e.* , IF(now() >= c.startdate and now() < c.lastdate, c.contract, 'LEFT') AS 'contracttype', " +
                $"IF(now() >= c.startdate and now() < c.lastdate, c.startdate, '1/1/0001 12:00:00') AS 'contractstartdate' " +
                $"FROM `mb_employee` as e LEFT JOIN mb_employee_contract AS c on e.id = c.empid " +
                $"WHERE lastdate IN(SELECT max(c2.lastdate) FROM mb_employee_contract AS c2 WHERE c2.empid = c.empid)" +
                $"AND uname = @u AND pwd= @p group by e.id";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection);
            List<Employee> emp = new List<Employee>();
            try
            {
                MySqlDataReader EmployeeReader;
                sqlCommand.Parameters.AddWithValue("@u", username);
                sqlCommand.Parameters.AddWithValue("@p", password);
                DbConnection.Open();

                EmployeeReader = sqlCommand.ExecuteReader();
                if (EmployeeReader.Read())
                {
                    Enum.TryParse(EmployeeReader["contracttype"].ToString(), out ContractType contracttype);
                    Enum.TryParse(EmployeeReader["position"].ToString(), out EmployeeType position);
                    Enum.TryParse(EmployeeReader["gender"].ToString(), out Gender gender);

                    Employee employee = new Employee(Convert.ToInt32(EmployeeReader["id"]), EmployeeReader["bsn"].ToString(),
                    EmployeeReader["fname"].ToString(), EmployeeReader["lname"].ToString(), gender,
                    EmployeeReader["email"].ToString(), EmployeeReader["uname"].ToString(),
                    Convert.ToDateTime(EmployeeReader["birthdate"].ToString()), EmployeeReader["street"].ToString(),
                    EmployeeReader["streetnumber"].ToString(), EmployeeReader["zipcode"].ToString(), EmployeeReader["town"].ToString(),
                    EmployeeReader["country"].ToString(), Convert.ToDateTime(EmployeeReader["firstworkingday"].ToString()),
                    EmployeeReader["emergphonenumber"].ToString(), EmployeeReader["iban"].ToString(),
                    Convert.ToDouble(EmployeeReader["hourlywage"]),
                    Convert.ToDateTime(EmployeeReader["contractstartdate"].ToString()), contracttype, position);
                    return employee;
                }
                else
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
        public List<Employee> GetEmployees()
        {
            string sqlStatement = $"SELECT e.* , IF(now() >= c.startdate and now() < c.lastdate, c.contract, 'LEFT') AS 'contracttype', " +
                $"IF(now() >= c.startdate and now() < c.lastdate, c.startdate, '1/1/0001 12:00:00') AS 'contractstartdate' FROM `mb_employee` as e " +
                $"LEFT JOIN mb_employee_contract AS c on e.id = c.empid WHERE lastdate IN(SELECT max(c2.lastdate) " +
                $"FROM mb_employee_contract AS c2 WHERE c2.empid = c.empid) group by e.id";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection);
            List<Employee> emp = new List<Employee>();
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
                    emp.Add(new Employee(Convert.ToInt32(EmployeeReader["id"]), EmployeeReader["bsn"].ToString(),
                    EmployeeReader["fname"].ToString(), EmployeeReader["lname"].ToString(), gender,
                    EmployeeReader["email"].ToString(), EmployeeReader["uname"].ToString(),
                    Convert.ToDateTime(EmployeeReader["birthdate"].ToString()), EmployeeReader["street"].ToString(),
                    EmployeeReader["streetnumber"].ToString(), EmployeeReader["zipcode"].ToString(), EmployeeReader["town"].ToString(),
                    EmployeeReader["country"].ToString(), Convert.ToDateTime(EmployeeReader["firstworkingday"].ToString()),
                    EmployeeReader["emergphonenumber"].ToString(), EmployeeReader["iban"].ToString(),
                    Convert.ToDouble(EmployeeReader["hourlywage"]),
                    Convert.ToDateTime(EmployeeReader["contractstartdate"].ToString()), contracttype, position));
                }
                return emp;
            }
            catch (MySqlException)
            {
                return emp;
            }
            finally
            {
                DbConnection.Close();
            }

        }
        public bool AddEmployee(Employee newEmp)
        {
            MySqlTransaction tr = null;
            try
            {
                DbConnection.Open();
                tr = this.DbConnection.BeginTransaction();

                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = DbConnection,
                    Transaction = tr,
                };
                cmd.CommandText = "INSERT INTO mb_employee (bsn, fname, lname, gender, email, uname, pwd, birthdate, street, streetnumber, zipcode, town, country, firstworkingday, emergphonenumber, iban, hourlywage, position)" +
                "VALUES(@1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14, @15, @16, @17, @18);";
                cmd.Parameters.AddWithValue("@1", newEmp.BSN);
                cmd.Parameters.AddWithValue("@2", newEmp.FirstName);
                cmd.Parameters.AddWithValue("@3", newEmp.LastName);
                cmd.Parameters.AddWithValue("@4", newEmp.Gender.ToString());
                cmd.Parameters.AddWithValue("@5", newEmp.Email);
                cmd.Parameters.AddWithValue("@6", newEmp.Username);
                cmd.Parameters.AddWithValue("@7", 0000);
                cmd.Parameters.AddWithValue("@8", newEmp.Birthday);
                cmd.Parameters.AddWithValue("@9", newEmp.Street);
                cmd.Parameters.AddWithValue("@10", newEmp.StreetNumber);
                cmd.Parameters.AddWithValue("@11", newEmp.Zipcode);
                cmd.Parameters.AddWithValue("@12", newEmp.Town);
                cmd.Parameters.AddWithValue("@13", newEmp.Country);
                cmd.Parameters.AddWithValue("@14", newEmp.FirstWorkingDay);
                cmd.Parameters.AddWithValue("@15", newEmp.PhoneNumber);
                cmd.Parameters.AddWithValue("@16", newEmp.Iban);
                cmd.Parameters.AddWithValue("@17", newEmp.HourlyWage);
                cmd.Parameters.AddWithValue("@18", newEmp.Position.ToString());
                if (cmd.ExecuteNonQuery() == 0)
                {
                    throw new Exception();
                }

                //newEmpId
                int newEmpId;
                cmd.CommandText = "SELECT MAX(id) FROM mb_employee";
                object receitIdObject = cmd.ExecuteScalar();
                if (receitIdObject != null)
                {
                    newEmpId = Convert.ToInt32(receitIdObject);
                }
                else
                {
                    throw new Exception();
                }
                cmd.CommandText = "INSERT INTO `mb_employee_contract`( `empid`, `contract`, `startdate`, `lastdate`) VALUES(@empid, @contract, @startdate, @lastdate);";
                cmd.Parameters.AddWithValue("@empid", newEmpId);
                cmd.Parameters.AddWithValue("@contract", newEmp.Contract + 1);
                cmd.Parameters.AddWithValue("@startdate", DateTime.Now.ToString("yyyy-MM-dd"));
                if (newEmp.Contract == ContractType.FULLTIME || newEmp.Contract == ContractType.LEFT)
                {
                    cmd.Parameters.AddWithValue("@lastdate", DateTime.Now.AddYears(10).ToString("yyyy-MM-dd"));
                }
                else
                {
                    DateTime test= DateTime.Now.AddYears(1);
                    cmd.Parameters.AddWithValue("@lastdate", test.ToString("yyyy-MM-dd"));
                }
                if (cmd.ExecuteNonQuery() == 0)
                {
                    throw new Exception();
                }
                tr.Commit();
                return true;
            }
            catch (Exception exe)
            {
                
                try
                {
                    tr.Rollback();
                }
                catch (MySqlException ex1)
                {
                    return false;
                }

                return false;
            }
            finally
            {
                DbConnection.Close();
            }
        }
        public bool ChangeWorkContract(ContractType contract, Employee employee)
        {
            string sqlStatement2 = "INSERT INTO `mb_employee_contract`( `empid`, `contract`, `startdate`, `lastdate`) VALUES (@empid,@contract,@startdate,@lastdate)";
            MySqlCommand sqlCommand2 = new MySqlCommand(sqlStatement2, DbConnection);
            sqlCommand2.Parameters.AddWithValue("@empid", employee.Id);
            sqlCommand2.Parameters.AddWithValue("@contract", contract + 1);
            sqlCommand2.Parameters.AddWithValue("@startdate", DateTime.Now.ToString("yyyy-MM-dd"));
            if (contract == ContractType.FULLTIME || contract == ContractType.LEFT)
            {
                DateTime test = DateTime.Now.AddYears(10);
                sqlCommand2.Parameters.AddWithValue("@lastdate", test.ToString("yyyy-MM-dd"));
            }
            else
            {
                DateTime test = DateTime.Now.AddYears(1);
                sqlCommand2.Parameters.AddWithValue("@lastdate", test.ToString("yyyy-MM-dd"));
            }

            string sqlStatement1 = "UPDATE `mb_employee_contract` SET " +
                                  "lastdate =if(now() between startdate and lastdate,now(),lastdate) " +
                                  "WHERE empid=@i";
            MySqlCommand sqlCommand1 = new MySqlCommand(sqlStatement1, DbConnection);
            sqlCommand1.Parameters.AddWithValue("@i", employee.Id);

            try
            {
                int n = 0;

                DbConnection.Open();
                n = sqlCommand1.ExecuteNonQuery();
                sqlCommand2.ExecuteNonQuery();

                if (n > 0)
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
        public bool DeleteEmployee(int id)
        {
            string sqlStatement = "DELETE FROM `mb_employee` WHERE id=@i";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection); ;
            sqlCommand.Parameters.AddWithValue("@i", id);
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
        public bool ChangePassword(string password, int id)
        {
            string sqlStatement = "UPDATE mb_employee SET pwd = @p	WHERE id = @i";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection);
            sqlCommand.Parameters.AddWithValue("@p", password);
            sqlCommand.Parameters.AddWithValue("@i", id);
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
        public bool CheckIfExists(string bsn)
        {
            string sqlStatement = "SELECT bsn FROM mb_employee WHERE bsn = @B;";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection); ;
            sqlCommand.Parameters.AddWithValue("@B", bsn);

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
        public bool EditPersonalInfo(Employee newEmpInfo)
        {
            string sqlStatement = "UPDATE mb_employee SET bsn = @bsn, fname=@fname, lname=@lname, gender=@gender,email=@email," +
                                  "birthdate=@bday, emergphonenumber=@phonenumber, iban=@iban, uname = @uname, firstworkingday=@fwd, hourlywage=@hourlywage, " +
                                  "position=@position,street = @street, streetnumber = @streetnumber, zipcode = @zipcode, town = @town , country = @country WHERE id = @i";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection);
            sqlCommand.Parameters.AddWithValue("@i", newEmpInfo.Id);
            sqlCommand.Parameters.AddWithValue("@bsn", newEmpInfo.BSN);
            sqlCommand.Parameters.AddWithValue("@fname", newEmpInfo.FirstName);
            sqlCommand.Parameters.AddWithValue("@lname", newEmpInfo.LastName);
            sqlCommand.Parameters.AddWithValue("@gender", newEmpInfo.Gender + 1);
            sqlCommand.Parameters.AddWithValue("@email", newEmpInfo.Email);
            sqlCommand.Parameters.AddWithValue("@bday", newEmpInfo.Birthday);
            sqlCommand.Parameters.AddWithValue("@phonenumber", newEmpInfo.PhoneNumber);
            sqlCommand.Parameters.AddWithValue("@iban", newEmpInfo.Iban);
            sqlCommand.Parameters.AddWithValue("@uname", newEmpInfo.Username);
            sqlCommand.Parameters.AddWithValue("@fwd", newEmpInfo.FirstWorkingDay);
            sqlCommand.Parameters.AddWithValue("@hourlywage", newEmpInfo.HourlyWage);
            sqlCommand.Parameters.AddWithValue("@position", newEmpInfo.Position + 1);
            sqlCommand.Parameters.AddWithValue("@street", newEmpInfo.Street);
            sqlCommand.Parameters.AddWithValue("@streetnumber", newEmpInfo.StreetNumber);
            sqlCommand.Parameters.AddWithValue("@zipcode", newEmpInfo.Zipcode);
            sqlCommand.Parameters.AddWithValue("@town", newEmpInfo.Town);
            sqlCommand.Parameters.AddWithValue("@country", newEmpInfo.Country);
            try
            {
                int n = 0;

                DbConnection.Open();
                n = sqlCommand.ExecuteNonQuery();

                if (n > 0)
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

        
    }
}
