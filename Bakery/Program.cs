using System;
using Bakery.Models;


public class Customer
{

  static void Main()
  {
    Console.WriteLine("Welcome to Pierre's Bakery!");
    Console.WriteLine("---------------------------");
    Console.WriteLine("Hello fellow gluten lover! We have bread and pastries");
    Console.WriteLine("How many loaves of bread can I get you today?");
    int loaves = int.Parse(Console.ReadLine());
    Console.WriteLine($"{loaves} loaves eh? How many delicious pastries can I add to your order today?");
    int sweets = int.Parse(Console.ReadLine());

    Bread loafOrder = new Bread(loaves);
    Pastry sweetOrder = new Pastry(sweets);

    Console.WriteLine($"Ok that's {loaves} loaves of bread, and {sweets} pastries");
    Console.WriteLine($"Your order total is ${loafOrder.OrderTotal() + sweetOrder.OrderTotal()}");





    // string answer = Console.ReadLine();
    // if (answer == "bread")
    // {
    //   Console.WriteLine("How many loaves would you like?");
    //   int loaves = int.Parse(Console.ReadLine());

    //   Bread loafOrder = new Bread(loaves);
    //   Console.WriteLine(loafOrder.OrderTotal());
    // }
    // else if (answer == "pastries")
    // {
    //   Console.WriteLine("How many pastries would you like?");
    //   int amount = int.Parse(Console.ReadLine());

    //   Pastry sweetOrder = new Pastry(amount);
    // }
    // else if (answer == "both") ;
    // {
    //   Console.WriteLine("How many loaves would you like?");
    //   int breads = int.Parse(Console.ReadLine());
    //   Console.WriteLine("How many pastries would you like?");
    //   int pastries = int.Parse(Console.ReadLine());
    // }

  }
}