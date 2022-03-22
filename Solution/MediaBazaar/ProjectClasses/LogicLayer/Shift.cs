using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClasses
{
    public class Shift
    {
        private ShiftType type;
        private DateTime date;
        private int assignableEmployees;
        private List<Employee> assignedEmployees;
        public ShiftType Type
        {
            get { return this.type; }

        }
        public DateTime Date
        {
            get { return this.date; }
        }
        public int AssignableEmployees
        {
            get { return this.assignableEmployees; }
            set
            {
                if (value < 0 ||( this.AssignableEmployees > value && this.GetAssignedEmployees().Count > value))
                {
                    throw new ArgumentException("Please enter a valid number!");
                }
                else
                {
                    this.assignableEmployees = value;
                }
            }
        }
        public Shift(ShiftType shiftType, DateTime date, List<Employee> assignedEmployees)
        {
            this.type = shiftType;
            this.date = date;
            this.assignedEmployees = assignedEmployees;
            if ((shiftType == ShiftType.Morning || shiftType == ShiftType.Night) && (date.DayOfWeek != DayOfWeek.Friday && date.DayOfWeek != DayOfWeek.Saturday && date.DayOfWeek != DayOfWeek.Sunday))
            {
                this.assignableEmployees = 5;
            }
            else
            {
                this.assignableEmployees = 10;
            }

        }

        public List<Employee> GetAssignedEmployees()
        {
            return this.assignedEmployees;
        }

        public List<int> GetAssignedEmployeesIds()
        {
            List<int> ids = new List<int>();
            foreach (Employee employee in this.assignedEmployees)
            {
                ids.Add(employee.Id);
            }
            if (ids.Count == 0)
            {
                ids.Add(-1);
            }
            return ids;
        }
        public void AssignEmployee(Employee employee)
        {
            this.assignedEmployees.Add(employee);
        }
        public bool RemoveEmployee(int employeeId)
        {
            foreach (Employee employee in assignedEmployees)
            {
                if (employee.Id == employeeId)
                {
                    assignedEmployees.Remove(employee);
                    return true;
                }
            }

            return false;

        }
    }
}

