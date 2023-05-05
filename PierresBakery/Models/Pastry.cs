using System;
using System.Collections;
using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Pastry
  {
    public string PastryType { get; set; }
    public int PastryPrice { get; set; }
    public int PastryAmount { get; set; }
    public Pastry(string pastryType, int pastryPrice)
    {
      PastryType = pastryType;
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