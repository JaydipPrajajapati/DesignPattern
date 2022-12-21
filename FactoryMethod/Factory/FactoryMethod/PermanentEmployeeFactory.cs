using FactoryMethod.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Factory.FactoryMethod
{
    public class PermanentEmployeeFactory : BaseEmployeeFactory
    {
        public PermanentEmployeeFactory(Employee emp) : base(emp)
        {

        }

        public override IEmployeeManager Create()
        {
            PermanentEmployeeManager employeeManager = new PermanentEmployeeManager();
            _emp.houseAllowance = employeeManager.GetHouseAllowance();
            return employeeManager;
        }
    }
}
