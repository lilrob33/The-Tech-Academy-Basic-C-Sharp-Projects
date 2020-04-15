using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodDrill3
{
    class MathMeth
    {
        public int Sum(int num1, int optionalNum = 4)
        {
            var Total = num1 + 25 + optionalNum;
            return Total;
        }
    }
}
