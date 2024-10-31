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
    public class NotaService : INotaService
    {
        private readonly INotaRepository repository;

        public NotaService(INotaRepository notaRepository)
        {
            repository = notaRepository;
        }

        public void Adicionar(Nota nota)
        {
            repository.Adicionar(nota);
        }

        public void Remover(int id)
        {
            repository.Remover(BuscarPorId(id));
        }

        public List<Nota> Listar()
        {
            return repository.Listar();
        }

        public Nota BuscarPorId(int id)
        {
            return repository.BuscarPorId(id);
        }

        public void Editar(Nota editNota)
        {
            repository.Editar(editNota);
        }
    }
}
