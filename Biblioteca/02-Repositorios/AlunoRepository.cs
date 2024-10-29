using Biblioteca._02_Repositorios.Interfaces;
using Biblioteca._03_Entidades;
using Dapper.Contrib.Extensions;
using System.Data.SQLite;

namespace TrabalhoFinal._02_Repository;

public class AlunoRepository : IAlunoRepository
{
    private readonly string ConnectionString;
    public AlunoRepository(string connectioString)
    {
        ConnectionString = connectioString;
    }
    public void Adicionar(Aluno aluno)
    {
        using var connection = new SQLiteConnection(ConnectionString);
        connection.Insert<Aluno>(aluno);
    }
    public void Remover(int id)
    {
        using var connection = new SQLiteConnection(ConnectionString);
        Aluno aluno = BuscarPorId(id);
        connection.Delete<Aluno>(aluno);
    }
    public void Editar(Aluno usuario)
    {
        using var connection = new SQLiteConnection(ConnectionString);
        connection.Update<Aluno>(usuario);
    }
    public List<Aluno> Listar()
    {
        using var connection = new SQLiteConnection(ConnectionString);
        return connection.GetAll<Aluno>().ToList();
    }
    public Aluno BuscarPorId(int id)
    {
        using var connection = new SQLiteConnection(ConnectionString);
        return connection.Get<Aluno>(id);
    }
}
