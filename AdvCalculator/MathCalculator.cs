using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvCalculator
{
    public class MathCalculator : Calculator
    {
        public int GetFactorial(int number)
        {
            int result = 1;
            for(int i = 1; i < number; i++)
            {
                result *= i;
            }
            return result;
        }
        public bool GetPrimeCheck(int number)
        {
            bool isPrime = true;
            for (int i = 2; i < number; i++)
            {
                if(number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            return isPrime;
        }
        public int GetPower(int number1, int number2)
        {
            int result = 1;
            for(int i = 1; i < number2;i++)
            {
                result *= number1;
            }
            return result;
        }
        public double GetArrayAverage(double[] number)
        {
            double result = 0;

            for (int i = 0; i < number.Length; i++)
            {
                result += number[i];
            }
            result /= number.Length;

            return result;
        }

        public int GetMinNumber(int[] array)
        {
            int min = int.MaxValue;
            foreach (var i in array)
            {
                if (i < min)
                {
                    min = i;
                }
            }
            return min;
        }

        public int GetMaxNumber(int[] array)
        {
            int max = int.MinValue;
            foreach (var i in array)
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
