using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodDrill4
{
    class Program
    {
        static void Main(string[] args)
        {
            MathMeth n = new MathMeth();

            Console.WriteLine("Enter a number.");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another number or hit enter to use the default number of 10.");
            string num2 = Console.ReadLine();
            Console.WriteLine("We will now add the two numbers together.");
            if (num2 == "")
            {
                Console.WriteLine("The answer is: " + n.Sum(num1));
            }
            else
            {
                int num3 = Convert.ToInt32(num2);
                Console.WriteLine("The answer is: " + n.Sum(num1, num3));
            }
            Console.ReadLine();
        }
    }
}
