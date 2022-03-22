using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaar.UserControls
{
    public class ExistingHolidayException : Exception
    {
        public ExistingHolidayException() : base("This holiday already exists!")
        {

        }
    }
}
