using System;
using System.Numerics;

namespace ProjectEuler20
{
    class MainClass
    {
        public static BigInteger factorial;
        public static BigInteger Value = 100;

        public static void Main(string[] args)
        {
            FindFactorial();
            FindSum(factorial);
        }

        public static BigInteger FindFactorial()
        {
            factorial = 1;
            for(BigInteger i = 1; i <= Value; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
        
        public static void FindSum(BigInteger value)
        {
            Console.WriteLine(value);
            Console.WriteLine("All good so far");
            BigInteger sum = 0;
            while (value != 0)
            {
                sum += value % 10;
                value /= 10;
            }
            Console.WriteLine("Sum of the digits of the said integer: " + sum);
        }
    }
}
