﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsole.CalculatorOperations
{
    public class Addition
    {
        public static double AddNumbers(double number1, double number2 )
        {
            double calculatedResult = number1 + number2;
            Console.WriteLine($"{number1} + {number2} = {calculatedResult}.");
            return calculatedResult;
        }
    }
}
