using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodDrill5
{
    class MathMeth
    {
        public void Division(int a)
        {
            int result = a / 2;
            Console.WriteLine("Your number divided by 2 equals: " + result);
            return;
        }

        public void Division(out int x, out int y)
        {
            Console.WriteLine("Select a number");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Select another number");
            y = Convert.ToInt32(Console.ReadLine());
        }

        public static int Print()
        {
            int d = 50;
            return d;
        }
    }
}
