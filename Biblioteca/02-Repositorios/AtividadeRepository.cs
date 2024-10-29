using Biblioteca._02_Repositorios.Interfaces;
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
    public class AtividadeRepository : IAtividadeRepository
    {
        private readonly string ConnectionString;

        public AtividadeRepository(string configuration)
        {
            ConnectionString = configuration;
        }

        public void Adicionar(Atividade atividade)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Insert<Atividade>(atividade);
        }


        public void Remover(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            Atividade atividade = BuscarPorId(id);
            connection.Delete<Atividade>(atividade);
        }


        public void Editar(Atividade atividade)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Update<Atividade>(atividade);
        }

        public List<Atividade> Listar()
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.GetAll<Atividade>().ToList();
        }


        public Atividade BuscarPorId(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.Get<Atividade>(id);
        }
    }
}
