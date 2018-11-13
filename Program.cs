using System;
using System.Collections.Generic;

namespace Dealership {

  public class Program
  {
    public static void Main()
    {
      Car porsche = new Car("2014 Porsche 911", 114991, 7864, "made by a german manufacturer");
      Car ford = new Car("2011 Ford F450", 55995, 14241, "american made");
      Car lexus = new Car("2013 Lexus RX 350", 44700, 20000, " made by Toyota");
      Car mercedes = new Car("Mercedes Benz CLS550", 39900, 37979, "made by germany");

      List<Car> Cars = new List<Car>() { porsche, ford, lexus, mercedes };

      Console.WriteLine("Enter maximum price: ");
      string stringMaxPrice = Console.ReadLine();
      int maxPrice = int.Parse(stringMaxPrice);

      Console.WriteLine("Enter mileage");
      string stringMaxMiles = Console.ReadLine();
      int maxMiles = int.Parse(stringMaxMiles);

      List<Car> CarsMatchingSearch = new List<Car>(0);

      foreach(Car automobile in Cars)
      {
        if(automobile.GetPrice() <  maxPrice && automobile.GetMiles() < maxMiles)
        {
          CarsMatchingSearch.Add(automobile);
        } else
        Console.WriteLine("You dont have any match right now !");
    

      foreach(Car automobile in CarsMatchingSearch)
      {
        Console.WriteLine("----------------------");
        Console.WriteLine(automobile.GetMakeModel());
        Console.WriteLine(automobile.GetMiles() + " miles");
        Console.WriteLine("$" + automobile.GetPrice());
        Console.WriteLine(automobile.GetAboutCar());
      }
    }
  }

}
