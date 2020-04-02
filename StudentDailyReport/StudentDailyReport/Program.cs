using System;

namespace StudentDailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            // Setting up data types to variables
            string course;
            int pageNum;
            bool help;
            string posExp;
            string feed;
            int study;

            // Welcome intro to student daily report
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");

            // Added a pause to the text to give it a nice feel to it
            System.Threading.Thread.Sleep(1500);
            Console.Clear();

            // first question
            Console.WriteLine("What course are you on?");
            course = Console.ReadLine();

            // second question
            Console.WriteLine("What page are you on?");
            pageNum = Convert.ToInt32(Console.ReadLine());

            // third question
            Console.WriteLine("Do you need any help with anything? \nPlease answer with a true or false");
            help = Convert.ToBoolean(Console.ReadLine());

            // fourth question
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            posExp = Console.ReadLine();

            // fifth question
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            feed = Console.ReadLine();

            // sixth question
            Console.WriteLine("How many hours did you study today?");
            study = Convert.ToInt32(Console.ReadLine());

            // Thank you and end of program
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly.Have a great day!");
            Console.ReadLine();
        }
    }
}
