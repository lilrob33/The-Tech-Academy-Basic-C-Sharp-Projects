using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.firstName = "Sample";
            employee.lastName = "Student";
            employee.ID = 1;

            Employee employee1 = new Employee();
            employee1.firstName = "Student";
            employee1.lastName = "Sample";
            employee1.ID = 2;

            employee.sayName();
            employee1.sayName();
            Console.WriteLine("Does the Employee ID numbers Match?");
            employee.Quit();
            Console.WriteLine(employee == employee1);
            Console.ReadLine();
        }
    }
}
