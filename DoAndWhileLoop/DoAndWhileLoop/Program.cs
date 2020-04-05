using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAndWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            // Do while statement guess a number
            Console.WriteLine("Guess a number");
            int number = Convert.ToInt32(Console.ReadLine());

            do 
            {
                Console.WriteLine(number);
                number++;
                // will icrement number if input under 20 to 20
            } while (number < 20);

            Console.ReadLine();

            // Continue in while-loop until index is equal to 10.
            int i = 0;
            while (i < 10)
            {
                Console.Write("While statement ");
                Console.WriteLine(i);
                // Increment the variable.
                i++;
            }
            Console.ReadLine();
                
        }
    }
}
