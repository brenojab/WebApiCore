using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiCore.Models;

namespace WebApiCore.Data
{

  public class CitiesDataStore
  {
    public static CitiesDataStore Current { get; } = new CitiesDataStore();

    public List<CityDTO> Cities { get; set; }

    public CitiesDataStore()
    {
      Cities = new List<CityDTO>()
      {
        new CityDTO()
        {
          Id = 1,
          Nome = "Sarzedo",
          Descrição = "Cidade de Sarzedo",
          PontosDeInteresse = new List<PontosDeInteresseDTO>()
          {
            new PontosDeInteresseDTO()
            {
             Id = 1,
             Nome = "Pracinha de Sarzedo",
             Descrição =  "Pracinha de Sarzedo descrição"
            },
            new PontosDeInteresseDTO()
            {
             Id = 2,
             Nome = "Estação de Sarzedo",
             Descrição =  "Estação de Sarzedo descrição"
            }
          }
        },
        new CityDTO()
        {
            Id = 2,
          Nome = "BH",
          Descrição = "Cidade de BH",
          PontosDeInteresse = new List<PontosDeInteresseDTO>()
          {
            new PontosDeInteresseDTO()
            {
              Id = 1,
              Nome = "Parque das Águas",
              Descrição = "Parque das Águas descrição"
            },
            new PontosDeInteresseDTO()
            {
              Id = 2,
              Nome = "Pé de goiaba",
              Descrição = "Pé de goiaba descrição"
            }
          }
        }
      };
    }
  }
}
