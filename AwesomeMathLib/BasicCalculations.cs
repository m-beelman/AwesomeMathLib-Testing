using System;

namespace AwesomeMathLib
{
    public class BasicCalculations
    {
        public static int Add(int first, int second)
        {
            return first + second;
        }

        public static int Subtract(int first, int second)
        {
            return first - second;
        }

        public static int Multiply(int first, int second)
        {
            return first * second;
        }

        public static int Divide(int first, int second)
        {
            if (second == 0)
                throw new DivideByZeroException("Do not divide by zero!");
            
            return first / second;
        }
    }
}
