using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MultiThreadingApp
{
    class Program
    {
       
        static void Main(string[] args)
        {
           
            Console.WriteLine("Main Thread is Started");

            Thread t = Thread.CurrentThread;
            
            t.Name = "main thread";
            Console.WriteLine("{0} is the starting with the ID {1}",t.Name,t.ManagedThreadId);
            Thread t1 = new Thread(Method1);
            Thread t2 = new Thread(Method2);
            Thread t3 = new Thread(Method3);

            t1.Start();
            t2.Start();
            t3.Start();
            //Method1();
            //Method2();
            //Method3();
            //FindArea();
            Thread tp = new Thread(new ParameterizedThreadStart(Test));
            tp.Start(50);
            t1.Join();t2.Join();t3.Join();tp.Join();
            //join() method is resposable for preventing the main thread to 
            //exit from the program unless all the child threads have complete with their tasks

            Console.WriteLine("Main Thread is stop");
            Console.ReadLine();
        }
        public static void Method1()
        {
            for (int i = 1; i <= 30; i++)
                Console.WriteLine("method1:{0}", i);
        }
        public static void Method2()
        {
            for (int i = 1; i <= 30; i++)
            {
                if (i == 15)
                {
                    Thread.Sleep(5000);
                }
                Console.WriteLine("method2:{0}", i);
            }
        }
        public static void Method3()
        {
            for (int i = 1; i <= 30; i++)
                Console.WriteLine("method3:{0}", i);
        }
        public static void Test(object max)
        {
            int j = Convert.ToInt32(max);
            for (int i = 1; i <= j; i++)
            {
                Console.WriteLine("Test:{0}", i);
            }
        }
        //public static void FindArea()
        //{
        //    double L, B;

        //    Console.WriteLine("ENTER THE LENGTH");
        //    L = double.Parse(Console.ReadLine());
        //    Console.WriteLine("ENTER THE BREATH");
        //    B = double.Parse(Console.ReadLine());

        //    var FindArea = L * B;

        //    Console.WriteLine("Area of rectangle:{0}", FindArea);
        //}
    }
}
