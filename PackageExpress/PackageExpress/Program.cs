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
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();

            // Takes the width of the package from the user and stores in variable for the quote
            Console.WriteLine("Please enter the package width:");
            width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();

            // Takes the height of the package from the user and stores in variable for the quote
            Console.WriteLine("Please enter the package height:");
            height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();

            // Takes the length of the package from the user and stores in variable for the quote
            Console.WriteLine("Please enter the package length:");
            length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();

            // Creates a quote from variables from user inputs
            quote = (weight * width * height * length);
            finQuote = Convert.ToDecimal(quote) / 100m;

            // if and else, If the dimensions total greater than 50, display the error message 
            if (weight > 50 || width > 50 || height > 50 || length > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("Your estimated total for shipping this package is:" + "\n$" + finQuote + "\nThank you.");
                Console.ReadLine();
            }
        }
    }
}
