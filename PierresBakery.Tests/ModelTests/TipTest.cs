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
  }
}