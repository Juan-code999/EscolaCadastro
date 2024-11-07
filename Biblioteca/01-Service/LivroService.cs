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
    public class LivroService : ILivroService
    {
        private readonly ILivroRepository repository;

        public LivroService(ILivroRepository livroRepository)
        {
            repository = livroRepository;
        }

        public void Adicionar(Livro livro)
        {
            repository.Adicionar(livro);
        }

        public void Remover(int id)
        {
            repository.Remover(id);
        }

        public List<Livro> Listar()
        {
            return repository.Listar();
        }

        public Livro BuscarPorId(int id)
        {
            return repository.BuscarPorId(id);
        }

        public void Editar(Livro editLivro)
        {
            repository.Editar(editLivro);
        }
    }
}
