using Biblioteca._03_Entidades;

namespace Biblioteca._02_Repositorios.Interfaces
{
    public interface INotaRepository
    {
        void Adicionar(Nota nota);
        void Remover(int id);
        void Editar(Nota nota);
        List<Nota> Listar();
        Nota BuscarPorId(int id);
    }
}
