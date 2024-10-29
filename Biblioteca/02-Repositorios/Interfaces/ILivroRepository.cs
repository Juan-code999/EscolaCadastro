using Biblioteca._03_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca._02_Repositorios.Interfaces
{
    public interface ILivroRepository
    {
        void Adicionar(Livro livro);
        void Remover(int id);
        void Editar(Livro livro);
        List<Livro> Listar();
        Livro BuscarPorId(int id);
    }
}
