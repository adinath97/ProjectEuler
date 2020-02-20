using System;
using System.Numerics;

namespace ProjectEuler9
{
    class MainClass
    {
        public static BigInteger a = 3;
        public static BigInteger b = 3;
        public static BigInteger c = 4;
        public static BigInteger magicSum = 1000;
        public static bool keepIterating = true;
        public static bool foundIt = false;

        public static void Main(string[] args)
        {
            FindPythagoreanTriple();
        }

        public static void FindPythagoreanTriple()
        {
            while(foundIt == false)
            {
                keepIterating = true;
                c += 1;
                b = 3;
                /* if (keepIterating)
                {
                    Console.WriteLine("Hi");
                } */
                while (keepIterating == true)
                {
                    b += 1;
                    a = 3;
                    while (a <= b - 1 && b < c)
                    {
                        if(a == c - 2 && b == c - 1)
                        {
                            keepIterating = false;
                        }
                        if (a * a + b * b == c * c)
                        {
                            // Console.WriteLine("I got one! " + a + ", " + b + ", " + c + " works!");
                            if(a + b + c == magicSum)
                            {
                                Console.WriteLine("Found it! The triple consisting of " + a + ", " + b + ", " + c + " works!");
                                foundIt = true;
                                FindProduct(a, b, c);
                                break;
                            }
                        }
                        /* else
                        {
                            Console.WriteLine("Nope, " + a + ", " + b + ", " + c + " doesn't work");
                        } */
                        a++;
                    }
                }
            }
        }

        public static void FindProduct(BigInteger x, BigInteger y, BigInteger z)
        {
            BigInteger product = x * y * z;
            Console.WriteLine("The product of those three numbers is " + product + ".");
        }
    }
}
