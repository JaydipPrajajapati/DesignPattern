using FactoryMethod.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Factory.FactoryMethod
{
    public abstract class BaseEmployeeFactory
    {
        protected Employee _emp;
        public BaseEmployeeFactory(Employee emp)
        {
            _emp = emp;
        }
        public abstract IEmployeeManager Create();

        public Employee ApplySalary()
        {
            IEmployeeManager employeeManager = Create();
            _emp.bonus = employeeManager.GetBonus();
            _emp.hourlyPay = employeeManager.GetPay();
            return _emp;
        }
    }
}
