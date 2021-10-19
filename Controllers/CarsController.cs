using System.Collections.Generic;
using Gregslist.models;
using Microsoft.AspNetCore.Mvc;

namespace Gregslist.Controllers {
  [ApiController]
  [Route("api/[controller]")]
  public class CarsController : ControllerBase {
    private readonly CarsService _cs;
    public CarsController(CarsService cs)
    {
      _cs = cs;
    }

  [HttpGet]
  public ActionResult<List<CarsController>> GetCars() {
    try
    {
         var cars = _cs.Get();
         return Ok(cars);
    }
    catch (System.Exception e)
    {
        
       return BadRequest(e.Message);
    }
  }

  [HttpGet("{carId}")]
  public ActionResult<Car> GetCarById(int carId) {
    try
    {
         var car = _cs.Get(carId);
         return Ok(car);
    }
    catch (System.Exception e)
    {
      return BadRequest(e.Message);
    }
  }
  [HttpPost]
  public ActionResult<Car> CreateCar([FromBody] Car carData)
  {
    try
    {
      var car = _cs.CreateCar(carData);
      return Ok(car);
    }
    catch (System.Exception e)
    {
     return BadRequest(e.Message);
    }
  }

  [HttpPut("{carId}")]
  public ActionResult<Car> EditCar(int carId, [FromBody] Car carData) {
    try
    {
         var car = _cs.Edit(carId, carData);
         return Ok(car);
    }
    catch (System.Exception e)
    {
   return BadRequest(e.Message);
    }
  }

  [HttpDelete("{carId}")]
  public ActionResult<Car> DeleteCar(int carId, [FromBody] Car carData) {
    try
    {
         var car = _cs.Delete(carId);
         return Ok(car);
    }
    catch (System.Exception e)
    {
      return BadRequest(e.Message);
    }
  }
  }
}