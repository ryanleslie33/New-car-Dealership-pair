using System;

namespace Dealership {

  class Car
  {
    private string _MakeModel;
    public int Price;
    public int Miles;
    private string _AboutCar;

    private static List<car> _inventory = new List<car>{};

    public Car(string makeModel, int price, int miles,string aboutCar)
    {
      _MakeModel = makeModel;
       Price = price;
       Miles = miles;
      _AboutCar = aboutCar;
    }

    private string GetMakeModel()
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
    public void SetPrice(string maxPrice)
    {
       _Price = maxPrice;
    }


    public int GetMiles()
    {
      return Miles;
    }
    public void SetMiles(string newMiles)
    {
       _Miles = newMiles;
    }

    private string GetAboutCar()
    {
      return _AboutCar;
    }
    public void SetAboutCar(string newinfo)
    {
       _AboutCar = newInfo;
    }
    public void Save()
    {
      _inventory.Add(this);
    }
    public static List<car> GetAll()
  {
    return _inventory;
  }
    public bool WorthBuying(int maxPrice)
    {
      return (Price < maxPrice);
    }

}
}
