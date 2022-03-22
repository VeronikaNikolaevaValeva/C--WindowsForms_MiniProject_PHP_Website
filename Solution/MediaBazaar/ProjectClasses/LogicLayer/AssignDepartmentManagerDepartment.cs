using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClasses
{
    public class AssignDepartmentManagerDepartment : AssignPersonDepartment
    {
        public AssignDepartmentManagerDepartment(Department department, Employee departmentManager)
            : base(department, departmentManager)
        {

        }
    }
}
