using Biblioteca._03_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca._02_Repositorios.Interfaces
{
    internal interface ITurmaRepository
    {
        void Adicionar(Turma turma);
        void Remover(int id);
        void Editar(Turma turma);
        List<Turma> Listar();
        Turma BuscarPorId(int id);
    }
}
