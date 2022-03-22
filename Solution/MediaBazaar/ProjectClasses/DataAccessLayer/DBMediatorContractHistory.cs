using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClasses
{
    class DBMediatorContractHistory : DBMediator
    {
        public DBMediatorContractHistory(DatabaseType databaseType) : base(databaseType) { }

        public List<ContractHistory> GetContractHystory(int id)
        {
            string sqlStatement = "SELECT empid,contract,startdate,lastdate FROM `mb_employee_contract` " +
                                    "INNER JOIN mb_employee " +
                                    "ON empid = mb_employee.id " +
                                    "where empid = @id;";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection);
            sqlCommand.Parameters.AddWithValue("@id", id);

            List<ContractHistory> contracts = new List<ContractHistory>();
            try
            {
                MySqlDataReader EmployeeReader;
                DbConnection.Open();

                EmployeeReader = sqlCommand.ExecuteReader();
                while (EmployeeReader.Read())
                {
                    Enum.TryParse(EmployeeReader["contract"].ToString(), out ContractType contracttype);
                    contracts.Add(new ContractHistory(Convert.ToInt32(EmployeeReader["empid"]),
                                                       contracttype,
                                                       Convert.ToDateTime(EmployeeReader["startdate"].ToString()),
                                                       Convert.ToDateTime(EmployeeReader["lastdate"].ToString())));
                }
                return contracts;
            }
            catch (MySqlException e)
            {
                return contracts;
            }
            finally
            {
                DbConnection.Close();
            }
        }
    }
}
