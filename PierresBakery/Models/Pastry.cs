using System;
using System.Collections;
using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Pastry
  {
    public int PastryPrice { get; set; }
    public int PastryAmount { get; set; }
    
    public Pastry(int eachPastryPrice)
    {
      PastryPrice = eachPastryPrice;
      PastryAmount = (PastryPrice / 3) * 2 * PastryPrice + (PastryPrice % 3) * PastryPrice;
    }
  }
}