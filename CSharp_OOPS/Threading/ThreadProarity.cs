using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadProarityApp
{
    class Program
    {
        public static long count1 ,count2; 
        static void Main(string[] args)
        {
            Thread t1 = new Thread(IncrementCount1);
            Thread t2 = new Thread(IncrementCount2);

            Console.WriteLine("Main thread started");

            t1.Start();
            t2.Start();

            t1.Priority = ThreadPriority.Lowest;
            t2.Priority = ThreadPriority.Highest;

            Thread.Sleep(5000);

            t1.Abort();
            t2.Abort();

            t1.Join();
            t2.Join();

            Console.WriteLine("count1:{0}", count1);
            Console.WriteLine("count2:{0}", count2);

            Console.WriteLine("Main String exited");
        }
        public static void IncrementCount1()
        {
            while(true)
            {
                count1 += 1;
            }
           
        }
        public static void IncrementCount2()
        {
            while (true)
            {
                count2 += 1;
            }
           
        }
    }
}
