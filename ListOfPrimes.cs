/* Still need to find a way to get user input */

using System;
using System.Collections.Generic;

class HelloWorld {

    public static int test = 1000;
    public static List<int> candidatesForPrimesTest = new List<int>();
    public static List<int> composites = new List<int>();
    public static List<int> primes = new List<int>();
    
  static void Main() 
  {
    CandidatesForPrimesTest();
    PrimalityTest();
    PrintPrimes();
  }
  
 public static void CandidatesForPrimesTest() 
  {
    for(int index1 = 2; index1 < test; index1 ++) 
    {
        candidatesForPrimesTest.Add(index1);
    }
  }
  
 public static void PrimalityTest() 
  {
    foreach(int element in candidatesForPrimesTest)
    {
        if(!(element == 2)) 
        {
            for(int index = 2; index < element; index++) 
          {
              if(element % index == 0) 
              {
                  composites.Add(element);
                  break;
              }
              else if(!(element % index == 0) && (index == element - 1)) 
              {
                  primes.Add(element);
              }
          }
        }
    }
  }

  public static void PrintCandidatesForPrimes()
  {
    Console.Write("Candidates for primes less than " + test + ": ");
    foreach(int x in candidatesForPrimesTest) 
    {
      Console.Write(x + ",");
    }
    
    Console.WriteLine("...and that's it!");
  }
  
  public static void PrintPrimes() 
  {
    Console.Write("Primes less than " + test + " are: ");
    foreach(int x in primes) 
    {
      Console.Write(x + ",");
    } 
  }
}