using FactoryDesign.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesign.Factory
{
    public class EmployeeManagerFactory
    {
        public IEmployeeManager GetEmployeeManager(int empTypeId)
        {
            IEmployeeManager returnValue = null;
            if (empTypeId == 1)
            {
                returnValue = new PermanentEmployeeManager();
            }
            else if (empTypeId == 2)
            {
                returnValue = new ContractEmployeeManager();
            }
            return returnValue;
        }
    }
}
