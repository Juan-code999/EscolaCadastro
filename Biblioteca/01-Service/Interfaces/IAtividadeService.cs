using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca._01_Service.Interfaces
{
    public interface IAtividadeService
    {
        void Adicionar(Atividade atividade);
        void Remover(int id);
        List<Atividade> Listar();
        Atividade BuscarAtividadePorId(int id);
        void Editar(Atividade atividade);
    }
}
