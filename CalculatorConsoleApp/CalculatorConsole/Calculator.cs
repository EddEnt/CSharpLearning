using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsole
{
    public class Calculator
    {
        public static void RunCalculator()
        {
            string? inputNumber1, inputNumber2;
            double validNumber1 = 0, validNumber2 = 0;
            double result = 0;

            Console.Write("Please enter your first number: ");
            inputNumber1 = Console.ReadLine();
            
            while (!double.TryParse(inputNumber1, out validNumber1))
            {
                Console.Write("Sorry, that was not a valid number. Please try again: ");
                inputNumber1 = Console.ReadLine();
            }

            Console.Write("Please enter your second number: ");
            inputNumber2 = Console.ReadLine();

            while (!double.TryParse(inputNumber2 , out validNumber2)) 
            {
                Console.Write("Sorry, that was not a valid number. Please try again: ");
                inputNumber2 = Console.ReadLine();
            }

            Console.Clear();
            Console.WriteLine($"Number 1: {validNumber1} Number 2: {validNumber2}");
            Console.WriteLine("-----------------------");

            return;
        }
    }
}
