using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstVar
{
    class Program
    {
        public static void Main(string[] args)
        {
            const string Company = "Esco";
            var Year = 1913;
            Employee employee1 = new Employee(9026, "Pedro Suarez");
            Employee employee2 = new Employee("Eric Estrada");
            Console.WriteLine("Welcome to " + Company + ". \nEstablished in " + Year + ", we have two employees that can help you with your needs. \n" + employee1.name + " and " + employee2.name);
            Console.ReadLine();
        }
    }
}
