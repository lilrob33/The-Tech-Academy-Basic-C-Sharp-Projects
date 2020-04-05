using System;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            // Setting up data types to variables
            int weight, width, height, length, quote;
            decimal finQuote;

            // Welcome intro to package express
            Console.WriteLine("Welcome to Package Express." +
                "\nPlease follow the instructions below.");

            // Takes the weight of the package from the user and stores in variable for the quote
            Console.WriteLine("Please enter the package weight:");
            weight = Convert.ToInt32(Console.ReadLine());
            if (weight > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine();
                Environment.Exit(0);
            }

            else
            {
                Console.WriteLine("Please press Enter to continue");
                Console.ReadLine();
            }
            // Takes the width of the package from the user and stores in variable for the quote
            Console.WriteLine("Please enter the package width:");
            width = Convert.ToInt32(Console.ReadLine());
            if (width > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine();
                Environment.Exit(0);
            }

            else
            {
                Console.WriteLine("Please press Enter to continue");
                Console.ReadLine();
            }

            // Takes the height of the package from the user and stores in variable for the quote
            Console.WriteLine("Please enter the package height:");
            height = Convert.ToInt32(Console.ReadLine());
            if (height > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine();
                Environment.Exit(0);
            }

            else
            {
                Console.WriteLine("Please press Enter to continue");
                Console.ReadLine();
            }

            // Takes the length of the package from the user and stores in variable for the quote
            Console.WriteLine("Please enter the package length:");
            length = Convert.ToInt32(Console.ReadLine());
            if (length > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine();
                Environment.Exit(0);
            }

            else
            {
                Console.WriteLine("Please press Enter to continue");
                Console.ReadLine();
            }
           
            // Creates a quote from variables from user inputs
            quote = (weight * width * height * length);
            finQuote = Convert.ToDecimal(quote) / 100m;

            Console.WriteLine("Your estimated total for shipping this package is:" + "\n$" + finQuote + "\nThank you.");
                Console.ReadLine();
        }
    }
}
