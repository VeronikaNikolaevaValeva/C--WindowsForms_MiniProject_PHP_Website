using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClasses.LogicLayer
{
    public class EmployeeInSchedule
    {
        private Employee employee;
        private List<Shift> availableShifts;
        public EmployeeInSchedule(Employee employee)
        {
            this.employee = employee;
            availableShifts = new List<Shift>();
        }
        public Employee Employee
        {
            get { return this.employee; }
        }
        public List<Shift> AvailableShifts
        {
            get { return this.availableShifts; }
        }
        public void AddAvailability(Shift shift)
        {
            if (!availableShifts.Contains(shift))
            {
                availableShifts.Add(shift);
            }
        }
        public bool CheckAvailableShift(Shift shift)
        {
            foreach (Shift shift1 in availableShifts)
            {
                if (shift.Type == shift1.Type && shift.Date == shift1.Date)
                {
                    return true;
                }
            }
            return false;
        }
        public string ToString()
        {
            string result= $"ID: {employee.Id}";
            foreach (Shift availableShift in availableShifts)
            {
                result += $" - ({availableShift.Type}, {availableShift.Date.ToString("yyyy-MM-dd")})";
            }
            return result;
        }
    }
}
