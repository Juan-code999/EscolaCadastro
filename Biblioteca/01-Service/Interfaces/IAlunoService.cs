using Biblioteca._03_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca._01_Service.Interfaces
{
    public interface IAlunoService
    {
        void Adicionar(Aluno aluno);
        void Remover(int id);
        List<Aluno> Listar();
        Aluno BuscarPorId(int id);
        void Editar(Aluno editatividade);
    }
}
