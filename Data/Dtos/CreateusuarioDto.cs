using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UsuariosAPI.Data.Dtos
{
    public class CreateusuarioDto
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public DateTime DataNascimento { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [Compare("Password")]
        public string RePassword { get; set; }

    }
}