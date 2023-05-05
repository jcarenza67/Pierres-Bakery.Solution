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
      Bread newBread = new Bread();
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void BreadOrder_ReturnsCorrectPrice()
    {
      int breadPrice = 5;
      int breadOrderAmount = 6;
      int expectedPrice = (breadOrderAmount - breadOrderAmount / 3);
      Bread myBread = new Bread(breadPrice);

      int actualPrice = myBread.BreadOrder(breadOrderAmount);
      Assert.AreEqual(expectedPrice, actualPrice);
    }
  }
}