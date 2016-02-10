using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCode
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public double AddDoubles(double a, double b)
        {
            return a +  b;
        }

        public int Divide(int value, int by)
        {
            if (value > 200)
                throw new ArgumentOutOfRangeException("value");

            return value / by;

        }
    } 
}
