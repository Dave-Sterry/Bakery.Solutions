using System;
using Bakery.Models;


public class Customer
{

  static void Main()
  {
    Console.WriteLine("Welcome to Pierre's Bakery!");
    Console.WriteLine("---------------------------");
    Console.WriteLine("We have bread and pastries");
    Console.WriteLine("What would you like to order? [Enter 'bread' for bread, 'pastries' for pastries 'both' if you want to order both]");
    string answer = Console.ReadLine();
    if (answer == "bread")
    {
      Console.WriteLine("How many loaves would you like?");
      string amount = Console.ReadLine();
    }
    else if (answer == "pastries")
    {
      Console.WriteLine("How many pastries would you like?");
      string amount = Console.ReadLine();
    }
    else if (answer == "both") ;
    {
      Console.WriteLine("How many loaves would you like?");
      string breads = Console.ReadLine();
      Console.WriteLine("How many pastries would you like?");
      string pastries = Console.ReadLine();
    }

  }
}