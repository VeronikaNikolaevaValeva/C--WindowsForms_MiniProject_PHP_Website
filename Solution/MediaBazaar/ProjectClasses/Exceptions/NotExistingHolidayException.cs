using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClasses.LogicLayer
{
    public class NotExistingHolidayException : Exception
    {
        public NotExistingHolidayException(string message) : base(message)
        {

        }
    }
}
