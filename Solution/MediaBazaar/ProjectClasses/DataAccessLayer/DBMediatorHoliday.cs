using MySql.Data.MySqlClient;
using ProjectClasses.LogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClasses.DataAccessLayer
{
    class DBMediatorHoliday : DBMediator
    {
        public DBMediatorHoliday(DatabaseType databaseType) : base(databaseType) { }
        public List<Holiday> GetRequestedHolidays()
        {
            string sqlStatement = "SELECT e.bsn,hr.id, hr.start_date,hr.end_date,hr.requested_date FROM mb_holiday_request as hr inner join mb_employee as e on hr.employeeID=e.id;";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, this.DbConnection);
            List<Holiday> requestedHolidays = new List<Holiday>();
            try
            {
                MySqlDataReader shiftReader;
                DbConnection.Open();
                shiftReader = sqlCommand.ExecuteReader();
                while (shiftReader.Read())
                {
                        Holiday foundHoliday = new Holiday
                            (
                               Convert.ToInt32(shiftReader["id"]),
                               shiftReader["bsn"].ToString(),
                               DateTime.Parse(shiftReader["start_date"].ToString()),
                               DateTime.Parse(shiftReader["end_date"].ToString()),
                               DateTime.Parse(shiftReader["requested_date"].ToString())
                            );
                        requestedHolidays.Add(foundHoliday);
                    
                }
            }
            finally
            {
                this.DbConnection.Close();

            }
            return requestedHolidays;
        }
        public List<Holiday> GetHolidays()
        {
            string sqlStatement = "SELECT e.bsn,hr.id, hr.start_date,hr.end_date FROM mb_holidays as hr inner join mb_employee as e on hr.employeeID=e.id;";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, this.DbConnection);
            List<Holiday> holidays = new List<Holiday>();
            try
            {
                MySqlDataReader shiftReader;
                DbConnection.Open();
                shiftReader = sqlCommand.ExecuteReader();
                while (shiftReader.Read())
                {
                    Holiday foundHoliday = new Holiday
                        (
                           Convert.ToInt32(shiftReader["id"]),
                           shiftReader["bsn"].ToString(),
                           DateTime.Parse(shiftReader["start_date"].ToString()),
                           DateTime.Parse(shiftReader["end_date"].ToString()),
                           DateTime.Now
                        );
                    holidays.Add(foundHoliday);

                }
            }
            finally
            {
                this.DbConnection.Close();

            }
            return holidays;
        }
        public bool RemoveRequestedHoliday(int id)
        {
            string sqlStatement = "DELETE FROM `mb_holiday_request` WHERE id=@id";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection);
            sqlCommand.Parameters.AddWithValue("@id", id);
            try
            {
                DbConnection.Open();
                int n = sqlCommand.ExecuteNonQuery();
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
        public bool DeleteHoliday(int id)
        {
            string sqlStatement = "DELETE FROM `mb_holidays` WHERE id=@id";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection);
            sqlCommand.Parameters.AddWithValue("@id", id);
            try
            {
                DbConnection.Open();
                int n = sqlCommand.ExecuteNonQuery();
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
        public bool RegisterNewHoliday(string employeeBSN,DateTime startDate,DateTime endDate)
        {
            string sqlStatement = "INSERT INTO `mb_holidays`(`id`, `employeeID`, `start_date`, `end_date`) " +
                "select 0,e.id,@startDate, @endDate from mb_employee e where bsn = @employeeBSN;" +
                "DELETE FROM mb_holiday_request WHERE employeeID in (SELECT id from mb_employee where bsn = @employeeBSN ) and start_date = @startDate and end_date = @endDate;" +
                "select last_insert_id() ";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection);
            sqlCommand.Parameters.AddWithValue("@employeeBSN", employeeBSN);
            sqlCommand.Parameters.AddWithValue("@startDate", startDate);
            sqlCommand.Parameters.AddWithValue("@endDate", endDate);
            try
            {
                DbConnection.Open();
                int n = Convert.ToInt32(sqlCommand.ExecuteScalar());
                if (n<0)
                {
                    return false;
                }
                return true;
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
        public Holiday GetRequestedHoliday(int id)
        {
            string sqlStatement = "SELECT e.bsn,hr.id, hr.start_date,hr.end_date,hr.requested_date FROM mb_holiday_request as hr inner join mb_employee as e on hr.employeeID=e.id where hr.id=@id;";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, this.DbConnection);
            sqlCommand.Parameters.AddWithValue("@id", id);
            Holiday foundHoliday=null;
            try
            {
                MySqlDataReader shiftReader;
                DbConnection.Open();
                shiftReader = sqlCommand.ExecuteReader();
                while (shiftReader.Read())
                {
                     foundHoliday = new Holiday
                        (
                           Convert.ToInt32(shiftReader["id"]),
                           shiftReader["bsn"].ToString(),
                           DateTime.Parse(shiftReader["start_date"].ToString()),
                           DateTime.Parse(shiftReader["end_date"].ToString()),
                           DateTime.Parse(shiftReader["requested_date"].ToString())
                        );
                }
            }
            finally
            {
                this.DbConnection.Close();

            }
            return foundHoliday;
        }

    }
}
