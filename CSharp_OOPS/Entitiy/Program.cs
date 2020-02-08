using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEntityFWorkDB
{
    class Program
    {

        static void Main(string[] args)
        {
            EmployeeEFDBEntities1 context = new EmployeeEFDBEntities1();
            //var Employee = new Employee()
            //{
            //    EmpID = 1,
            //    Name = "Shiva",
            //    Salary = 35000,
            //    DepID = 3,           
            //};
            //context.Employees.Add(Employee);
            //var Employee1 = new Employee()
            //{
            //    EmpID = 2,
            //    Name = "SAI",
            //    Salary = 35000,
            //    SSN = 5,
            //    DepID = 3,           
            //};
            //context.Employees.Add(Employee1);

            //var Employee2 = new Employee()
            //{
            //    EmpID = 3,
            //    Name = "Surya",
            //    Salary = 35000,
            //    SSN = 2,
            //    DepID = 12,
            //};
            //context.Employees.Add(Employee2);
            LinqtoEntity();
            ModifiyEmp();
            DeleteEmp();
        }
        public static void LinqtoEntity()
        {
            EmployeeEFDBEntities1 context = new EmployeeEFDBEntities1();

            var employees = context.Employees;

            var emplist = from Employee in employees
                          orderby Employee.EmpID
                          select Employee;
            foreach (var employee in emplist)
            {
                Console.WriteLine("EmpID {0} Name {1} Salary {2} SSN {3}",
                    employee.EmpID, employee.Name, employee.Salary, employee.SSN);
            }

        }
        public static void ModifiyEmp()
        {
            EmployeeEFDBEntities1 context = new EmployeeEFDBEntities1();

            var employees = context.Employees;

            var emplist = from Employee in employees
                          orderby Employee.EmpID
                          select Employee;
            foreach (var employee in emplist)
            {
                if (employee.EmpID == 1)
                {
                    employee.SSN = 99;
                }
            }
            context.SaveChanges();
        }
        public static void DeleteEmp()
        {
            EmployeeEFDBEntities1 context = new EmployeeEFDBEntities1();

            var employees = context.Employees;
            var Employee = new Employee { EmpID = 4 };
            employees.Attach(Employee);
            employees.Remove(Employee);
            context.SaveChanges();
        }
    }
}

