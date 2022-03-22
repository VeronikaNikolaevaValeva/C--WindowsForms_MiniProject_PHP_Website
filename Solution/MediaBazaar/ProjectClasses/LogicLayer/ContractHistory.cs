using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClasses
{
    public class ContractHistory
    {
        int empid;
        ContractType contract;
        DateTime startdate;
        DateTime lastdate;

        public ContractType Contract
        {
            get { return contract; }
        }

        //Constructor
        public ContractHistory(int empid, ContractType contract, DateTime startdate, DateTime lastdate)
        {
            this.empid = empid;
            this.contract = contract;
            this.startdate = startdate;
            this.lastdate = lastdate;
        }
        public override string ToString()
        {
            if (contract==ContractType.FLEX|| contract == ContractType.LEFT)
            {
                return $"{contract} \t\tFrom: {startdate.ToString("yyyy-MM-dd")}     To: {lastdate.ToString("yyyy-MM-dd")}";
            }
            else
            {
                return $"{contract} \tFrom: {startdate.ToString("yyyy-MM-dd")}     To: {lastdate.ToString("yyyy-MM-dd")}";
            }

            
        }
        public bool DateIfBetween(DateTime date)
        {
            if (startdate < date && date > lastdate)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
