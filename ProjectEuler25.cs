using System;
using System.Numerics;
using System.Collections.Generic;

namespace ProjectEuler25
{
    class MainClass
    {
        public static BigInteger currentFibNumber = 1;
        public static BigInteger fib1 = 1;
        public static BigInteger fib2 = 1;
        public static BigInteger upperLimit = 30;
        public static BigInteger numberOfDigits = 0;
        public static BigInteger digits = 0;
        public static BigInteger index = 2;
        public static bool foundIt = false;

        public static void Main(string[] args)
        {
            RunTheFibonacci();
        }

        public static void RunTheFibonacci()
        {
            while(foundIt == false)
            {
                currentFibNumber = fib1 + fib2;
                fib1 = fib2;
                fib2 = currentFibNumber;
                digits = NumberOfDigitsCalculator(currentFibNumber);
                index += 1;
                if(digits == 1000)
                {
                    Console.WriteLine(" The number with index " + index + " is the first number that contains " + digits + " digits.");
                    foundIt = true;
                }
            }
        }

        public static BigInteger NumberOfDigitsCalculator(BigInteger input)
        {
            List<BigInteger> listOfInts = new List<BigInteger>();
            while(input > 0)
            {
                listOfInts.Add(input % 10);
                input = input / 10;
            }
            numberOfDigits = listOfInts.Count;
            return numberOfDigits;
        }
    }
}
