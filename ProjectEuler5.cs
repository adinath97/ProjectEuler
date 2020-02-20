using System;

class HelloWorld {
    
    public static int test = 11;
    public static bool stop = false;
    
    public static void Main() 
    {
    TheSearchIsOn();
    }
    
    public static void TheSearchIsOn() 
    {
        while(stop == false) 
        {
        for(int i = 1; i < 21; i++) 
        {
            if(!(test % i == 0))
             {
                break;
             }
            else if((test % i == 0) && (i == 20)) 
             {
                Console.WriteLine("Found it! The magic number is " + test);
             }
        }
        
        if((test % 2 == 0) && (test % 3 == 0) && (test % 4 == 0) && (test % 5 == 0) && (test % 6 == 0)
        && (test % 7 == 0) && (test % 8 == 0) && (test % 9 == 0) && (test % 10 == 0) && (test % 11 == 0)
        && (test % 12 == 0) && (test % 13 == 0) && (test % 14 == 0) && (test % 15 == 0) && (test % 16 == 0) 
        && (test % 17 == 0) && (test % 18 == 0) && (test % 19 == 0) && (test % 20 == 0)) 
            {
              stop = true;
            }
        
        test = test + 1;
    }
    }

}