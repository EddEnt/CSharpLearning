using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsole.CalculatorOperations
{
    public class Division
    {
        public static double DivideNumbers(double number1, double number2)
        {
            double calculatedResult = double.NaN;
            if (number2 != 0)
            {
                calculatedResult = number1 / number2;
            }
            return calculatedResult;
        }
    }
}
