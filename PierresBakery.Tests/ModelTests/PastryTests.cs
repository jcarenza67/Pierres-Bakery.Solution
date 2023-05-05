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
      Pastry newPastry = new Pastry();
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void Pastry_Constructor_SetsPastryPrice()
    {
      int newPastryAmount = 2;
      Pastry myPastry = new Pastry(2);
      Assert.AreEqual(newPastryAmount, myPastry.PastryPrice);
    }
  }
}