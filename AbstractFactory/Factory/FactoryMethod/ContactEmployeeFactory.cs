using FactoryMethod.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Factory.FactoryMethod
{
    public class ContactEmployeeFactory : BaseEmployeeFactory
    {
        public ContactEmployeeFactory(Employee emp) : base(emp)
        {

        }

        public override IEmployeeManager Create()
        {
            ContractEmployeeManager employeeManager = new ContractEmployeeManager();
            _emp.medicalAllowance = employeeManager.GetMedicalAllowance();
            return employeeManager;
        }
    }
}
