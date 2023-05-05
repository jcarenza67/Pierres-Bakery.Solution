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

  }
}