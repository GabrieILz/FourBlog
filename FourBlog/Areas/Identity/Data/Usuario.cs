using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace FourBlog.Areas.Identity.Data;

// Add profile data for application users by adding properties to the Usuario class
public class Usuario : IdentityUser
{
    public int UsuarioId { get; set; }

    public string Nome { get; set; }

    public string Email { get; set; }

    public string Senha { get; set; }

    public DateTime DataNascimento { get; set; }
}

