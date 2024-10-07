using Biblioteca._02_Repositorios;
using Biblioteca._03_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca._01_Service
{
    public class LivroService
    {
        public LivroRepository repository { get; set; }

        public LivroService(string config)
        {
            repository = new LivroRepository(config);
        }

        public void Adicionar(Livro livro)
        {
            repository.Adicionar(livro);
        }

        public void Remover(int id)
        {
            repository.Remover(BuscarPorId(id));
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
