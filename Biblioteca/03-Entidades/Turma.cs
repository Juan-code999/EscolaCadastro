using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca._03_Entidades
{
    public class Turma
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Ano { get; set; }
        public List<Aluno> Alunos { get; set; }
        public Professor ProfessorResponsavel { get; set; }
        public DateTime DataInicio { get; set; }
    }
}
