using Biblioteca._03_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca._02_Repositorios.Interfaces
{
    internal interface IProfessoresRepository
    {
        void Adicionar(Professor professor);
        void Remover(int id);
        void Editar(Professor professor);
        List<Professor> Listar();
        Professor BuscarPorId(int id);
    }
}
