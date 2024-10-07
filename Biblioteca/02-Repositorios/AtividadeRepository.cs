using Biblioteca._03_Entidades;
using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca._02_Repositorios
{
    public class AtividadeRepository
    {
        private readonly string ConnectionString;

        public AtividadeRepository(string configuration)
        {
            ConnectionString = configuration;
        }

        public void Adicionar(Atividades atividade)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Insert<Atividades>(atividade);
        }


        public void Remover(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            Atividades atividade = BuscarPorId(id);
            connection.Delete<Atividades>(atividade);
        }


        public void Editar(Atividades atividade)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Update<Atividades>(atividade);
        }

        public List<Atividades> Listar()
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.GetAll<Atividades>().ToList();
        }


        public Atividades BuscarPorId(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.Get<Atividades>(id);
        }
    }
}
