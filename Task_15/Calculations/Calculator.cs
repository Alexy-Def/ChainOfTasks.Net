using System;

namespace Calculations
{
    public static class Calculator
    {
        public static double GetSumOne(int n)
        {
            double result = 0;

            for (double i = 0; i < n; i++)
            {
                result += 1 / (i + 1);
            }

            return result;
        }

        public static double GetSumTwo(int n)
        {
            double result = 0;

            for (double i = 1; i < n + 1; i++)
            {
                result += Math.Pow(-1, i + 1) / (i * (i + 1));
            }

            return result;
        }

        public static double GetSumThree(int n)
        {
            double result = 0;

            for (int i = 1; i < n + 1; i++)
            {
                result += 1 / Math.Pow(i, 5);
            }

            return result;
        }

        public static double GetSumFour(int n)
        {
            double result = 0;
            int i = 1;
            n++;

            while (i < n)
            {
                result += 1 / Math.Pow((2 * i) + 1, 2);
                i++;
            }

            return result;
        }

        public static double GetProductOne(int n)
        {
            double result = 1;
            n++;

            for (double i = 1; i < n; i++)
            {
                result *= 1 + (1 / (i * i));
            }

            return result;
        }

        public static double GetSumFive(int n)
        {
            double result = 0;
            n++;

            for (int i = 1; i < n; i++)
            {
                result += Math.Pow(-1, i) / ((2 * i) + 1);
            }

            return result;
        }

        public static double GetSumSix(int n)
        {
            double factorialResult = 1;
            double divisionResult = 1;
            double result = factorialResult / divisionResult;
            n++;

            for (double i = 2; i < n; i++)
            {
                factorialResult *= i;
                divisionResult += 1 / i;
                result += factorialResult / divisionResult;
            }

            return result;
        }

        public static double GetSumSeven(int n)
        {
            double result = Math.Sqrt(2);

            for (int i = 1; i < n; i++)
            {
                result = Math.Sqrt(2 + result);
            }

            return result;
        }

        public static double GetSumEight(int n)
        {
            double sinSum = 0;
            double result = 0;
            n++;

            for (int i = 1; i < n; i++)
            {
                sinSum += Math.Sin(i * Math.PI / 180);
                result += 1 / sinSum;
            }

            return result;
        }
    }
}
