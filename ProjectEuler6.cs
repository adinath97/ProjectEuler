using System;

class HelloWorld {
    public static long maxValue = 101;
    public static long squareOfSum;
    public static long sumOfSquares;
    
    public static void Main() {
       SumOfSquares();
       SquareOfSum();
       Difference();}
    
    public static void SumOfSquares() {
        
        sumOfSquares = 0;
        
        for(long i = 1; i < maxValue; i++) 
        {
            sumOfSquares += i*i;
        }
        
        Console.WriteLine("The sum of squares from 1 to " + (maxValue - 1) + " is : " + sumOfSquares);}
    
    public static void SquareOfSum() {
        long sum = 0;
        
        for(long i = 1; i < maxValue; i++) 
        {
            sum += i;
        }
        
        squareOfSum = sum*sum;
        
        Console.WriteLine("The square of the sum from 1 to " + (maxValue - 1) + " is: " + squareOfSum);}
    
    public static void Difference() {
        long difference = squareOfSum - sumOfSquares;
        Console.WriteLine("The difference between the square of the sum from 1 to " + (maxValue - 1) +
        " and the sum of the squares is " + difference);}
    
}