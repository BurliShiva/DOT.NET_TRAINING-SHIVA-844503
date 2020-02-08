using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debugging
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            a = 9;b = 5;
            Multiply(a, b);
            for(int i=1;i<=5;i++)
            {
                var result = 85 + i;
                Console.WriteLine("result = {0}", result);
            }
            Console.ReadKey();
        }
        public static double Multiply(int a,int b)
        {
            var pro = a * b;
            return pro;
        }
    }
}
