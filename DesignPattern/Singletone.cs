using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class Singletone
    {
        private static int counter = 0;
        private static Singletone instance = null;
        public static Singletone GetInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singletone();
                }
                return instance;
            }
        }

        private Singletone()
        {
            counter++;
            Console.WriteLine("Counter Value :" + counter.ToString());
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
