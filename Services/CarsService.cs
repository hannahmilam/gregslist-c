using System;
using System.Collections.Generic;
using System.Linq;
using Gregslist.Data;
using Gregslist.models;

namespace Gregslist.Controllers
{
  public class CarsService
  {
    private readonly FakeDb _db;
    public CarsService(FakeDb db){
      _db = db;
    }
    
    public List<Car> Get()
    {
     return _db.Cars.ToList();
    }

    public Car Get(int carId)
    {
      var car = _db.Cars.Find(c => c.Id == carId);
      if(car == null)
      {
        throw new SystemException("Invalid Car Id");
      }
      return car;
    }

    public Car CreateCar(Car carData)
    {
      carData.Id = _db.GenerateId();
      _db.Cars.Add(carData);
      return carData;
    }

    public Car Edit(int carId, Car carData)
    {
      var car = Get(carId);
      car.make = carData.make ?? car.make;
      car.model = carData.model ?? car.model;
      car.year = carData.year;
      car.description = carData.description ?? car.description;
      car.price = carData.price;
      car.img = carData.img ?? car.img;
      return car;
    }

    public Car Delete(int carId)
    {
      var car = Get(carId);
      _db.Cars.Remove(car);
      return car;
    }
  }
}