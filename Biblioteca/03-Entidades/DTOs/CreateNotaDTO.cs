using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca._03_Entidades.DTOs
{
    public class CreateNotaDTO
    {
        public double Valor { get; set; }
        public DateTime DataEmissao { get; set; }
        public string Descricao { get; set; }
    }
}
