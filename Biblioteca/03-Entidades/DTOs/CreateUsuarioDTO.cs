using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca._03_Entidades.DTOs
{
    public class CreateUsuarioDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }

    }
}
