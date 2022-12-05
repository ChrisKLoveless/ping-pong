using System;
using System.Collections.Generic;


public class Program
{
  public static void Main()
  {
    Console.WriteLine("Input a number: ");
    string stringInput = Console.ReadLine();
    int numInput = int.Parse(stringInput);

    for (int i = 1; i <= numInput; i++)
    {
      if(i % 3 == 0 && i % 5 == 0)
      {
        Console.WriteLine("Ping-Pong!");
      }
      else if(i % 3 == 0)
      {
        Console.WriteLine("Ping!");
      }
      else if(i % 5 == 0)
      {
        Console.WriteLine("Pong!");
      }
      else
      {
        Console.WriteLine(i);
      }
    }
  }
}