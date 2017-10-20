using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebApiCore.Entities;
using WebApiCore.Interfaces;
using WebApiCore.Models;
using System;

namespace WebApiCore.Controllers
{
  [Produces("application/json")]
  [Route("api/[controller]")]
  public class UsersController : Controller
  {
    //private IUserRepository _userRepository;

    //public UsersController(IUserRepository userRepository)
    //{
    //  _userRepository = userRepository;
    //}

    [HttpGet()]
    public IActionResult GetUsers()
    {
      //var usersFromRepo = _userRepository.GetUsers();

      //var users = new List<UserDTO>();

      //foreach (var user in usersFromRepo)
      //{
      //  users.Add(new UserDTO()
      //  {
      //    Id = user.Id,
      //    Nome = $"{user.Nome} {user.SobreNome}",
      //    Sexo = user.Sexo,
      //    Idade = DateTime.Now.Year - user.DataNascimento.Year
      //  });
      //}

      //return new JsonResult(users);

      return new JsonResult("Breno Batista");
    }

    [HttpPost()]
    public IActionResult GetUsers([FromBody] string Nome)
    {
      return new JsonResult($@"{Nome}");
    }
  }
}