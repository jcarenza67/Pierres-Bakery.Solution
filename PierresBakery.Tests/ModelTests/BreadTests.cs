using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;
using System.Collections.Generic;
using System;

namespace PierresBakery.Tests
{
  [TestClass]

  public class BreadTests 
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      int breadPrice = 5;
      Bread newBread = new Bread("wheat", breadPrice);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void BreadOrder_ReturnsCorrectPrice()
    {
      int breadPrice = 5;
      int breadOrderAmount = 6;
      int fullPriceBread = (breadOrderAmount / 3) * 2;
      int remainingBread = breadOrderAmount % 3;
      int expectedPrice = (fullPriceBread + remainingBread) * breadPrice;
      Bread myBread = new Bread("wheat", breadPrice);

      int actualPrice = myBread.BreadOrder(breadOrderAmount);
      Assert.AreEqual(expectedPrice, actualPrice);
    }
  }
}