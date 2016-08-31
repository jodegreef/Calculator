using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Library
{
    public class CalculatorService
    {
        public int Sum(int x, int y)
        {
            return x + y;
        }

        public int Minus(int x, int y)
        {
            return x - y;
        }

        public int Multiply(int x, int y)
        {
            return x * y;
        }

        public int Divide(int x, int y)
        {
            return (x / y);
        }
    }
}
