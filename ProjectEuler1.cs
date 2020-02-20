    
    public static int index;
    public static int sum = 0;
    
  public static void Main() 
  {
    FindAndSumTheMultiples();
  }
  
  public static void FindAndSumTheMultiples() 
  {
      for(index = 1; index < 1000; index ++)
      {
        if(index % 3 == 0 || index % 5 == 0)
        {
            sum += index;
        }
      }
    Console.WriteLine(sum);
  }
