using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiCore.Models
{
  public class UserDTO
  {
    public Guid Id { get; set; }

    public string Nome { get; set; }

    public int Idade { get; set; }

    public string Sexo { get; set; }
  }
}
