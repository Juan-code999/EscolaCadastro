using Biblioteca._02_Repositorios;
using Biblioteca._03_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca._01_Service
{
    public class TurmaService
    {
        public TurmaRepository repository { get; set; }

        public TurmaService(string config)
        {
            repository = new TurmaRepository(config);
        }

        public void Adicionar(Turma turma)
        {
            repository.Adicionar(turma);
        }

        public void Remover(int id)
        {
            repository.Remover(BuscarPorId(id));
        }

        public List<Turma> Listar()
        {
            return repository.Listar();
        }

        public Turma BuscarPorId(int id)
        {
            return repository.BuscarPorId(id);
        }

        public void Editar(Turma editTurma)
        {
            repository.Editar(editTurma);
        }
    }
}
