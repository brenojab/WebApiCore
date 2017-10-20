using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiCore.Models
{
  public class CityDTO
  {
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Descrição { get; set; }

    public int NumeroDePontosDeInteresse
    {
      get
      {
        return PontosDeInteresse.Count;
      }
    }

    public ICollection<PontosDeInteresseDTO> PontosDeInteresse { get; set; } = new List<PontosDeInteresseDTO>();
  }
}
