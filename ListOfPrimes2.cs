using System;
using System.Collections.Generic;
using System.Numerics;

namespace projectEuler3
{
    class MainClass
    {
        public static List<BigInteger> SieveStarterPack = new List<BigInteger>();
        public static BigInteger test = 1000;
        public static BigInteger prime;
        public static int iteration;
        public static bool allPrimes = false;
        public static bool atLeastOne = false;

        public static void Main(string[] args)
        {
            CreateCandidates(test);
            Sieve();
            foreach(BigInteger x in SieveStarterPack)
            {
                Console.Write(x + " , ");
            }
            Console.WriteLine("   ");
            Console.WriteLine("    ");
            Console.WriteLine(SieveStarterPack.Count);
        }

        public static void CreateCandidates(BigInteger input)
        {
            for(BigInteger x = 2; x < test; x++)
            {
                SieveStarterPack.Add(x);
            }
        }

        public static void Sieve()
        {
            iteration = 0;

            while (allPrimes == false)
            {
                atLeastOne = false;
                prime = SieveStarterPack[iteration];
                for (int index = SieveStarterPack.Count - 1; index > iteration; index--)
                {
                    if (SieveStarterPack[index] % prime == 0)
                    {
                        SieveStarterPack.RemoveAt(index);
                        atLeastOne = true;
                    }
                }
                iteration++;

                if(atLeastOne == false)
                {
                    allPrimes = true;
                }
            }
        }      
    }
}
