using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pushpop
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<float> fnumber = new Stack<float>();
            fnumber.Push(10.15f);
            fnumber.Push(11.15f);
            fnumber.Push(15.15f);
            fnumber.Push(105.15f);

            Console.WriteLine("\nBefore calling the pop method\n");
            foreach (var fn in fnumber)
                Console.WriteLine(fn);

            fnumber.Pop();
            Console.WriteLine("\nAfter calling the pop method\n");
            foreach (var fn in fnumber)
                Console.WriteLine(fn);


            Queue<double> qnumbers = new Queue<double>();
            qnumbers.Enqueue(10.98);
            qnumbers.Enqueue(15.98);
            qnumbers.Enqueue(16.98);
            qnumbers.Enqueue(105.98);

            Console.WriteLine("\nBefore calling the Deque method\n");
            foreach (var qn in qnumbers)
                Console.WriteLine(qn);

            qnumbers.Dequeue();
            Console.WriteLine("\nAfter calling the Deque method\n");
            foreach (var qn in qnumbers)
                Console.WriteLine(qn);

            Console.ReadKey();
        }


    }
}
