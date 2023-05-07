using System;
using System.Collections;
using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Tip
  {
    public decimal Percentage { get; set; }
    public decimal Amount { get; set; }

    public Tip(decimal percentage, decimal fullTotal)
    {
      Percentage = percentage;
      Amount = Math.Round(fullTotal * (Percentage / 100), 2);
    }
  }
}