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
            Console.WriteLine(employee == employee1);
            employee.Quit();
            Console.ReadLine();

            Employee.Worker<string> worker = new Employee.Worker<string>();
            worker.things = new List<string>();
            worker.things.Add("Pedro");
            worker.things.Add("Laureen");
            worker.things.Add("Ariana");

            Employee.Worker<int> IDNum = new Employee.Worker<int>();
            IDNum.things = new List<int>();
            IDNum.things.Add(1);
            IDNum.things.Add(2);
            IDNum.things.Add(3);

            foreach (string x in worker.things)
            {
                Console.WriteLine(x);
            }

            foreach (int y in IDNum.things)
            {
                Console.WriteLine(y);
            }

            Console.ReadLine();
        }
    }
}
