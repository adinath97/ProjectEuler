using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler23
{
    /* Game plan:
    Determine if a number can be expressed as the sum of two abundant numbers. Instead of checking all possible
    numbers that sum to a number, then checking if each of those is abundant, I can simply come up with a list
    of abundant numbers below 28123, and consider all distinct sums created when I add any two elements of that list.
    Now come up with a list of all those sums(where the sum is below 28123), add them to a list of numbers that can be expressed as the sum of two
    abundant numbers. Next, go from 2 to 28123, and add to a new list all numbers that are not in that list. Lastly,
    sum the elements of that new list.*/

    //code took 1 min 15 secs to run. Need to trim it down to run within 1 min

    class MainClass
    {
        public static BigInteger biSum = 0;
        public static BigInteger upperLimit = 28123;
        public static BigInteger sumOfProperDivisors = 0;
        public static BigInteger numberOfNAS = 0;
        public static BigInteger numberofAS = 0;
        public static BigInteger ultimateSum = 0;
        public static List<BigInteger> properDivisors = new List<BigInteger>();
        public static List<BigInteger> abundantNumbers = new List<BigInteger>();
        public static List<BigInteger> allPossibleSumsOfAbundantNumbers = new List<BigInteger>();
        public static List<BigInteger> finalAllPossibleSumsOfAbundantNumbers = new List<BigInteger>();
        public static List<BigInteger> allNumbersThatCannotBeEpxressedAsASumOfTwoAbundantNumbers = new List<BigInteger>();


        public static void Main(string[] args)
        {
            FindAllAbundantNumbers();
            FindAllPossibleSumsOfAbundantNumbers();
            FindAllNumbersThatCannotBeExpressedAsASumOfTwoAbundantNumbers();
            SumAllNumbersThatCannotBeExpressedAsASumOfTwoAbundantNumbers();
        }

        public static void FindAllAbundantNumbers()
        {
            //for each integer (call each i) up till the upperLimit
            for(BigInteger i = 2; i < upperLimit; i++)
            {
                //look for proper divisors, and put them in a list
                for(BigInteger j = 1; j < i; j++)
                {
                    if(i % j == 0)
                    {
                        properDivisors.Add(j);
                    }
                }

                //find the sum of the proper divisors
                foreach(BigInteger x in properDivisors)
                {
                    sumOfProperDivisors += x;
                }

                //if the sum of proper divisors exeeds i, then add i to the list of abundant numbers
                if(sumOfProperDivisors > i)
                {
                    abundantNumbers.Add(i);
                }

                sumOfProperDivisors = 0;
                properDivisors.Clear();
            }

            /* foreach(BigInteger x in abundantNumbers)
            {
                Console.Write(x + ", ");
            }*/
        }

        public static void FindAllPossibleSumsOfAbundantNumbers()
        {
            foreach(BigInteger x in abundantNumbers)
            {
                foreach(BigInteger y in abundantNumbers)
                {
                    biSum = x + y;
                    if(biSum < upperLimit)
                    {
                        allPossibleSumsOfAbundantNumbers.Add(biSum);
                    }
                    biSum = 0;
                }
            }

            finalAllPossibleSumsOfAbundantNumbers = allPossibleSumsOfAbundantNumbers.Distinct().ToList();
            /* numberofAS = finalAllPossibleSumsOfAbundantNumbers.Count;

            Console.WriteLine("Number of numbers that can be expressed as a sum of two abundant numbers: " + numberofAS); */
            // Console.WriteLine("And now all possible sums: ");

            /* foreach(BigInteger x in finalAllPossibleSumsOfAbundantNumbers)
            {
                Console.Write(x + ", ");
            } */
        }

        public static void FindAllNumbersThatCannotBeExpressedAsASumOfTwoAbundantNumbers()
        {
            for(BigInteger i = 2; i < upperLimit; i++)
            {
                if(!(finalAllPossibleSumsOfAbundantNumbers.Contains(i) == true))
                {
                    allNumbersThatCannotBeEpxressedAsASumOfTwoAbundantNumbers.Add(i);
                    //numberOfNAS += 1;
                }
            }

           //Console.WriteLine("Number of numbers that can't be expressed as a sum of two abundant numbers: " + numberOfNAS);
           // Console.WriteLine("Numbers that can't be expressed as a sum of two abundant numbers: ");

            /* foreach (BigInteger x in allNumbersThatCannotBeEpxressedAsASumOfTwoAbundantNumbers)
            {
                Console.Write(x + ", ");
            } */
        }

        public static void SumAllNumbersThatCannotBeExpressedAsASumOfTwoAbundantNumbers()
        {
            ultimateSum = 1;

            foreach(BigInteger x in allNumbersThatCannotBeEpxressedAsASumOfTwoAbundantNumbers)
            {
                ultimateSum += x;
            }

            Console.WriteLine("And the sum you're looking for is: " + ultimateSum);
        }
    }
}
