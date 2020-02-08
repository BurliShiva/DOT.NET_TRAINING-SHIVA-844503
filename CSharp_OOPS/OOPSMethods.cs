using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsmethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee(); //instantiation of employee class using new keyword
            Employee e1 = new Employee(1, "shiva", 2, "admin"); //
            Employee e2 = new Employee(2, "nani", 3, "store");
            e1.ShowData();
            e2.ShowData();

            Product prd = new Product() { Productid = 1, Productname = "badam milk" };
            prd.ShowData();
           
            Custmor cust = new Custmor() { custmorid = 4326,custmorname = "shiva", custmorcountry = "india" };
           
            
            cust.ShowData();
            Console.ReadKey();
        }
    }
    public class Employee
    {
        int empid;
        string name;
        short depid;
        string deptname;

        public Employee()
        { }

        public Employee (int eid,string ename)
        {
            empid = eid;
            name = ename;
        }

        public Employee( int eid,string ename,short did,string dname)
        {
            empid = eid;
            name = ename;
            depid = did;
            deptname = dname;
        }

        public void ShowData()
        {
            Console.WriteLine("empid = {0}", empid);
            Console.WriteLine("name = {0}", name);
            Console.WriteLine("deptid = {0}", depid);
            Console.WriteLine("deptname = {0}", deptname);
           
        }
     
    }
    public class Product
    {
        public int Productid
        {
            get;
            set;
        }
        
        public string Productname
        {
            get;
            set;
        }
        public void ShowData()
        {
            Console.WriteLine("productid = {0}", Productid);
            Console.WriteLine("productname = {0}", Productname);
        }
        
    }
    public class Custmor
    {
        public int custmorid
        {
            get;
            set;
        }
        public string custmorname
        {
            get;
            set;
        }
        public string custmorcountry
        {
            get;
            set;
        }


        public void ShowData()
        {
            Console.WriteLine("custmorid = {0}", custmorid);
            Console.WriteLine("custname = {0}", custmorname);
            Console.WriteLine("custcountry = {0}", custmorcountry);
        }

    }

}
