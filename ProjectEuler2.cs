/* need while loop instead of do-while loop */
using System;
using System.Collections.Generic;
using System.Linq;

class HelloWorld {
    
    public static int test = 4000000;
    public static List<int> allFibonacciLessThanTest = new List<int>();
    public static List<int> allEvenFibonacciLessThanTest = new List<int>();
    
    static void Main() 
    {
        GenerateAllFibonacciLessThanTest();
        ParseOutEvenFibNumbers();
        SumAllEvenFibNumbers();
    }
    
    public static void GenerateAllFibonacciLessThanTest() 
    {
        allFibonacciLessThanTest.Add(1);
        allFibonacciLessThanTest.Add(2);
        int k = 0;
        
        while(k < test)
        {
        int i = allFibonacciLessThanTest[allFibonacciLessThanTest.Count - 1];
        int j = allFibonacciLessThanTest[allFibonacciLessThanTest.Count - 2];
        k = i + j;
        allFibonacciLessThanTest.Add(k); 
        }
        
        if(allFibonacciLessThanTest[allFibonacciLessThanTest.Count - 1] > test)
        {
        allFibonacciLessThanTest.RemoveAt(allFibonacciLessThanTest.Count - 1);
        }

    }
    
    public static void ParseOutEvenFibNumbers() {
        foreach(int x in allFibonacciLessThanTest) 
        {
            if(x % 2 == 0) 
            {
                allEvenFibonacciLessThanTest.Add(x);
            }
        }
        
        /* Console.WriteLine("Presenting even fib #s less than " + test + ":");
        
        foreach(int x in allEvenFibonacciLessThanTest) 
        {
            Console.Write(x + ",");
        } */
    }
    
    public static void SumAllEvenFibNumbers() 
    {
        Console.WriteLine("And the sum of all even fibonacci numbers less than " + test + " is:");
        int sum = allEvenFibonacciLessThanTest.Sum(x => Convert.ToInt32(x));
        Console.Write(sum);
    }
}