using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiCore.Entities
{

  public class User
  {
    [Key]
    public Guid Id { get; set; }

    [Required]
    [MaxLength(50)]
    public string Nome { get; set; }

    [Required]
    [MaxLength(50)]
    public string SobreNome { get; set; }

    [Required]
    public DateTime DataNascimento { get; set; }

    [Required]
    public string Sexo { get; set; }
  }
}
