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


            foreach (var Employee in e) 
            {
                List<Employee> joeList = new List<Employee>();
                if (Employee.firstName == "Joe")
                {
                    joeList.Add(Employee);
                }
            }

            List<Employee> joes = e.Where(x => x.firstName == "Joe").ToList();

            List<Employee> ids = e.Where(x => x.ID > 5).ToList();
        }
    }
}
