using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Singletone obj = Singletone.GetInstance;
            obj.PrintDetails("Test");

            Singletone obj1 = Singletone.GetInstance;
            obj1.PrintDetails("Test1");
            Console.ReadLine();
        }
    }
}
