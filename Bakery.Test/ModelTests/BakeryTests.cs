using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void OrderCost_GetsOrderDealTotal_Int()
    {
      int breadOrder = 6;
      Bread newOrder = new Bread(breadOrder);
      int result = newOrder.OrderTotal();
      Assert.AreEqual(20, result);
    }

    [TestMethod]
    public void OrderCost_GetsNoDealOrderTotal_Int()
    {
      int breadOrder = 1;
      Bread newOrder = new Bread(breadOrder);
      int result = newOrder.OrderTotal();
      Assert.AreEqual( 5, result);
    }

    [TestClass]
    public class PastryTests
    {
      [TestMethod]
      public void OrderCost_GetsPastryTotal_Int()
      {
        int pastryOrder = 1;
        Pastry newOrder = new Pastry(pastryOrder);
        int result  = newOrder.OrderTotal();
        Assert.AreEqual( 2, result);
        }
    }

    [TestMethod]
    public void OrderCost_GetsPastryDealTotal_Int()
    {
      int pastryOrder = 3;
      Pastry newOrder = new Pastry(pastryOrder);
      int result  = newOrder.OrderTotal();
      Assert.AreEqual( 5, result);
    }

    

    [TestClass]
    public class CoffeeTests
    {
      [TestMethod]
      public void CoffeeCost_GetsCoffeeTotal_Int()
      {
        int coffeeOrder = 12;
        Coffee newOrder = new Coffee(coffeeOrder);
        int result = newOrder.Ordertotal();
        Assert.AreEqual(24, result);
      }
    }

  }

}
