using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodDrill5
{
    class Program
    {
        static void Main(string[] args)
        {
            MathMeth n = new MathMeth();
            Console.WriteLine("Pick a number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int a;
            int b;
            n.Division(num1);
            n.Division(out a, out b);
            MathMeth.Print();

            Console.WriteLine("Your first number is " + a);
            Console.WriteLine("Your second number is " + b);
            Console.WriteLine("The number in the static class is " + MathMeth.Print());

        Console.ReadLine();
        }
    }
}
