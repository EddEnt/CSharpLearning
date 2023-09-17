using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorLibrary;

namespace CalculatorConsole
{
    public class CalculatorProgram
    {
        public static void RunCalculator()
        {
            bool endApplication = false;

            Calculator calculator = new Calculator();

            while (!endApplication) 
            { 

                string? inputNumber1, inputNumber2;
                double validNumber1 = 0, validNumber2 = 0;
                double result = 0;
                string operationSelection;

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

                Console.WriteLine($"Number 1: {validNumber1} Number 2: {validNumber2}");
                Console.WriteLine("-----------------------");

                Console.WriteLine("Please select an operation to be performed from the following.");
                Console.WriteLine("Once you have made a selection, press any key to perform another calculation...");

                Console.WriteLine("\t a - Addition");
                Console.WriteLine("\t s - Subtraction");
                Console.WriteLine("\t m - Multiplication");
                Console.WriteLine("\t d - Division");
                Console.WriteLine("\t n - Exit Application");

                Console.Write("Selection: ");
                operationSelection = Console.ReadLine();

                switch (operationSelection)
                {
                    case "a":
                        result = calculator.AddNumbers(validNumber1, validNumber2);
                        break;

                    case "s":
                        result = calculator.SubtractNumbers(validNumber1, validNumber2);
                        break;

                    case "m":
                        result = calculator.MultiplyNumbers(validNumber1, validNumber2);
                        break;

                    case "d":
                        result = calculator.DivideNumbers(validNumber1, validNumber2);
                        if (double.IsNaN(result))
                        {
                            Console.WriteLine("Sorry, the provided numbers result in a mathematical error");
                        }
                        else
                        {
                            Console.WriteLine("Valid division!");                        }

                        break;
                        

                    case "n":
                        endApplication = true;
                        break;

                    default:
                        break;
                }
                Console.ReadKey();
            }
        }
    }
}
