using Biblioteca._03_Entidades;

namespace Biblioteca._02_Repositorios.Interfaces
{
    public interface ITurmaRepository
    {
        void Adicionar(Turma turma);
        void Remover(int id);
        void Editar(Turma turma);
        List<Turma> Listar();
        Turma BuscarPorId(int id);
    }
}
