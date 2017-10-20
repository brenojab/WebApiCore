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
  [Route("api/cities")]
  public class PontoInteresseController : Controller
  {

    [HttpGet("{cityId}/pontointeresse")]
    public IActionResult GetPontosInteresse(int cityId)
    {
      var city = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == cityId);

      if(city == null)
      {
        return NotFound();
      }

      return Ok(city.PontosDeInteresse);

    }

    [HttpGet("{cityId}/pontointeresse/{id}")]
    public IActionResult GetPontoInteresse(int cityId, int id)
    {
      var city = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == cityId);

      if (city == null)
        return NotFound();

      var pontoInteresse = city.PontosDeInteresse.FirstOrDefault(c => c.Id == id);

      if (pontoInteresse == null)
      {
        return NotFound();
      }

      return Ok(pontoInteresse);
    }
  }
}