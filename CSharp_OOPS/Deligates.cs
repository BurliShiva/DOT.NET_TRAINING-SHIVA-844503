using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeligatesEvents
{
    class Program
    {
        public delegate double SalDelegate(int ds, float sd);
        
        static void Main(string[] args)
        {
            SalDelegate deleg = new SalDelegate(GetSalary);
            var salary = deleg.Invoke(30, 800);
            Console.WriteLine("salary = {0}", salary);

            Console.ReadKey();    
        }
        public static double GetSalary(int nds,float spd)
        {
            var salary = (nds * spd);
            return salary;
        }
    }
}
