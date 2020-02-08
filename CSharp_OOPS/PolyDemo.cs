using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polydemo
{
    class Program
    {
        static void Main(string[] args)
        {
            employee emp = new employee();
            var salary = emp.GetSalary(30, 800);
            Console.WriteLine("salary without incentives: Rs {0}",salary);

            salary = emp.GetSalary(30, 800, 5000);
            Console.WriteLine("salary with intensives: Rs {0}", salary);

            Manager objM = new Manager();
            var ts = objM.GetPerks(30000 , 5000);
            Console.WriteLine("salary of manager: Rs{0}", ts);
            Console.ReadKey();
        }
    }
    public class employee
    {
        public double GetSalary(int nds, float spd)
        {
            double salary = nds * spd;
            return salary;
        }
        public double GetSalary(int nds, float spd, float incent)
        {
            double salary = (nds * spd) + incent;
            return salary;
        }
        //this method will be over ride in other derived class
        public virtual double GetPerks(float salary, float perks)
        {
            double ts = salary + perks;
            return ts;
        }
        
    }
    public class Manager:employee
    {
        public override double GetPerks(float salary, float perks)
        {
            return base.GetPerks(salary, perks);
        }
    }
}
