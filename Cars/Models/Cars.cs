using System;
using System.Collections.Generic;


namespace Cars.Models
{

public class Car
  {
    private string _MakeModel;
    public int Price;
    public int Miles;
    private string _AboutCar;

    private static List<Car> _inventory = new List<Car> {};

    public Car (string makeModel, int price, int miles, string aboutCar)
    {
      _MakeModel = makeModel;
       Price = price;
       Miles = miles;
      _AboutCar = aboutCar;
      _inventory.Add(this);
    }

    public string GetMakeModel()
    {
      return _MakeModel;
    }
    public void SetMakeModel(string newCar)
    {
       _MakeModel = newCar;
    }


    public int GetPrice()
    {
      return Price;
    }
    public void SetPrice(int maxPrice)
    {
       Price = maxPrice;
    }


    public int GetMiles()
    {
      return Miles;
    }
    public void SetMiles(int newMiles)
    {
       Miles = newMiles;
    }

    private string GetAboutCar()
    {
      return _AboutCar;
    }
    public void SetAboutCar(string newinfo)
    {
       _AboutCar = newinfo;
    }
    // public void Save()
    // {
    //   _inventory.Add(this);
    // }
    public static List<Car> GetAll()
  {
    return _inventory;
  }
  public static void ClearAll()
  {
    _inventory.Clear();
  }
    public bool WorthBuying(int maxPrice)
    {
      return (Price < maxPrice);
    }

}
}
