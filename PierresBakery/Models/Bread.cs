using System;
using System.Collections;
using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Bread
  {
    public int BreadPrice { get; set;}
    public int BreadAmount { get; set; }
    public Bread(int breadPrice)
    {
      BreadPrice = breadPrice;
    }
    public int BreadOrder(int breadOrderAmount)
    {
      int fullPriceBread = (breadOrderAmount / 3) * 2;
      int remainginBread = breadOrderAmount % 3;
      BreadAmount = (fullPriceBread + remainginBread) * BreadPrice;
      return BreadAmount;
    }
  }
}