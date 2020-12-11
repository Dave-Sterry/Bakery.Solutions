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
      Bread newOrder = new Bread(9);
      int result = newOrder.OrderTotal();
      Assert.AreEqual(30, result);
    }

    [TestClass]
    public class PastryTests
    {
      [TestMethod]
      public void OrderCost_GetsPastryTotal_Int()
      {
        Pastry newOrder = new Pastry(1);
        int result = newOrder.OrderTotal();
        Assert.AreEqual(2, result);
      }
    }

    [TestClass]
    public class CoffeeTests
    {
      [TestMethod]
      public void CoffeeCost_GetsCoffeeTotal_Int()
      {
        Coffee newOrder = new Coffee(11);
        int result = newOrder.Ordertotal();
        Assert.AreEqual(22, result);
      }
    }

  }

}
