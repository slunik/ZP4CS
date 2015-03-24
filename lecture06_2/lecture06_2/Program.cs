using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace lecture06_2
{
    class Program
    {
        private static object pickLock = new object();
        private static string data = String.Empty;

        static void Main(string[] args)
        {
            int minWorker, minIOC;

            ThreadPool.GetMinThreads(out minWorker, out minIOC);
            ThreadPool.SetMinThreads(90, minIOC);

            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);

                if (key.Key.Equals(ConsoleKey.Enter))
                {
                    break;
                }
                ThreadPool.QueueUserWorkItem(doWord, key);                
            }
            Console.WriteLine();
        }

        private static void doWord(object key)
        {
            int position = 0;

            lock (pickLock)
            {            
                Console.Write('\r');                
                string localData = data;
                position = data.Length;
                localData += ".";
                data = localData;
                Console.Write(data);
            }
            Thread.Sleep(3000);

            lock (pickLock)
            {
                Console.Write('\r');
                StringBuilder sb = new StringBuilder(data);
                sb[position] = ((ConsoleKeyInfo)key).KeyChar;
                data = sb.ToString();
                Console.Write(data);
            }            
        }
    }
}
