using Biblioteca._03_Entidades;

namespace Biblioteca._02_Repositorios.Interfaces
{
    public interface IProfessoresRepository
    {
        void Adicionar(Professor professor);
        void Remover(int id);
        void Editar(Professor professor);
        List<Professor> Listar();
        Professor BuscarPorId(int id);
    }
}
