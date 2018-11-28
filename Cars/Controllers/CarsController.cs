using Microsoft.AspNetCore.Mvc;
using Cars.Models;
using System.Collections.Generic;

namespace Cars.Controllers
{
  public class CarsController : Controller
  {
    [HttpGet("/Cars")]
    public ActionResult Index()
    {
      List<Car> allCars = Car.GetAll();
      return View(allCars);
    }
    [HttpGet("/Cars/new")]
    public ActionResult CarForm()
    {
      return View();
    }
    [HttpPost("/Cars")]
    public ActionResult Create(string makeModel, int price, int miles, string aboutCar)
    {
      Car myCar = new Car(makeModel, price, miles, aboutCar);
      return RedirectToAction("Index");
    }
  }
}
