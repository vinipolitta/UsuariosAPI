using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UsuariosAPI.Data.Dtos;

namespace UsuariosAPI.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class UsuarioController
    {
        [HttpPost]
        public IActionResult CadastrarUsuario(CreateusuarioDto dto)
        {

            throw new NotImplementedException();
        }
    }
}