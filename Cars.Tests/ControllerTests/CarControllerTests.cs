using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Cars.Controllers;
using Cars.Models;

namespace Car.Tests
{
  [TestClass]
  public class CarsControllerTest
  {
    [TestMethod]
    public void Create_ReturnsCorrectActionType_RedirectToActionResult()
    {
      CarsController controller = new CarsController();
      RedirectToActionResult actionResult = controller.Create("2014 Porsche 911", 114991, 7864, "made by a german manufacturer") as RedirectToActionResult;

      string result = actionResult.ActionName;
      Assert.AreEqual(result, "Index");
    }
  }
}
