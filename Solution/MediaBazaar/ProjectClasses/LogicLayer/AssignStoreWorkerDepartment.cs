using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClasses
{
    public class AssignStoreWorkerDepartment : AssignPersonDepartment
    {
        public AssignStoreWorkerDepartment(Department department, Employee storeWorker)
            : base(department, storeWorker)
        {

        }
    }
}
