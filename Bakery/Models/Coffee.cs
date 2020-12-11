using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Coffee
  {
    public int CoffeeOrder { get; set; }
    //public int CoffeePrice { get; set; }
    public Coffee(int order)
    {
      CoffeeOrder = order;
      //CoffeePrice = order * 3;
    }
    public int Ordertotal()
    {
      if (CoffeeOrder >= 10)
      {
        int totalPrice = CoffeeOrder * 2;
        return totalPrice;
      }
      else
      {
        return CoffeeOrder * 3;
      }
    }
  }
}