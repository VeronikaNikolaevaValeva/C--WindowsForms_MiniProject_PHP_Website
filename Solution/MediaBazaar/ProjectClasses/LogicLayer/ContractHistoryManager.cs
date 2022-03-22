using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClasses
{
    public class ContractHistoryManager
    {
        DBMediatorContractHistory databaseMediator;
        List<ContractHistory> contractHistories;
        public ContractHistoryManager(int id, DatabaseType databaseType)
        {
            databaseMediator = new DBMediatorContractHistory(databaseType);
            contractHistories = databaseMediator.GetContractHystory(id);
        }

        public List<ContractHistory> ContractHistories
        {
            get { return contractHistories; }
        }
        //public ContractType GetContractTypeForADay(DateTime date)
        //{
        //    foreach (ContractHistory contract in contractHistories)
        //    {
        //        if (contract.DateIfBetween(date))
        //        {
        //            return contract.Contract;
        //        }
        //    }
        //    return null;
        //}
    }
}
