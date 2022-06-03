namespace AdvCalculator
{
    public class Calculator
    {
        private const bool V = true;

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
        public int PrimeCheck(int number1)
        {
            int number2, isprime;
            number2 = number1 / 2;
            for (int i = 2; i < number2; i++)
            {
                if (number1 % i == 0)
                {
                    return 1;
                }
                if (number1 % i != 0)
                {
                    return 2;
                }
                
            }
            return 0;     
        }
        public int Power(int number1)
        {
            number1 *= number1;
            return number1;
        }
        public int Arrayaverage(params int[] number1)
        {
            int average = 0;

            for (int i = 0; i < number1.Length; i++)
            {
                average += number1[i];
            }

            return average;
        }

    }
}
