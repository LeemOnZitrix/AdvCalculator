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
        public bool PrimeCheck(int number1)
        {
            int number2; bool isprime = true;
            number2 = number1 / 2;
            for (int i = 2; i < number2; i++)
            {
                if (number1 % i == 0)
                {
                    isprime = true;
                    return isprime;
                }
                if (number1 % i != 0)
                {
                    isprime = false;
                    return isprime;

                }
                
            }
            return isprime;     
        }
        public int Power(int number1)
        {
            number1 *= number1;
            return number1;
        }
        public double Arrayaverage(double numberscount, double[] number1)
        {
            double average = 0;
          

            for (int i = 0; i < number1.Length; i++)
            {
                average += number1[i];
            }
            average /= numberscount;

            return average;
        }

        public int findMin(int[] arrayminmax)
        {           
            int min = int.MaxValue;
            foreach (var i in arrayminmax)
            {
                if (i < min)
                {
                    min = i;
                }
            }
            return min;
        }

        public int findMax(int[] arrayminmax)
        {
            int max = int.MinValue;
            foreach (var i in arrayminmax)
            {
                if (i > max)
                {
                    max = i;
                }
            }
            return max;
        }

    }
}
