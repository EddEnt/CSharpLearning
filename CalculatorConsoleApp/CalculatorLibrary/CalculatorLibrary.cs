namespace CalculatorLibrary
{
    public class CalculatorLibrary
    {

        public static double AddNumbers(double number1, double number2)
        {
            double calculatedResult = number1 + number2;
            Console.WriteLine($"{number1} + {number2} = {calculatedResult}.");
            return calculatedResult;
        }

        public static double SubtractNumbers(double number1, double number2)
        {
            double calculatedResult = number1 - number2;
            Console.WriteLine($"{number1} - {number2} = {calculatedResult}");
            return calculatedResult;
        }

        public static double MultiplyNumbers(double number1, double number2)
        {
            double calculatedResult = number1 * number2;
            Console.WriteLine($"{number1} * {number2} = {calculatedResult}");
            return calculatedResult;
        }

        public static double DivideNumbers(double number1, double number2)
        {
            double calculatedResult = double.NaN;
            if (number2 != 0)
            {
                calculatedResult = number1 / number2;
            }
            Console.WriteLine($"{number1} / {number2} = {calculatedResult}");
            return calculatedResult;
        }

    }
}