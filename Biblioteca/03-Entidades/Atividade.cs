using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Atividade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public string NotaObtida { get; set; }
        public string NotaMaxima{ get; set; }
        public int AlunoId { get; set; }

        public DateTime DataEntrega { get; set; }
    }
}
