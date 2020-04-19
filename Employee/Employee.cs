using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public class Employee : Person, IQuittable
    {
        public void Quit()
        {
            IQuittable quittable = new Employee();
            Console.WriteLine("You can take this job and shove it..... I QUIT!");
            Console.ReadLine();
        }
        public int ID { get; set; }
    }
}
