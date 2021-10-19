using System;
using System.Collections.Generic;
using System.Linq;
using Gregslist.Data;
using Gregslist.models;

namespace Gregslist.Controllers
{
  public class HousesService
  {
    private readonly FakeDb _db;
    public HousesService(FakeDb db){
      _db = db;
    }
    
    public List<House> Get()
    {
     return _db.Houses.ToList();
    }

    public House Get(int houseId)
    {
      var house = _db.Houses.Find(h => h.Id == houseId);
      if(house == null)
      {
        throw new SystemException("Invalid House Id");
      }
      return house;
    }

    public House CreateHouse(House houseData)
    {
      houseData.Id = _db.GenerateId();
      _db.Houses.Add(houseData);
      return houseData;
    }

    public House Edit(int houseId, House houseData)
    {
      var house = Get(houseId);
      house.price = houseData.price;
      house.bedrooms = houseData.bedrooms;
      house.bathrooms = houseData.bathrooms;
      house.levels = houseData.levels;
      house.description = houseData.description ?? house.description;
      house.img = houseData.img ?? house.img;
      return house;

    }

    public House Delete(int houseId)
    {
      var house = Get(houseId);
      _db.Houses.Remove(house);
      return house;
    }
  }
}