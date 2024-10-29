using Biblioteca._02_Repositorios;
using Biblioteca;
using Biblioteca._01_Service.Interfaces;

namespace Biblioteca._01_Service
{
    public class AtividadeService : IAtividadeService
    {
        public AtividadeRepository repository { get; set; }

        public AtividadeService(string config)
        {
            repository = new AtividadeRepository(config);
        }

        public void Adicionar(Atividade atividade)
        {
            repository.Adicionar(atividade);
        }
        public void Remover(int id)
        {
            repository.Remover(id);
        }

        public List<Atividade> Listar()
        {
            return repository.Listar();
        }

        public Atividade BuscarAtividadePorId(int id)
        {
            return repository.BuscarPorId(id);
        }

        public void Editar(Atividade atividade)
        {
            repository.Editar(atividade);
        }
    }
}
