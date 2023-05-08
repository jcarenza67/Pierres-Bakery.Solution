using System;
using System.Collections;
using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Bread
  {
    public string BreadType { get; set; }
    public int BreadPrice { get; set;}
    public int BreadAmount { get; set; }
    public Bread(string breadType, int breadPrice)
    {
      BreadType = breadType;
      BreadPrice = breadPrice;
    }
    public int BreadOrder(int breadOrderAmount)
    {
      int fullPriceBread = (breadOrderAmount / 3) * 2;
      int remainingBread = breadOrderAmount % 3;
      BreadAmount = (fullPriceBread + remainingBread) * BreadPrice;
      return BreadAmount;
    }
  }
}