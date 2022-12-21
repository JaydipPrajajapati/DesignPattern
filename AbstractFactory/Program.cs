using FactoryMethod.Factory.FactoryMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.empTypeId = 2;
            BaseEmployeeFactory employeeManagerFactory = new EmployeeManagerFactory().CreateFactory(employee);
            employeeManagerFactory.ApplySalary();
        }
    }
}
