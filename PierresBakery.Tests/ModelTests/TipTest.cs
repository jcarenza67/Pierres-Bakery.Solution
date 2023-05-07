using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;
using System.Collections.Generic;
using System;

namespace PierresBakery.Tests
{
  [TestClass]
  public class TipTests
  {
    [TestMethod]
    public void TipConstructor_CreatesInstanceOfTip_Tip()
    {
      decimal percentage = 20;
      decimal amount = 100;
      Tip newTip = new Tip(percentage, amount);
      Assert.AreEqual(typeof(Tip), newTip.GetType());
    }

    [TestMethod]
    public void Amount_ReturnsCorrectTip()
    {
      decimal percentage = 20;
      decimal amount = 100;
      decimal expectedTip = Math.Round(amount * (percentage/100), 2);
      Tip myTip = new Tip(percentage, amount);

      decimal actualTip = myTip.Amount;
      Assert.AreEqual(expectedTip, actualTip);
    }
  }
}