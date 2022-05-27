namespace AdvCalculator
{
    public class Calculator
    {
        public int Add(int number1, int number2) => number1 + number2;
        public int Subtract(int number1, int number2) => number1 - number2;
        public int Multiply(int number1, int number2) => number1 * number2;
        public int Divide(int number1, int number2) => number1 / number2;
        public int Factorial(int number1, int number2)
        {
            if (number1 == 1)
            {
            Console.WriteLine(" 1! = 1");
            }
        else
        {
            while (number1 != 1)
            {
                number2 = number2 * number1;
                number1 = number1 - 1;
            }

        }
            return number2;
        }

    }
}
