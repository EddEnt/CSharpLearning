using System.Diagnostics;

namespace CalculatorLibrary
{
    public class Calculator
    {

        public Calculator() 
        {
            StreamWriter logFile = File.CreateText("calculator.log");
            Trace.Listeners.Add(new TextWriterTraceListener(logFile));
            Trace.AutoFlush = true;
            Trace.WriteLine("Starting Calculator Log...");
            Trace.WriteLine(String.Format("Started at {0}", System.DateTime.Now.ToString()));
        }

        public double AddNumbers(double number1, double number2)
        {
            double calculatedResult = number1 + number2;
            Console.WriteLine($"{number1} + {number2} = {calculatedResult}.");
            Trace.WriteLine($"{number1} + {number2} = {calculatedResult}");
            return calculatedResult;
        }

        public double SubtractNumbers(double number1, double number2)
        {
            double calculatedResult = number1 - number2;
            Console.WriteLine($"{number1} - {number2} = {calculatedResult}");
            Trace.WriteLine($"{number1} - {number2} = {calculatedResult}");
            return calculatedResult;
        }

        public double MultiplyNumbers(double number1, double number2)
        {
            double calculatedResult = number1 * number2;
            Console.WriteLine($"{number1} * {number2} = {calculatedResult}");
            Trace.WriteLine($"{number1} * {number2} = {calculatedResult}");
            return calculatedResult;
        }

        public double DivideNumbers(double number1, double number2)
        {
            double calculatedResult = double.NaN;
            if (number2 != 0)
            {
                calculatedResult = number1 / number2;
            }
            Console.WriteLine($"{number1} / {number2} = {calculatedResult}");
            Trace.WriteLine($"{number1} / {number2} = {calculatedResult}");
            return calculatedResult;
        }

    }
}