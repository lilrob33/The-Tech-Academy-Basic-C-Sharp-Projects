using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        public enum daysOfTheWeek
        {
            Monday=1,
            Tuesday=2,
            Wednesday=3,
            Thursday=4,
            Friday=5,
            Saturday=6,
            Sunday=0
        }

            private static void Main()
            {
                try
                {
                    Console.WriteLine("What day is it today?");
                    string day = Console.ReadLine();
                    daysOfTheWeek dayOfTheWeek = (daysOfTheWeek)Enum.Parse(typeof(daysOfTheWeek), day);
                    Console.WriteLine("That's Awesome!!");
                    Console.ReadLine();
                }
                catch (Exception)
                {
                    Console.WriteLine("That is invalid. Please enter an actual day of the week");
                    Console.ReadLine();
                }
            }
    }
}
