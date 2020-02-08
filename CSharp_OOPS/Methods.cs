using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {

            //Boxing and unboxing
            object obj; // object is refernce type
            int a = 10;
            obj = a;  //converting a value type to refernce type implecity - Boxing

            int b = (int)a; //coverting a boxed type into a value type by explicity casting it -                               Unboxing

            Console.WriteLine("Value of a and b is {0} and {1}", a, b);
            
            //Passing arguments by value type

            int i = 10, j = 20;

            Console.WriteLine("Value of i and j before functin call {0} and {1}", i, j);
            double sum = ShowData(ref i, ref j);
            Console.WriteLine("Value of i and j after functin call {0} and {1}", i, j);

            Console.WriteLine("sum = {0}", sum);

            Console.ReadLine();
        }
        public static double ShowData (ref int a, ref int b)
        {
            double sum = a + b;
            a += 5;
            b += 5;
            return sum;
        }
    }
}
