using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodDrill
{
    public class MathOp
    {
        // 1. Create a class. In that class, create three methods, each of which 
        // will take one integer parameter in and return an integer.The methods 
        // should do some math operation on the received parameter.Put this 
        // class in a separate.cs file in the application.
        // public int Sum(int num1, int num2)
        {
            var Total = num1 + num2;
            return Total;
        }
        public int Product(int num1, int num2)
        {
            var Total = num1 * num2;
            return Total;
        }
        public int Difference(int num1, int num2)
        {
            var Total = num1 - num2;
            return Total;
        }
    }
}
