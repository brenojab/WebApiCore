using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiCore.Interfaces;

namespace WebApiCore.Entities
{
  public class UserRepository : IUserRepository
  {
    public List<User> GetUsers()
    {
      var user = new User()
      {
        Id = new Guid(),
        DataNascimento = new DateTime(1982, 9, 7),
        Nome = "Breno",
        SobreNome = "Batista",
        Sexo = "Masculino"
      };

      var list = new List<User>();
      list.Add(user);

      return list;
    }
  }
}
