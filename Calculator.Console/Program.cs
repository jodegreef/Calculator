using Calculator.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var calc = new CalculatorService();

            System.Console.WriteLine(calc.Sum(1, 1));
        }
    }
}
