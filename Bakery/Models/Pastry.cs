using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Pastry
  {
    public int PastryOrder { get; set; }
    //public int PastryPrice { get; set; }
    public Pastry(int order)
    {
      PastryOrder = order;
      //PastryPrice = order * 2;
    }

    public int OrderTotal()
    {
      if (PastryOrder % 3 == 0)
      {
        int price = (PastryOrder / 3) * 5;
        return price;
      }
      else if (PastryOrder % 3 > 0 && PastryOrder > 3)
      {
        int price = ((PastryOrder / 3) * 5) + ((PastryOrder % 3) * 2);
        return price;
      }
      else
      {
        return PastryOrder * 2;
      }
    }
  }
}

