using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_handeling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] marks = new int[6] { 45, 55, 65, 75, 85, 95 };

                for (int i = 0; i <= 6; i++)
                {
                    Console.WriteLine("Subject marks = {0}", i + 1, marks[i]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            Console.WriteLine("Rest of the code is executed");

            try
            {
                int a, b;
                float c;
                Console.WriteLine("enter numerator");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("enter denominator");
                b = int.Parse(Console.ReadLine());
                if (b == 0)
                    throw new DivideByZeroException("denomenator can't be zero");
                else
                {
                    c = a / b;
                    Console.WriteLine("c={0}",c);
                }
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }


            Console.ReadKey();
        }
        
    }
}
