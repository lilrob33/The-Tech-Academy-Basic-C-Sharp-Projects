using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            // set up string variables with text
            string sent1 = "Hello, my name is Pedro.";
            string sent2 = "I am glad to meet you.";
            string sent3 = "We will have the next sentence all uppercase.";
            string sent4 = "this looks loud like this.";

            // concat the sentences together leaving a space for new sentence
            Console.WriteLine(sent1 + " " + sent2 + " " + sent3);
            Console.ReadLine();

            // convert sentence to all uppercase
            sent4 = sent4.ToUpper();
            Console.WriteLine(sent4);
            Console.ReadLine();

            // set up 1st stringbulder sentence 
            StringBuilder sentence = new StringBuilder("I have found myself really enjoying C#.");

            // first append to sentence
            sentence.Append("\nThe more I learn to write code the more I want to do it.");
 
            // second append 
            sentence.Append("\nI know currently I am close to finishing The Tech Academy, and yet soo far.");

            // third append
            sentence.Append("\nI do hope to find employment right as I finish the program.");

            // final append and print to console
            sentence.Append("\nThat would truly be a good day for me.");
            Console.WriteLine(sentence);
            Console.ReadLine();
        }
    }
}
