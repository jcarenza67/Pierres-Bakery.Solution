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
      int freePastries = (eachPastryPrice / 4);
      PastryAmount = (eachPastryPrice - freePastries) * PastryPrice;
      return PastryAmount;
    }
  }
}