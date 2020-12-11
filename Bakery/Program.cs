using System;
using Bakery.Models;


public class Customer
{
  static void Main()
  {
    Console.WriteLine("Welcome to Pierre's Bakery!");
    Console.WriteLine("---------------------------");
    Console.WriteLine("Hello fellow gluten lover! We have bread and pastries for sale today");
    Console.WriteLine("Today our bread is $5 or you can buy 2 and get 1 free!");
    Console.WriteLine("Our pastries today are $2, or 3 for $5");
    Console.WriteLine("How many loaves of bread can I get you today?");
    int loaves = int.Parse(Console.ReadLine());
    Console.WriteLine($"{loaves} loaves eh? How many delicious pastries can I add to your order today?");
    int sweets = int.Parse(Console.ReadLine());
    Console.WriteLine("I forgot to mention we have coffee! Its $3 a cup, unless you buy more than 10cups and then its $2 a cup");
    Console.WriteLine("How many cups of coffee would you like to add to your order?");
    int coffees = int.Parse(Console.ReadLine());

    Bread loafOrder = new Bread(loaves);
    Pastry sweetOrder = new Pastry(sweets);
    Coffee javaOrder = new Coffee(coffees);

    Console.WriteLine($"Ok that's {loaves} loaves of bread, {sweets} pastries and {coffees} cups of coffee");
    Console.WriteLine($"Your order total is ${loafOrder.OrderTotal() + sweetOrder.OrderTotal() + javaOrder.Ordertotal()} I hope to see you again soon!");
  }
}