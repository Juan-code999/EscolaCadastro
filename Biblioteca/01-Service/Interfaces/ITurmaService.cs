using Biblioteca._03_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca._01_Service.Interfaces
{
    public interface ITurmaService
    {
        void Adicionar(Turma turma);
        void Remover(int id);
        List<Turma> Listar();
        Turma BuscarPorId(int id);
        void Editar(Turma editTurma);
    }
}
