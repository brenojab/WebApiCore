using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiCore.Entities;

namespace WebApiCore.Interfaces
{
  public interface IUserRepository
  {
    List<User> GetUsers();
  }
}
