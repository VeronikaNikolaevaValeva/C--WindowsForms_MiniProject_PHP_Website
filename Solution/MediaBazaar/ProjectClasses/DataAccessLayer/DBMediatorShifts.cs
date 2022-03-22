using MySql.Data.MySqlClient;
using ProjectClasses.LogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClasses
{
    public class DBMediatorShifts : DBMediator
    {
        public DBMediatorShifts(DatabaseType databaseType) : base(databaseType) { }

        //Automatic Schedule
        public virtual List<EmployeeInSchedule> GetStockWorkersAvailabilityPerWeekNumber(int week)
        {
            // gets employee info and available shifts per employee
            string sqlStatement = $"SELECT e.*,ec.contract as 'contracttype',ec.startdate as 'contractstartdate',ea.shiftType,ea.date FROM mb_employee_availability as ea inner join mb_employee e on ea.employeeID=e.id inner join mb_employee_contract ec on e.id=ec.empid where ec.startdate<now() and ec.lastdate>now() and week(ea.date,1)=@week and e.id not in (select mb_holidays.employeeID from mb_holidays where ea.date between mb_holidays.start_date and mb_holidays.end_date) and e.position='STOCK_WORKER'";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection);
            sqlCommand.Parameters.AddWithValue("@week", week);

            Dictionary<int, EmployeeInSchedule> employeesInSchedule = new Dictionary<int, EmployeeInSchedule>();
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
                    Enum.TryParse(EmployeeReader["shiftType"].ToString(), out ShiftType shiftType);
                    Employee emp = new Employee(Convert.ToInt32(EmployeeReader["id"]), EmployeeReader["bsn"].ToString(),
                    EmployeeReader["fname"].ToString(), EmployeeReader["lname"].ToString(), gender,
                    EmployeeReader["email"].ToString(), EmployeeReader["uname"].ToString(),
                    Convert.ToDateTime(EmployeeReader["birthdate"].ToString()), EmployeeReader["street"].ToString(),
                    EmployeeReader["streetnumber"].ToString(), EmployeeReader["zipcode"].ToString(), EmployeeReader["town"].ToString(),
                    EmployeeReader["country"].ToString(), Convert.ToDateTime(EmployeeReader["firstworkingday"].ToString()),
                    EmployeeReader["emergphonenumber"].ToString(), EmployeeReader["iban"].ToString(),
                    Convert.ToDouble(EmployeeReader["hourlywage"]),
                    Convert.ToDateTime(EmployeeReader["contractstartdate"].ToString()), contracttype, position);
                    Shift availableShift = new Shift(shiftType, Convert.ToDateTime(EmployeeReader["date"]), new List<Employee>());

                    AddEmployeeInSchedule(employeesInSchedule, emp, availableShift);
                }
                return employeesInSchedule.Values.ToList();
            }
            catch (MySqlException)
            {
                return null;
            }
            finally
            {
                DbConnection.Close();
            }
        }
        public virtual List<EmployeeInSchedule> GetEmployeesAvailabilityPerDepartmentAndWeekNumber(Department department, int week)
        {
            // gets employee info and available shifts per employee
            string sqlStatement = $"SELECT e.*,ec.contract as 'contracttype',ec.startdate as 'contractstartdate',ea.shiftType,ea.date FROM mb_employee_availability as ea inner join mb_employee e on ea.employeeID=e.id inner join mb_employee_contract ec on e.id=ec.empid inner join mb_department_storeworker as ds on e.id=ds.storeworker_id where ec.startdate<now() and ec.lastdate>now() and week(ea.date,1)=@week and ds.dept_code=@department and e.id not in (select mb_holidays.employeeID from mb_holidays where ea.date between mb_holidays.start_date and mb_holidays.end_date)";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection);
            sqlCommand.Parameters.AddWithValue("@week", week);
            sqlCommand.Parameters.AddWithValue("@department", department.Code);

            Dictionary<int, EmployeeInSchedule> employeesInSchedule = new Dictionary<int, EmployeeInSchedule>();
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
                    Enum.TryParse(EmployeeReader["shiftType"].ToString(), out ShiftType shiftType);
                    Employee emp = new Employee(Convert.ToInt32(EmployeeReader["id"]), EmployeeReader["bsn"].ToString(),
                    EmployeeReader["fname"].ToString(), EmployeeReader["lname"].ToString(), gender,
                    EmployeeReader["email"].ToString(), EmployeeReader["uname"].ToString(),
                    Convert.ToDateTime(EmployeeReader["birthdate"].ToString()), EmployeeReader["street"].ToString(),
                    EmployeeReader["streetnumber"].ToString(), EmployeeReader["zipcode"].ToString(), EmployeeReader["town"].ToString(),
                    EmployeeReader["country"].ToString(), Convert.ToDateTime(EmployeeReader["firstworkingday"].ToString()),
                    EmployeeReader["emergphonenumber"].ToString(), EmployeeReader["iban"].ToString(),
                    Convert.ToDouble(EmployeeReader["hourlywage"]),
                    Convert.ToDateTime(EmployeeReader["contractstartdate"].ToString()), contracttype, position);
                    Shift availableShift = new Shift(shiftType, Convert.ToDateTime(EmployeeReader["date"]), new List<Employee>());

                    AddEmployeeInSchedule(employeesInSchedule, emp, availableShift);
                }
                return employeesInSchedule.Values.ToList();
            }
            catch (MySqlException)
            {
                return null;
            }
            finally
            {
                DbConnection.Close();
            }
        }
        public List<EmployeeInSchedule> GetAllFlexContractEmployees(int week,Department department)
        {
            // gets employee info and available shifts per employee
            string sqlStatement = $"SELECT e.*,ec.contract as 'contracttype',ec.startdate as 'contractstartdate',ea.shiftType,ea.date FROM mb_employee_availability as ea inner join mb_employee e on ea.employeeID=e.id inner join mb_employee_contract ec on e.id=ec.empid where ec.startdate<now() and ec.lastdate>now() and week(ea.date,1)=@week and e.id not in (select mb_holidays.employeeID from mb_holidays where ea.date between mb_holidays.start_date and mb_holidays.end_date) and e.id not in(SELECT mb_department_storeworker.storeworker_id from mb_department_storeworker where mb_department_storeworker.dept_code=@department) and ec.contract='FLEX' and e.position='STORE_WORKER'";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection);
            sqlCommand.Parameters.AddWithValue("@week", week);
            sqlCommand.Parameters.AddWithValue("@department", department.Code);
            Dictionary<int, EmployeeInSchedule> employeesInSchedule = new Dictionary<int, EmployeeInSchedule>();
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
                    Enum.TryParse(EmployeeReader["shiftType"].ToString(), out ShiftType shiftType);
                    Employee emp = new Employee(Convert.ToInt32(EmployeeReader["id"]), EmployeeReader["bsn"].ToString(),
                    EmployeeReader["fname"].ToString(), EmployeeReader["lname"].ToString(), gender,
                    EmployeeReader["email"].ToString(), EmployeeReader["uname"].ToString(),
                    Convert.ToDateTime(EmployeeReader["birthdate"].ToString()), EmployeeReader["street"].ToString(),
                    EmployeeReader["streetnumber"].ToString(), EmployeeReader["zipcode"].ToString(), EmployeeReader["town"].ToString(),
                    EmployeeReader["country"].ToString(), Convert.ToDateTime(EmployeeReader["firstworkingday"].ToString()),
                    EmployeeReader["emergphonenumber"].ToString(), EmployeeReader["iban"].ToString(),
                    Convert.ToDouble(EmployeeReader["hourlywage"]),
                    Convert.ToDateTime(EmployeeReader["contractstartdate"].ToString()), contracttype, position);
                    Shift availableShift = new Shift(shiftType, Convert.ToDateTime(EmployeeReader["date"]), new List<Employee>());

                    AddEmployeeInSchedule(employeesInSchedule, emp, availableShift);
                }
                return employeesInSchedule.Values.ToList();
            }
            catch (MySqlException)
            {
                return null;
            }
            finally
            {
                DbConnection.Close();
            }
        }
        public List<EmployeeInSchedule> GetAllFlexContractStockWorkers(int week,List<int> employeeIds)
        {
            // gets employee info and available shifts per employee
            string sqlStatement = $"SELECT e.*,ec.contract as 'contracttype',ec.startdate as 'contractstartdate',ea.shiftType,ea.date FROM mb_employee_availability as ea inner join mb_employee e on ea.employeeID=e.id inner join mb_employee_contract ec on e.id=ec.empid where ec.startdate<now() and ec.lastdate>now() and week(ea.date,1)=@week and e.id not in (select mb_holidays.employeeID from mb_holidays where ea.date between mb_holidays.start_date and mb_holidays.end_date) and e.position='STOCK_WORKER' and e.id not in (" + string.Join(",", employeeIds) + ")";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection);
            sqlCommand.Parameters.AddWithValue("@week", week);
            Dictionary<int, EmployeeInSchedule> employeesInSchedule = new Dictionary<int, EmployeeInSchedule>();
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
                    Enum.TryParse(EmployeeReader["shiftType"].ToString(), out ShiftType shiftType);
                    Employee emp = new Employee(Convert.ToInt32(EmployeeReader["id"]), EmployeeReader["bsn"].ToString(),
                    EmployeeReader["fname"].ToString(), EmployeeReader["lname"].ToString(), gender,
                    EmployeeReader["email"].ToString(), EmployeeReader["uname"].ToString(),
                    Convert.ToDateTime(EmployeeReader["birthdate"].ToString()), EmployeeReader["street"].ToString(),
                    EmployeeReader["streetnumber"].ToString(), EmployeeReader["zipcode"].ToString(), EmployeeReader["town"].ToString(),
                    EmployeeReader["country"].ToString(), Convert.ToDateTime(EmployeeReader["firstworkingday"].ToString()),
                    EmployeeReader["emergphonenumber"].ToString(), EmployeeReader["iban"].ToString(),
                    Convert.ToDouble(EmployeeReader["hourlywage"]),
                    Convert.ToDateTime(EmployeeReader["contractstartdate"].ToString()), contracttype, position);
                    Shift availableShift = new Shift(shiftType, Convert.ToDateTime(EmployeeReader["date"]), new List<Employee>());

                    AddEmployeeInSchedule(employeesInSchedule, emp, availableShift);
                }
                return employeesInSchedule.Values.ToList();
            }
            catch (MySqlException)
            {
                return null;
            }
            finally
            {
                DbConnection.Close();
            }
        }

        private void AddEmployeeInSchedule(Dictionary<int, EmployeeInSchedule> employeesInSchedule, Employee employee, Shift shift)
        {
            if (!employeesInSchedule.ContainsKey(employee.Id))
            {
                employeesInSchedule.Add(employee.Id, new EmployeeInSchedule(employee));
            }

            employeesInSchedule[employee.Id].AddAvailability(shift);
        }
        private string GenearteQuery(WeekSchedule schedule)
        {
            string result = $"DELETE FROM `mb_shift_with_assigned_employee` WHERE week(date,1)={schedule.WeekNumber};";
            foreach (Shift shift in schedule.GetAllShifts())
            {
                foreach (Employee employee in shift.GetAssignedEmployees())
                {
                    result += $" INSERT INTO `mb_shift`(`shiftType`, `date`, `assignableEmployees`) VALUES('{shift.Type}', '{shift.Date.ToString("yyyy-MM-dd")}', {shift.AssignableEmployees}) ON DUPLICATE KEY UPDATE assignableEmployees = {shift.AssignableEmployees};" +
                        $"INSERT INTO `mb_shift_with_assigned_employee`(`shiftType`, `date`, `employeeID`) VALUES('{shift.Type}','{shift.Date.ToString("yyyy-MM-dd")}', {employee.Id});";
                }
            }
            return result;
        }
        public bool SaveSchedule(WeekSchedule schedule)
        { 
            string sqlStatement = GenearteQuery(schedule);
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, this.DbConnection);
            try
            {
                DbConnection.Open();
                int n = sqlCommand.ExecuteNonQuery();

                if (n >0 )
                {
                    return true;
                }
                return false;
            }
            catch (MySqlException e)
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
        public WeekSchedule FillSchedule(WeekSchedule schedule)
        {

            string sqlStatement = $"SELECT s.assignableEmployees,se.shiftType,se.date,e.*,ec.contract as 'contracttype',ec.startdate as 'contractstartdate' from mb_employee e inner join mb_employee_contract ec on e.id=ec.empid inner join mb_shift_with_assigned_employee se on e.id=se.employeeID inner join mb_shift s on s.date=se.date and s.shiftType=se.shiftType where ec.startdate<now() and ec.lastdate>now() and week(se.date,1)=@week and e.id in (SELECT storeworker_id from mb_department_storeworker d where d.dept_code=@department)";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection);
            sqlCommand.Parameters.AddWithValue("@week", schedule.WeekNumber);
            sqlCommand.Parameters.AddWithValue("@department", schedule.Department.Code);
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
                    Enum.TryParse(EmployeeReader["shiftType"].ToString(), out ShiftType shiftType);
                    Employee emp = new Employee(Convert.ToInt32(EmployeeReader["id"]), EmployeeReader["bsn"].ToString(),
                    EmployeeReader["fname"].ToString(), EmployeeReader["lname"].ToString(), gender,
                    EmployeeReader["email"].ToString(), EmployeeReader["uname"].ToString(),
                    Convert.ToDateTime(EmployeeReader["birthdate"].ToString()), EmployeeReader["street"].ToString(),
                    EmployeeReader["streetnumber"].ToString(), EmployeeReader["zipcode"].ToString(), EmployeeReader["town"].ToString(),
                    EmployeeReader["country"].ToString(), Convert.ToDateTime(EmployeeReader["firstworkingday"].ToString()),
                    EmployeeReader["emergphonenumber"].ToString(), EmployeeReader["iban"].ToString(),
                    Convert.ToDouble(EmployeeReader["hourlywage"]),
                    Convert.ToDateTime(EmployeeReader["contractstartdate"].ToString()), contracttype, position);
                    foreach (Shift shift in schedule.GetAllShifts())
                    {
                        if(shift.Date.Equals(Convert.ToDateTime(EmployeeReader["date"].ToString())) && shift.Type == shiftType)
                        {
                            shift.AssignableEmployees = Convert.ToInt32(EmployeeReader["assignableEmployees"]);
                            if (!shift.GetAssignedEmployeesIds().Contains(emp.Id))
                            {
                                shift.AssignEmployee(emp);
                            }
                        }
                    }
                }
                return schedule;
            }
            catch (MySqlException ex)
            {
                return null;
            }
            finally
            {
                DbConnection.Close();
            }
        }
        public WeekSchedule FillScheduleStockWorkers(WeekSchedule schedule)
        {

            string sqlStatement = $"SELECT s.assignableEmployees,se.shiftType,se.date,e.*,ec.contract as 'contracttype',ec.startdate as 'contractstartdate' from mb_employee e inner join mb_employee_contract ec on e.id=ec.empid inner join mb_shift_with_assigned_employee se on e.id=se.employeeID inner join mb_shift s on s.date=se.date and s.shiftType=se.shiftType where ec.startdate<now() and ec.lastdate>now() and week(se.date,1)=@week and e.position='STOCK_WORKER'";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection);
            sqlCommand.Parameters.AddWithValue("@week", schedule.WeekNumber);
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
                    Enum.TryParse(EmployeeReader["shiftType"].ToString(), out ShiftType shiftType);
                    Employee emp = new Employee(Convert.ToInt32(EmployeeReader["id"]), EmployeeReader["bsn"].ToString(),
                    EmployeeReader["fname"].ToString(), EmployeeReader["lname"].ToString(), gender,
                    EmployeeReader["email"].ToString(), EmployeeReader["uname"].ToString(),
                    Convert.ToDateTime(EmployeeReader["birthdate"].ToString()), EmployeeReader["street"].ToString(),
                    EmployeeReader["streetnumber"].ToString(), EmployeeReader["zipcode"].ToString(), EmployeeReader["town"].ToString(),
                    EmployeeReader["country"].ToString(), Convert.ToDateTime(EmployeeReader["firstworkingday"].ToString()),
                    EmployeeReader["emergphonenumber"].ToString(), EmployeeReader["iban"].ToString(),
                    Convert.ToDouble(EmployeeReader["hourlywage"]),
                    Convert.ToDateTime(EmployeeReader["contractstartdate"].ToString()), contracttype, position);
                    foreach (Shift shift in schedule.GetAllShifts())
                    {
                        if (shift.Date.Equals(Convert.ToDateTime(EmployeeReader["date"].ToString())) && shift.Type == shiftType)
                        {
                            shift.AssignableEmployees = Convert.ToInt32(EmployeeReader["assignableEmployees"]);
                            if (!shift.GetAssignedEmployeesIds().Contains(emp.Id))
                            {
                                shift.AssignEmployee(emp);
                            }
                        }
                    }
                }
                return schedule;
            }
            catch (MySqlException ex)
            {
                return null;
            }
            finally
            {
                DbConnection.Close();
            }
        }
    }
}
