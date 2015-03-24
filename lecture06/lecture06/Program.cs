using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace lecture06
{
    class Program
    {
        private static object lockTool = new object();
        static void Main(string[] args)
        {
            Thread t1 = new Thread(workWithLock);
            Thread t2 = new Thread(workWithLock);

            Console.WriteLine("Before: " + Calcul.readValue());

            t1.Start();
            t2.Start();

            t1.Join();
            t2.Join();

            Console.WriteLine("After:" + Calcul.readValue());
        }
        static void workWithoutLock()
        {
            for (int i = 0; i < 65536; i++)
            {
                short a = Calcul.readValue();
                a++;
                Calcul.setValue(a);    
            }
        }

        static void workWithLock()
        {
            for (int i = 0; i < 65536; i++)
            {
                lock(lockTool)
                {
                    short a = Calcul.readValue();
                    a++;
                    Calcul.setValue(a);
                }               
            }
        }           
    }
}
