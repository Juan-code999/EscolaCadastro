using Biblioteca._02_Repositorios.Interfaces;
using Biblioteca._03_Entidades;
using Dapper.Contrib.Extensions;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca._02_Repositorios
{
    public class TurmaRepository : ITurmaRepository
    {
        private readonly string ConnectionString;

        public TurmaRepository(IConfiguration config)
        {
            ConnectionString = config.GetConnectionString("DefaultConnection");
        }

        public void Adicionar(Turma turma)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Insert<Turma>(turma);
        }

        public void Remover(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            Turma turma = BuscarPorId(id);
            connection.Delete<Turma>(turma);
        }

        public void Editar(Turma turma)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Update<Turma>(turma);
        }

        public List<Turma> Listar()
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.GetAll<Turma>().ToList();
        }

        public Turma BuscarPorId(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.Get<Turma>(id);
        }

        internal void Remover(Turma turma)
        {
            throw new NotImplementedException();
        }
    }
}
