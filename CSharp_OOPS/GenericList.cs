using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace genericList
{
    class Program
    {
        static void Main(string[] args)
        {
            customer customer1 = new customer()
            {
                EmpID = 1,
                EmpName = "Sourabh",
                EmpSalary = 50000
            };
            customer customer2 = new customer()
            {
                EmpID = 2,
                EmpName = "Shaili",
                EmpSalary = 60000
            };
            customer customer3 = new customer()
            {
                EmpID = 3,
                EmpName = "Saloni",
                EmpSalary = 55000
            };

            //using list    
            // Creating List with initial capacity 2    
            List<customer> Customers = new List<customer>(2);
            Customers.Add(customer1);
            Customers.Add(customer2);
            Customers.Add(customer3);

            //Accessing Item from the List    

            customer c1 = Customers[0];
            Console.WriteLine("ID={0}, Name={1}, Salary={2}", c1.EmpID, c1.EmpName, c1.EmpSalary);

            customer c2 = Customers[1];
            Console.WriteLine("ID={0}, Name={1}, Salary={2}", c2.EmpID, c2.EmpName, c2.EmpSalary);

            customer c3 = Customers[2];
            Console.WriteLine("ID={0}, Name={1}, Salary={2}", c3.EmpID, c3.EmpName, c3.EmpSalary);
        }
    }
    class customer
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public int EmpSalary { get; set; }

    }
}