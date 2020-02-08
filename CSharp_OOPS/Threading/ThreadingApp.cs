using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace ThreadedAppPerform
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Thread Started");
            Stopwatch s1 = new Stopwatch();
            
            s1.Start();
            Incrementcount1();
            Incrementcount2();
            s1.Stop();

            Stopwatch s2 = new Stopwatch();

            Thread t1 = new Thread(Incrementcount1);
            Thread t2 = new Thread(Incrementcount2);

            s2.Start();
            t1.Start();
            t2.Start();
            s2.Stop();

            t1.Join();
            t2.Join();

            Console.WriteLine("total time elapsed for a single thread application :{0}",s1.ElapsedMilliseconds);
            Console.WriteLine("total time elapsed for a multi thread application :{0}",s2.ElapsedMilliseconds);
            Console.WriteLine("Main Thread Exited");
        }

        public static void Incrementcount1()
        {
            long count1 = 0;
            for (int i = 1; i <= 10000000; i++)
            {
                count1++;
            }
            Console.WriteLine("count1 :{0}", count1);
        }

        public static void Incrementcount2()
        {
            long count2 = 0;
            for (int i = 1; i <= 10000000; i++)
                count2++;
           Console.WriteLine("count2 :{0}", count2);
        }

    }
}
