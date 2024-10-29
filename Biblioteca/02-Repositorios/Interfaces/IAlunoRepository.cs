using Biblioteca._03_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca._02_Repositorios.Interfaces
{
    public interface IAlunoRepository
    {
        void Adicionar(Aluno aluno);
        void Remover(int id);
        void Editar(Aluno usuario);
        List<Aluno> Listar();
        Aluno BuscarPorId(int id);
    }
}
