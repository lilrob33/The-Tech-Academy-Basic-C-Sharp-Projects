using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodDrill

{
    class Program
    {
        static void Main(string[] args)
        {
            // 2.In the Main() program, ask the user what number they want to do the 
            // math operations on.
           Console.WriteLine("Please enter an integer for the math operations.");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = 32;
            int total;
            MathOp n = new MathOp();

            //3.Call each method in turn, passing the user input to the method.
            //Display the returned integer to the screen.
          total = n.Sum(a, b);
            Console.WriteLine("The sum of " + a + " and " + b + " is " + total);
            total = n.Product(a, b);
            Console.WriteLine("The product of " + a + " and " + b + " is " + total);
            total = n.Difference(a, b);
            Console.WriteLine("The difference of " + a + " and " + b + " is " + total);
            Console.ReadLine();

        }
    }
}
