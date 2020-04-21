using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public class Employee : Person, IQuittable
    {
        public class Worker<T>
        {
            public List<T> things { get; set; }
        }

        public static bool operator ==(Employee employee, Employee employee1)
        {
            if (employee.ID == employee1.ID)
            {
                bool isSame = true;
                return isSame;
            }
            else
            {
                bool isSame = false;
                return isSame;
            }
        }

        public static bool operator !=(Employee employee, Employee employee1)
        {
            if (employee.ID != employee1.ID)
            {
                bool isNotSame = true;
                return isNotSame;
            }
            else
            {
                bool isNotSame = false;
                return isNotSame;
            }
        }

        public void Quit()
        {
            IQuittable quittable = new Employee();
            Console.WriteLine("You can take this job and shove it..... I QUIT!");
            Console.ReadLine();
        }
    }
}
