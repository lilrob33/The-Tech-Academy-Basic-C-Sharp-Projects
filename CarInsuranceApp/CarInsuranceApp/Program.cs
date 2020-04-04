using System;

namespace CarInsuranceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int userAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            bool age = (userAge >= 16);

            Console.WriteLine("Have you ever had a DUI?" + "\nPlease enter true or false only");
            string drunk = Console.ReadLine();
            Console.WriteLine();
            bool DUI = Convert.ToBoolean(drunk);
            Console.WriteLine("Press Enter to continue");

            Console.WriteLine("How many speeding tickets do you have?");
            int ticket = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Press Enter to continue");
            bool speed = (ticket <= 3);

            bool result = (age && speed == true && DUI == false);
            Console.WriteLine("Qualified?" + "\n" + result);
            Console.ReadLine();
        }
    }
}
