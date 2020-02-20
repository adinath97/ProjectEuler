using System;
using System.Numerics;

namespace ProjectEuler16
{
    class MainClass
    {

        public static void Main(string[] args)
        {
            FindValue();
        }

        public static void FindValue()
        {
            BigInteger result = BigInteger.Pow(2, 1000);
            Console.WriteLine(result);
            Console.WriteLine("All good so far");
            BigInteger sum = 0;
            while (result != 0)
            {
                sum += result % 10;
                result /= 10;
            }
            Console.WriteLine("Sum of the digits of the said integer: " + sum);
        }

    }
}
