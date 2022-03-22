using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClasses
{
    public class AssignPersonDepartment
    {
        private Department department;
        private Employee person;

        public Department Department
        {
            get { return this.department; }
        }

        public Employee Person
        {
            get { return this.person; }
        }

        protected AssignPersonDepartment(Department department, Employee person)
        {
            this.department = department;
            this.person = person;
        }


    }
}
