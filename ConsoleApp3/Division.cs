using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Division : Plus 
    {
        public override double pluses(double x, double y)
        {
            return x / y;
        }
    }
}
