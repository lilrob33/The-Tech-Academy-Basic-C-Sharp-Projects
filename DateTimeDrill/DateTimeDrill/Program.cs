using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime currentTime = DateTime.Now;
            Console.WriteLine(currentTime);

            Console.WriteLine("Please enter a number and we will add that to the current time" +
                " to see what time it will be.");
            var hours = Convert.ToInt32(Console.ReadLine());

            DateTime timeInHours = currentTime.AddHours(hours);
            Console.WriteLine("It will be " + timeInHours + " in " + hours + " hours.");
            Console.ReadLine();
        }
    }
}
