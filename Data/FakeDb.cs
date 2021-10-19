using System;
using System.Collections.Generic;
using Gregslist.models;

namespace Gregslist.Data
{
  public class FakeDb
  {
    private Random _random = new Random();
    public List<Car> Cars = new List<Car>();
    public List<House> Houses = new List<House>();
    public int GenerateId()
    {
    return _random.Next(10000, 10000000);

    }
  }
}
