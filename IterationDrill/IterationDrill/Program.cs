using System;
using System.Collections.Generic;
using System.Linq;

namespace IterationDrill
{
    class Program
    {
        static void Main()
        {
            // 1.Create a one-dimensional Array of strings.Ask the user to input some text.
            // Create a loop that goes through each string in the Array, adding the user’s 
            // text to the string.Then create a loop that prints off each string in the Array 
            // on a separate line.

            string[] array1 = { "Determination", "Self-control", "Kindness", "Persistence"};
            Console.WriteLine("Please input text high, med, or low then hit enter");
            string userInput = Console.ReadLine();

            for (int a = 0; a < array1.Length; a++) 
            {
                Console.WriteLine(userInput + " " + array1[a]);
            }
            Console.ReadLine();

            // 2.Create an infinite loop.

            int i = 0;
            while (true)
            {
                Console.WriteLine("Value of i: {0}", i);

                i++;
            
            // 3.Fix the infinite loop so it will execute.
                if (i > 10)
                    break;
            }
            Console.ReadLine();

            // 4.Create a loop where the comparison used to determine whether to continue 
            // iterating the loop is a “<” operator.

            int j = 0;
            while (j < 13)
            {
                Console.WriteLine("Value of a: {0}", j);

                j++;

            }
            Console.ReadLine();

            // 5.Create a loop where the comparison used to determine whether to continue 
            // iterating the loop is a “<=” operator.

            int k = 0;
            while (k <= 15)
            {
                Console.WriteLine("Value of a: {0}", k);

                k++;

            }
            Console.ReadLine();

            // 6.Create a List of strings where each item in the list is unique.Ask the user to
            // input text to search for in the List.Create a loop that iterates through the loop 
            // and then displays the index of the array that contains matching text on the screen.

            List<string> banks = new List<string>() { "chase", "wells fargo", "onpoint", "us bank", "bank of america" };
            Console.WriteLine("Please enter a bank you'd like to see the list index to.");

            string b = Console.ReadLine();
            int c = banks.FindIndex(d => d.Contains(b));

            if (banks.Contains(b))
            {
                Console.WriteLine("List item " + b + " is found at Index: " + c);
            }
            else
            Console.WriteLine("I'm sorry that is not a list option.");
            Console.ReadLine();

            // 7.Add code to that above loop that tells a user if they put in text that isn’t in the List.



            // 8.Add code to that above loop that stops it from executing once a match has been found.



            // 9.Create a List of strings that has at least two identical strings in the List. Ask the 
            // user to select text to search for in the List.Create a loop that iterates through the 
            // loop and then displays the indices of the array that contain matching text on the screen.



            Console.WriteLine("Please enter a hispanic name you'd like to see the list index to."); ;

            string e = Console.ReadLine();

            List<string> names = new List<string>() { "Pedro", "Jose", "Juan", "Jose", "Pedro" };
            int f = names.IndexOf(e);
            int h = names.LastIndexOf(e);
            int m = 0;
            for (m = 0; m < 1; m++)
            {
                if (names.Contains(e))
                {
                    Console.WriteLine(e + " is at index " + f + " and " + h);
                    Console.WriteLine("You searched: " + e);
                }
                else
                {
                    Console.WriteLine("I'm sorry that is not a list option.");
                }
            }

            Console.ReadLine();


            // 10.Add code to that above loop that tells a user if they put in text that isn’t in the List.



            // 11.Create a List of strings that has at least two identical strings in the List. Create
            // a foreach loop that evaluates each item in the list, and displays a message showing
            // the string and whether or not it has already appeared in the list.

            List<string> namesOfGames = new List<string>() { "Metroid", "Ark", "Metroid", "Mario", "Ark", "Tetris" };

            List<string> dup = new List<string>();

            foreach (string name in namesOfGames)
            {
                Console.WriteLine(name);
                if (dup.Contains(name))
                {
                    Console.WriteLine(name + " We have seen this!");
                }
                else //else
                {
                    dup.Add(name);
                }
            }
            Console.ReadLine();
        }
    }
}
