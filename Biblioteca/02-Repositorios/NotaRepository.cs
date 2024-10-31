using Biblioteca._02_Repositorios.Interfaces;
using Biblioteca._03_Entidades;
using Dapper.Contrib.Extensions;
using Microsoft.Extensions.Configuration;
using System.Data.SQLite;

namespace Biblioteca._02_Repositorios
{
    public class NotaRepository : INotaRepository
    {
        private readonly string ConnectionString;

        public NotaRepository(IConfiguration config)
        {
            ConnectionString = config.GetConnectionString("DefaultConnection");
        }

        public void Adicionar(Nota nota)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Insert<Nota>(nota);
        }

        public void Remover(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            Nota nota = BuscarPorId(id);
            connection.Delete<Nota>(nota);
        }

        public void Editar(Nota nota)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            object value = connection.Update<Nota>(nota);
        }

        public List<Nota> Listar()
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.GetAll<Nota>().ToList();
        }

        public Nota BuscarPorId(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.Get<Nota>(id);
        }

        internal void Remover(Nota nota)
        {
            throw new NotImplementedException();
        }
    }
}
