using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulDelegate
{
    delegate void Calculator(int n,int a);

    public class DelegateExample
    {
       
        public static void add(int n,int a)
        {
          
            Console.WriteLine("sum of {0} and {1} = {2}",n,a,a+n);
        }
        public static void mul(int n,int a)
        {
            Console.WriteLine("mul of {0} and {1} = {2}", n, a, a * n);

        }
        
        class Program
        {
            static void Main(string[] args)
            {
                Calculator c1 = new Calculator(add);//instantiating delegate 
                c1(50, 60);
                Calculator c2 = new Calculator(mul);
                c2(46, 32);
                //calling method using delegate  
                
            }
        }
    }
}
