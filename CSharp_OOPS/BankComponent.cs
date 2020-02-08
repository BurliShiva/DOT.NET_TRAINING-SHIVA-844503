using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankComponent;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SavingsAccount si = new SavingsAccount(); ;
            //{
            //    P = 5000, T = 3 ,R=10
            //};
            //si.ShowData();
            var SI = si.GetSimpleIntrest(5000,3,10);
            var TA = si.GetTotalAmount(5000,SI);
            
            Console.WriteLine("Simple Intrest ={0}", SI);
            Console.WriteLine("Total Amount ={0}", TA);
            Console.ReadKey();
        }
    }
}
