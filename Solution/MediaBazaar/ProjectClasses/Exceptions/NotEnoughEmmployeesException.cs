using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClasses.Exceptions
{
    public class NotEnoughEmmployeesException : Exception
    {
        public NotEnoughEmmployeesException() : base("There aren't enough employees in the department to create the schedule following the business rules!") { }
    }
}
