﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodDrill2
{
    class MathMeth
    {
        public int Sum(int num1)
        {
            var Total = num1 + 14;
            return Total;
        }
        public int Difference(decimal num1)
        {
            var Total = num1 - 3;
            return Convert.ToInt32(Total);
        }
        public int Product(string num1)
        {
            var Total = Convert.ToInt32(num1) * 10;
            return Total;
        }
    } 
}
