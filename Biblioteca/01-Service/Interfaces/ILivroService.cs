using Biblioteca._03_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca._01_Service.Interfaces
{
    public interface ILivroService
    {
        void Adicionar(Livro livro);
        void Remover(int id);
        List<Livro> Listar();
        Livro BuscarPorId(int id);
        void Editar(Livro editLivro);
    }
}
