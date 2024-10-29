using Biblioteca._03_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca._02_Repositorios.Interfaces
{
    internal interface INotaRepository
    {
        void Adicionar(Nota nota);
        void Remover(int id);
        void Editar(Nota nota);
        List<Nota> Listar();
        Nota BuscarPorId(int id);
    }
}
