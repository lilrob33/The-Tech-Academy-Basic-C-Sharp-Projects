using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput;
            Console.WriteLine("Please enter any number");
            userInput = Convert.ToInt32(Console.ReadLine());
            using (StreamWriter file = new StreamWriter(@"C:\users\psuar\source\repos\FileIO\log.txt", true))
            {
                file.WriteLine(userInput);
            }
            Console.WriteLine("Your number is " + userInput);
            Console.ReadLine();
        }
    }
}
