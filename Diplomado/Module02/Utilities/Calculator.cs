using System;

namespace Utilities
{
    public class Calculator
    {
        public int Sum(int x, int y)
        {
            return x + y;
        }

        public int Subtract(int x, int y)
        {
            return x - y;
        }

        public int Multiply(int x, int y)
        {
            return x * y;
        }

        public int Divide(int x, int y)
        {
            if (y == 0)
            {
                throw new ArgumentException("Parameter y (divider) cannot be zero.");
            }

            return x / y;
        }
    }
}
