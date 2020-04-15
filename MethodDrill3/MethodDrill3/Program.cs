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
            Console.WriteLine("Please enter two numbers for the math operation, one at a time." +
                " No need to enter anything for the second number.");
            try
            {
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                int total;

                MathMeth n = new MathMeth();
                total = n.Sum(a, b);
                Console.WriteLine("The sum of " + a + " , " + 25 + " and " + b + " is " + total);
                
                total = n.Sum(a);
                Console.WriteLine("The sum of " + a + " , " + 25 + " and " + "optional number 4 is " + total);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please enter a number", ex);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
