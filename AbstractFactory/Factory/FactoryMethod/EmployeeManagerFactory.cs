using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Factory.FactoryMethod
{
    public class EmployeeManagerFactory
    {
        public BaseEmployeeFactory CreateFactory(Employee employee)
        {
            BaseEmployeeFactory returnValue = null;
            if (employee.empTypeId == 1)
            {
                returnValue = new PermanentEmployeeFactory(employee);
            }
            else if (employee.empTypeId == 2)
            {
                returnValue = new ContactEmployeeFactory(employee);
            }
            return returnValue;
        }
    }
}
