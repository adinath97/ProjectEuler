using System;
using System.Collections.Generic;
using System.Numerics;
using System.Linq;


namespace ProjectEuler21
{
    class MainClass
    {
        public static List<BigInteger> ProperDivisors1 = new List<BigInteger>();
        public static List<BigInteger> ProperDivisors2 = new List<BigInteger>();
        public static List<BigInteger> AmicableNumbersRepeats = new List<BigInteger>();
        public static List<BigInteger> AmicableNumbersNoRepeats = new List<BigInteger>();
        public static BigInteger numberOfAmicablePairs = 0;
        public static BigInteger sum1 = 0;
        public static BigInteger sum2 = 0;
        public static BigInteger sumInput = 0;
        public static BigInteger max = 10000;
        public static BigInteger finalSum = 0;
        public static bool allCleared = false;

        public static void Main(string[] args)
        {
            FindAmicablePair();

        }

        public static void FindAmicablePair()
        {
            // Integer #1
            // for each integer from one onwards till (designated upper limit). For each integer i:
            for (BigInteger i = 2; i < max; i++)
            {
                while(allCleared == false)
                {

                    //make list empty again so we can repeat this process for a new int#1
                    ProperDivisors1.Clear();
                    allCleared = true;
                }

                while(allCleared == true)
                {
                    // find proper divisors of i
                    for (BigInteger j = 1; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            ProperDivisors1.Add(j);
                        }
                    }

                    // sum up all proper divisors of i
                    foreach (BigInteger x in ProperDivisors1)
                    {
                        sum1 += x;
                    }

                    if (sum1 > 1)
                    {
                        // find the sum of the proper divisors of sum1, then store that value in 'sum2'.
                        sum2 = SumOfProperDivisors(sum1);
                    }
                    else if (sum1 == 1)
                    {
                        sum2 = 0;
                    }

                    // check if sums match
                    if (i == sum2 && !(i == sum1))
                    {
                        Console.WriteLine("For index " + i + ", the sum (sum1) of its proper divisors is " + sum1 + "" +
                        " and the sum (sum2) of the divisors of sum1 is " + sum2);
                        numberOfAmicablePairs += 1;
                        AmicableNumbersRepeats.Add(i);
                        AmicableNumbersRepeats.Add(sum1);
                        //reset the sum
                        sum1 = 0;
                        allCleared = false;
                        break;
                    }
                    else if (!(i == sum2))
                    {
                        //reset the sum
                        sum1 = 0;
                        allCleared = false;
                        break;
                    }

                }
            }

            AmicableNumbersNoRepeats = AmicableNumbersRepeats.Distinct().ToList();

            Console.WriteLine("The number of amicable pairs is: " + numberOfAmicablePairs);

            foreach(BigInteger x in AmicableNumbersNoRepeats)
            {
                finalSum += x;
            }

            Console.WriteLine("Sum of all amicable numbers below 10,000 is: " + finalSum);
        }

        // find the divisors of sum1, sum them up to form sum2, and check if sum2 = sum1.
        private static BigInteger SumOfProperDivisors(BigInteger input)
        {
            // go through values from 1 up till the input, and see if they are divisors of the input
            for(BigInteger i = 1; i < input; i++)
            {
                //if i is a (proper) divisor of the input, then add it to an array of divisors.
                if(input % i == 0)
                {
                    ProperDivisors2.Add(i);
                }
            }

            sumInput = 0;

            //once you have the list of proper divisors, add up the divisors
            foreach(BigInteger x in ProperDivisors2)
            {
                sumInput += x;
            }

            //make the array empty again so we can take in a new input
            ProperDivisors2.Clear();

            //return the sum of the proper divisors of input
            return sumInput;
        }
    }
}
