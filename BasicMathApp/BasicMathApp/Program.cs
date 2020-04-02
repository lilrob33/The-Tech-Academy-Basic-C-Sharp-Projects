using System;

namespace BasicMathApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Setting up data types to variables
            int num1, num2, num3, num4, num5;

            // Welcome intro to basic math app
            Console.WriteLine("Welcome to a basic math operations app!" +
                "\nHere we will do a few math operations." +
                "\nLets get started!");

            // Added a pause to the text to give it a nice feel to it
            // I really do like this!
            System.Threading.Thread.Sleep(3500);
            Console.Clear();

            // Takes an input from the user, multiplies it by 50, and prints the result to the console
            Console.WriteLine("Please enter a number and we will multiply it by 50");
            num1 = Convert.ToInt32(Console.ReadLine());
            int product = num1 * 50;
            Console.WriteLine(num1 + " times 50 = " + product.ToString()  +
                "\nPress enter to continue");
            Console.ReadLine();

            //Takes an input from the user, adds 25 to it, and prints the result to the console
            Console.WriteLine("Please enter a number and we will add 25 to it");
            num2 = Convert.ToInt32(Console.ReadLine());
            int total = num2 + 25;
            Console.WriteLine(num2 + " plus 25 = " + total.ToString() +
                "\nPress enter to continue");
            Console.ReadLine();

            //Takes an input from the user, divides it by 12.5, and prints the result to the console
            Console.WriteLine("Please enter a number and we will divide it by 12.5");
            num3 = Convert.ToInt32(Console.ReadLine());
            decimal quotient = num3 / 12.5m;
            Console.WriteLine(num3 + " divide by 12.5 = " + quotient.ToString() +
                "\nPress enter to continue");
            Console.ReadLine();

            //Takes an input from the user, checks if it is greater than 50, and prints the true/false result to the console
            Console.WriteLine("Please enter a number and we will check to see if it is greater than 50");
            num4 = Convert.ToInt32(Console.ReadLine());
            bool greater = num4 > 50;
            Console.WriteLine("Is " +num4 + " greater than 50? " + greater.ToString() +
                "\nPress enter to continue");
            Console.ReadLine();

            //Takes an input from the user, divides it by 7, and prints the remainder to the console
            Console.WriteLine("Please enter a number and we will divide it by 7 and give you the remainder");
            num5 = Convert.ToInt32(Console.ReadLine());
            int remainder = num5 % 7;
            Console.WriteLine(num5 + " divide by 7 = " + remainder.ToString() +
                "\nPress enter to End");
            Console.ReadLine();
        }
    }
}
