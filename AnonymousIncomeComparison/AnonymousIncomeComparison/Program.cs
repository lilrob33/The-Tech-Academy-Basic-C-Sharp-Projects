using System;

namespace AnonymousIncomeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            // setting up data types for variables
            int p1Rate, p1Hours, p2Rate, p2Hours, p1Salary, p2Salary, p1Weekly, p2Weekly;

            // Welcome intro to anonymous income comparison program
            Console.WriteLine("Welcome to the Anonymous Income Comparison Program!" +
                "\nHere we will get some information and compare it." +
                "\nLets get started!");

            // Added a pause to the text to give it a nice feel to it
            System.Threading.Thread.Sleep(3500);
            Console.Clear();

            // get information from person 1
            Console.WriteLine("Please enter the Hourly rate for Person 1");
            p1Rate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of hours worked per week for Person 1");
            p1Hours = Convert.ToInt32(Console.ReadLine());

            // get information from person 2
            Console.WriteLine("Please enter the Hourly rate for Person 2");
            p2Rate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of hours worked per week for Person 2");
            p2Hours = Convert.ToInt32(Console.ReadLine());

            // show annual salary for person 1
            p1Weekly = p1Rate * p1Hours;
            p1Salary = p1Weekly * 52;
            Console.WriteLine("Annual salary of Person 1: " + "\r\n" + p1Salary);
            Console.ReadLine();

            // show annual salary for person 2
            p2Weekly = p2Rate * p2Hours;
            p2Salary = p2Weekly * 52;
            Console.WriteLine("Annual salary of Person 2: " + "\r\n" + p2Salary);
            Console.ReadLine();

            // checks if person 1 makes more money than person 2, and prints the true/false result to the console
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool greater = p1Salary > p2Salary;
            Console.WriteLine( greater.ToString());
            Console.ReadLine();
        }
    }
}
