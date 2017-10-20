using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiCore.Data;

namespace WebApiCore.Controllers
{
  [Produces("application/json")]
  [Route("api/Cities")]
  public class CitiesController : Controller
  {
    [HttpGet()]
    public IActionResult GetCities()
    {
      return Ok(new JsonResult(new CitiesDataStore()));
    }

    [HttpGet("{id}")]
    public IActionResult GetCity(int Id)
    {
      var city = new JsonResult(new CitiesDataStore().Cities.FirstOrDefault(c => c.Id == Id));

      if (city == null)
        return NotFound();

      return Ok(city);
    }

  }
}