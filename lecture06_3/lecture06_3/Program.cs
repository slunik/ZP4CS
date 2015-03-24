using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace lecture06_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer timer = new Timer(x => Console.Title = DateTime.Now.ToLongTimeString(), null, 0, 1000);
            Console.ReadLine();  
        }   
    }
}
