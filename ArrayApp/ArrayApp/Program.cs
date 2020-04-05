using System;
using System.Collections.Generic;

    class Program
    {
    static void Main()
    {

        while (true)
        {
            // created a string array of random personality characteristics
            string[] strArray = { "Determination", "Self-control", "Kindness", "Persistence",
            "Impatience", "Abrasiveness", "Narcissism", "Unforgiving" };
            Console.WriteLine("Please select an index from the personality characteristic array.");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num > 7)
            {
                Console.WriteLine("I am sorry that index does not exist. \n Press Enter to try again.");
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine(strArray[num]);
                Console.WriteLine("Please press Enter to continue");
                Console.ReadLine();
                break;
            }
        }

        while (true)
        {
            // created a string array of random numbers
            int[] numArray = { 5, 2, 10, 200, 5000, 6300, 230, 78 };
            Console.WriteLine("Please select an index from the number array.");
            int num1 = Convert.ToInt32(Console.ReadLine());
            if (num1 > 7)
            {
                Console.WriteLine("I am sorry that index does not exist. \n Press Enter to try again.");
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine(numArray[num1]);
                Console.WriteLine("Please press Enter to continue");
                Console.ReadLine();
                break;
            }
        }

        while (true)
        {
            // created a list of random video games
            List<string> gameList = new List<string>();
            gameList.Add("Pokemon");
            gameList.Add("Metroid");
            gameList.Add("Ark");
            gameList.Add("Destiny");
            gameList.Add("Zelda");
            gameList.Add("Castlevania");
            gameList.Add("Witcher");
            gameList.Add("Battlefield");
            Console.WriteLine("Please select an index from the video game array.");
            int num2 = Convert.ToInt32(Console.ReadLine());
            if (num2 > 7)
            {
                Console.WriteLine("I am sorry that index does not exist. \n Press Enter to try again.");
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine(gameList[num2]);
                Console.ReadLine();
                break;
            }
        }
    }
    }
