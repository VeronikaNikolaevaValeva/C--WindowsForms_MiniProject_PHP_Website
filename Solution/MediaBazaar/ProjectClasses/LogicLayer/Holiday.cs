using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClasses.LogicLayer
{
    public class Holiday
    {
        private int id;
        private string employeeBsn;
        private DateTime startDate;
        private DateTime endDate;
        private DateTime requestedDate;
        public int Id
        {
            get { return this.id; }
        }
        public string EmployeeBsn
        {
            get { return this.employeeBsn; }
            set { if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException();
                }
                else
                {
                    this.employeeBsn = value;
                }
            }
        }
        public DateTime StartDate
        {
            get { return this.startDate; }
        }
        public DateTime EndDate
        {
            get { return this.endDate; }
        }
        public DateTime RequestedDate
        {
            get { return this.requestedDate; }
        }
        public Holiday(int id, string bsn,DateTime startDate,DateTime endDate,DateTime requestedDate)
        {
            this.id = id;
            this.EmployeeBsn = bsn;
            this.startDate = startDate;
            this.endDate = endDate;
            this.requestedDate = requestedDate;
        }
        public override string ToString()
        {
            return $"{id}. Employee BSN: {employeeBsn}, Start Date: {startDate.ToShortDateString()}, End Date: {endDate.ToShortDateString()}";
        }
    }
}

