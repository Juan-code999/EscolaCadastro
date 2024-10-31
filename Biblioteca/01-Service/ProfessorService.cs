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
    public class ProfessorService : IProfessorService
    {
        private readonly IProfessoresRepository repository;

        public ProfessorService(IProfessoresRepository professoresRepository)
        {
            repository = professoresRepository;
        }

        public void Adicionar(Professor professor)
        {
            repository.Adicionar(professor);
        }

        public void Remover(int id)
        {
            repository.Remover(BuscarPorId(id));
        }

        public List<Professor> Listar()
        {
            return repository.Listar();
        }

        public Professor BuscarPorId(int id)
        {
            return repository.BuscarPorId(id);
        }

        public void Editar(Professor editProfessor)
        {
            repository.Editar(editProfessor);
        }
    }
}
