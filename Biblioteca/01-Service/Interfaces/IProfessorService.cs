using Biblioteca._03_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca._01_Service.Interfaces
{
    public interface IProfessorService
    {
        void Adicionar(Professor professor);
        void Remover(int id);
        List<Professor> Listar();
        Professor BuscarPorId(int id);
        void Editar(Professor editProfessor);
    }
}
