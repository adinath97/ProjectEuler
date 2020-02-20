using System.Collections.Generic;

    public static int index;
    public static List<int> candidatesForPrimes = new List<int>();
    public static int test = 10;

static void Main() 
{
    CreateListOfCandidates();
    // PrintList();
    PrimalityTest();
    
}

public static void CreateListOfCandidates() 
{
	for(index = 2; index < test; index++) 
	{
		candidatesForPrimes.Add(index);
	}
}

public static void PrimalityTest() 
{
    foreach(int i in candidatesForPrimes)
    {
        if(test % i == 0)
        {
            Console.WriteLine(" " + test + " is a composite integer");
            break;
        }
        else if(!(test % i == 0) && i == test - 1)
        {
            Console.WriteLine(" " + test + " is a prime integer");
        }
    }

}

/* Still need to figure out an efficient way
how to accept user input for the test value, and
run functions that then proceed to test the
number. The code below works with regards to 
accepting user input, but can be cleaned up (needs
significant refactoring). The code above is neat
and re-factored, but doesn't accept user input. 
Need to find a way to bring the two together. Perhaps
I can use functions that accept arguments? Int
argument and List argument. */

    public static int index;
    public static List<int> candidatesForPrimes = new List<int>();
    public static int test;

static void Main() 
{
    Console.WriteLine("Enter candidate for primality testing: ");
    int test = Convert.ToInt32(Console.ReadLine());

	for(index = 2; index < test; index++) 
	{
		candidatesForPrimes.Add(index);
	}

    foreach(int i in candidatesForPrimes)
    {
        if(test % i == 0)
        {
            Console.WriteLine(" " + test + " is a composite integer");
            break;
        }
        else if(!(test % i == 0) && i == test - 1)
        {
            Console.WriteLine(" " + test + " is a prime integer");
        }
    }
}

