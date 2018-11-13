using System;

namespace Dealership {

  class Car
  {
    private string MakeModel;
    public int Price;
    public int Miles;
    private string AboutCar;

    public Car(string makeModel, int price, int miles,string aboutCar)
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
      AboutCar = aboutCar;
    }

    public string GetMakeModel()
    {
      return MakeModel;
    }

    public int GetPrice()
    {
      return Price;
    }

    public int GetMiles()
    {
      return Miles;
    }

    public string GetAboutCar()
    {
      return AboutCar;
    }
    public bool WorthBuying(int maxPrice)
    {
      return (Price < maxPrice);
    }

}
}
