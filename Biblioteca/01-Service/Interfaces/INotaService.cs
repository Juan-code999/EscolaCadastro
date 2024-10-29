using Biblioteca._03_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca._01_Service.Interfaces
{
    public interface INotaService
    {
        void Adicionar(Nota nota);
        void Remover(int id);
        List<Nota> Listar();
        Nota BuscarPorId(int id);
        void Editar(Nota editNota);
    }
}
