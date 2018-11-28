using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cars.Models;
using System.Collections.Generic;
using System;

namespace Cars.Tests
{
[TestClass]
public class CarTest : IDisposable
{
  public void Dispose()
  {
    Car.ClearAll();
  }
  [TestMethod]
  public void CarConstructor_CreatesInstanceOfCar_Car()
  {
    Car newCar = new Car("test", 1, 2, "three");
    Assert.AreEqual(typeof(Car), newCar.GetType());
  }
}
}
