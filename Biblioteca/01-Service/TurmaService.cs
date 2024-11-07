using Biblioteca._01_Service.Interfaces;
using Biblioteca._02_Repositorios;
using Biblioteca._02_Repositorios.Interfaces;
using Biblioteca._03_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca._01_Service
{
    public class TurmaService : ITurmaService
    {
        private readonly ITurmaRepository repository;

        public TurmaService(ITurmaRepository turmaRepository)
        {
            repository = turmaRepository;
        }

        public void Adicionar(Turma turma)
        {
            repository.Adicionar(turma);
        }

        public void Remover(int id)
        {
            repository.Remover(id);
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
