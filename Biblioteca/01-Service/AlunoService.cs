using Biblioteca._02_Repositorios;
using Biblioteca._03_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca._01_Service
{
    public class AlunoService
    {
        public AlunoRepository repository { get; set; }
        public AlunoService(string config)
        {
            repository = new AlunoRepository(config);
        }
        public void Adicionar(Aluno aluno)
        {
            repository.Adicionar(aluno);
        }

        public void Remover(int id)
        {
            repository.Remover(BuscarTimePorId(id));
        }

        public List<Aluno> Listar()
        {
            return repository.Listar();
        }
        public Aluno BuscarTimePorId(int id)
        {
            return repository.BuscarPorId(id);
        }
        public void Editar(Aluno editAluno)
        {
            repository.Editar(editAluno);
        }
    }
}
