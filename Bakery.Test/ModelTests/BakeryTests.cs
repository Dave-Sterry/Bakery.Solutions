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
      Bread newOrder = new Bread(5);
      int result = newOrder.OrderTotal();
      Assert.AreEqual(17, result);
    }

  }

}
