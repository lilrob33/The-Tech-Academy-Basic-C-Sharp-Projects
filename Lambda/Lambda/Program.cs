using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        public static void Main()
        {
            List<Employee> e = new List<Employee>();
            
            e.Add(new Employee()
            { firstName = "Joe", lastName = "Talimao", ID = 1 });
            e.Add(new Employee()
            { firstName = "Joe", lastName = "Rogan", ID = 2 });
            e.Add(new Employee()
            { firstName = "Joe", lastName = "Jackson", ID = 3 });
            e.Add(new Employee()
            { firstName = "Peyton", lastName = "McWilliams", ID = 4 });
            e.Add(new Employee()
            { firstName = "Ariana", lastName = "Suarez", ID = 5 });
            e.Add(new Employee()
            { firstName = "Adre", lastName = "Nicatina", ID = 6 });
            e.Add(new Employee()
            { firstName = "Roberto", lastName = "Flores", ID = 7 });
            e.Add(new Employee()
            { firstName = "Bue", lastName = "Bennett", ID = 8 });
            e.Add(new Employee()
            { firstName = "Aaron", lastName = "Yates", ID = 9 });
            e.Add(new Employee()
            { firstName = "Laureen", lastName = "Soto", ID = 10 });


            List<Employee> Templist = new List<Employee>();
            foreach (var employee in e)
            {

                if (employee.firstName == "Joe")
                {
                    Templist.Add(employee);
                }
            }

            foreach (Employee employee in Templist)
            {
                Console.WriteLine(employee.firstName + " " + employee.lastName + " " + employee.ID);
            }

            List<Employee> joe = e.Where(x => x.firstName == "Joe").ToList();

            foreach (Employee employee in joe)
            {
                Console.WriteLine(employee.firstName + " " + employee.lastName + " " + employee.ID);
            }

            List<Employee> overFive = e.Where(x => x.ID > 5).ToList();

            foreach (Employee employee in overFive)
            {
                Console.WriteLine(employee.firstName + " " + employee.lastName + " " + employee.ID);
            }
            Console.ReadLine();
        }
    }
}
