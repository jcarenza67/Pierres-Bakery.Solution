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
      int eachPastryAmount = 2;
      Pastry myPastry = new Pastry(eachPastryAmount);
      Assert.AreEqual(eachPastryAmount, myPastry.PastryPrice);
    }
  }
}