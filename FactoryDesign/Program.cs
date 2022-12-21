using FactoryDesign.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeManagerFactory empFactory = new EmployeeManagerFactory();
            var emp = empFactory.GetEmployeeManager(1);
            var bonus = emp.GetBonus();
            var pay = emp.GetPay();
        }
    }
}
