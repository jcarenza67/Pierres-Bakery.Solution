using System;
using System.Collections;
using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Pastry
  {
    public int PastryPrice { get; set; }
    public int PastryAmount { get; set; }
    public Pastry(int pastryPrice)
    {
      PastryPrice = pastryPrice;
    }
    
    public int PastryOrder(int eachPastryPrice)
    {
      PastryAmount = (eachPastryPrice / 3) * 2 * PastryPrice + (eachPastryPrice % 3);
      return PastryAmount;
    }
  }
}