using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca._02_Repositorios.Interfaces
{
    public interface IAtividadeRepository
    {
        void Adicionar(Atividade atividade);
        public void Remover(int id);
        void Editar(Atividade atividade);
        List<Atividade> Listar();
        Atividade BuscarPorId(int id);

    }
}
