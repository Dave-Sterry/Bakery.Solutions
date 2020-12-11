using System;
using Bakery.Models;


public class Customer
{

  static void Main()
  {
    Console.WriteLine("Welcome to Pierre's Bakery!");
    Console.WriteLine("---------------------------");
    Console.WriteLine("Hello fellow gluten lover! We have bread and pastries");
    Console.WriteLine("Today our bread is $5 or you can buy 2 and get 1 free!");
    Console.WriteLine("Our pastries today are $2 or 3 for $5");
    Console.WriteLine("How many loaves of bread can I get you today?");
    int loaves = int.Parse(Console.ReadLine());
    Console.WriteLine($"{loaves} loaves eh? How many delicious pastries can I add to your order today?");
    int sweets = int.Parse(Console.ReadLine());

    Bread loafOrder = new Bread(loaves);
    Pastry sweetOrder = new Pastry(sweets);

    Console.WriteLine($"Ok that's {loaves} loaves of bread, and {sweets} pastries");
    Console.WriteLine($"Your order total is ${loafOrder.OrderTotal() + sweetOrder.OrderTotal()}");
  }
}