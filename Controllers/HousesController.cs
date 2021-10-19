using System.Collections.Generic;
using Gregslist.models;
using Microsoft.AspNetCore.Mvc;

namespace Gregslist.Controllers {
  [ApiController]
  [Route("api/[controller]")]
  public class HousesController : ControllerBase {
    private readonly HousesService _cs;
    public HousesController(HousesService cs)
    {
      _cs = cs;
    }

    [HttpGet]
    public ActionResult<List<HousesController>> GetHouses(){
      try
      {
         var houses = _cs.Get();
         return Ok(houses);  
      }
      catch (System.Exception e)
      {
       return BadRequest(e.Message);
      }
    }

    [HttpGet("{houseId}")]
    public ActionResult<House> GetHouseById(int houseId) {
      try
      {
          var house = _cs.Get(houseId);
          return Ok(house); 
      }
      catch (System.Exception e)
      {
       return BadRequest(e.Message);
      }
    }

    [HttpPost]
    public ActionResult<House> CreateHouse([FromBody] House houseData) {
      try
      {
        var house = _cs.CreateHouse(houseData);
        return Ok(house);  
      }
      catch (System.Exception e)
      {
       return BadRequest(e.Message);
      }
    }

    [HttpPut("{houseId}")]
    public ActionResult<House> EditHouse(int houseId, [FromBody] House houseData) {
      try
      {
           var house = _cs.Edit(houseId, houseData);
           return Ok(house);
      }
      catch (System.Exception e)
      {
         return BadRequest(e.Message);
      }
    }

    [HttpDelete("{houseId}")]
    public ActionResult<House> DeleteHouse(int houseId, [FromBody] House houseData) {
      try
      {
          var house = _cs.Delete(houseId);
          return Ok(house);  
      }
      catch (System.Exception e)
      {
       return BadRequest(e.Message);
      }
    }
  }
}