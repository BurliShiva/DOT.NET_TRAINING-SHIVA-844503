using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            SBAccount objSB = new SBAccount();
            CCAccount objCC = new CCAccount();
            double sisb = objSB.GetSimpleIntrest(100000.00, 5, 8);
            double total = objSB.GetTotalAmount(50000, sisb);
            Console.WriteLine("Simple Intrest (SAVEINGS ACCOUNT) = Rs {0}", sisb);
            Console.WriteLine("Total Amount = Rs {0}", total);

            var siCC = objCC.GetSimpleIntrest(100000.00, 5, 8);
            total = objCC.GetTotalAmount(50000, siCC);
            Console.WriteLine("Simple Intrest (CURRENT ACCOUNT) = Rs {0}", siCC);
            Console.WriteLine("Total Amount = Rs {0}", total);
            objSB.show();
            Console.ReadKey();
        }
        
    }
    public abstract class Banking
    {
        public abstract double GetSimpleIntrest(double pr, int td, short rt);
        public abstract double GetTotalAmount(double bal, double si);
        public void show()
        {
            Console.WriteLine("This is a concrete method define within an abstract class");
        }
    }
    public class SBAccount : Banking
    {
        public override double GetSimpleIntrest(double pr, int td, short rt)
        {
            double si = (pr * td * rt) / 100;
            return si;
        }
        public override double GetTotalAmount(double bal, double si)
        {
            double tamount = bal + si;
            return tamount;
        }
    }

    public class CCAccount : Banking
    {
        public override double GetSimpleIntrest(double pr, int td, short rt)
        {
            double si = 0.25 * ((pr * td * rt) / 100);
            return si;
        }
        public override double GetTotalAmount(double bal, double si)
        {
            double tamount = bal + si;
            return tamount;
        }
    }
}
