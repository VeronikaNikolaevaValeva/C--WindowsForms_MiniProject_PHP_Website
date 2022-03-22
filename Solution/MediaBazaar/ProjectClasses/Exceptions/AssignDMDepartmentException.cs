using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClasses
{
    public class AssignDMDepartmentException: Exception
    {
        public AssignDMDepartmentException(string emp, string dept)
            :base($"{emp} is already assign to {dept}.")
        {

        }
    }
}
