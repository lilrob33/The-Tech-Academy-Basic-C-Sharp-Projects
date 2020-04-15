using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodDrill3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter two numbers for the math operation, one at a time.");
            
                int a = Convert.ToInt32(Console.ReadLine());

                int total;
            Console.WriteLine("Enter a second number (optional):  or press ENTER" +
                " to skip and see your total.\n");
                var validInput = int.TryParse(Console.ReadLine(), out int b);
           
            if (validInput)
            {
                total = MathMeth.Sum(a + b);
                Console.WriteLine("The sum of " + a + " , " + 25 + " and the optional second" +
                " number " + b + " is " + total);
                Console.ReadLine();
            }
            else
            {
                total = MathMeth.Sum(a);
                Console.WriteLine("The sum of " + a + " and " + 25 + " is " + total);
                Console.ReadLine();
            } 
        }
    }
}
