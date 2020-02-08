using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ReflectionsApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //reflection in .NET is all about knowing the various types, their methods, functions, return types.
            //as well as parameters information contained in that application during run time.
            //All the reflections related classes are available in the namespsce System.Reflection.

            Assembly assembly = Assembly.Load("EmployeeCom");
            Type[] types = assembly.GetTypes();

            foreach (Type type in types)
            {
                Console.WriteLine("Base type: {0}", type.BaseType);
                Console.WriteLine("Name: {0}", type.Name);

                MethodInfo[] methods = type.GetMethods();

                foreach (MethodInfo method in methods)
                {
                    Console.WriteLine("method name: {0}", method.Name);
                    Console.WriteLine("return type: {0}", method.ReturnType);

                    ParameterInfo[] parameters = method.GetParameters();
                    foreach (ParameterInfo param in parameters)
                    {
                        Console.WriteLine("Parameter name: {0}", param.Name);
                        Console.WriteLine("parameter type: {0}", param.ParameterType);
                        Console.WriteLine("-----------------------------------------");
                    }
                    Console.WriteLine("-----------------------------------------");
                }
                Console.WriteLine("-----------------------------------------");
            }

        }
    }
}
