using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;
using System.Collections.Generic;
using System;

namespace PierresBakery.Tests 
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      int pastryPrice = 2;
      Pastry newPastry = new Pastry("croissant", pastryPrice);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void PastryOrder_ReturnsCorrectPrice()
    {
      int pastryPrice = 2;
      int pastryOrderAmount = 5;
      int expectedPrice = (pastryOrderAmount / 3 * 2 + pastryOrderAmount % 3) * pastryPrice;
      Pastry myPastry = new Pastry("croissant", pastryPrice);

      int actualPrice = myPastry.PastryOrder(pastryOrderAmount);
      Assert.AreEqual(expectedPrice, actualPrice);
    }
  }
}