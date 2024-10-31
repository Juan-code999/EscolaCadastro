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
    public class LivroRepository : ILivroRepository
    {
        private readonly string ConnectionString;   

        public LivroRepository(IConfiguration config)
        {
            ConnectionString = config.GetConnectionString("DefaultConnection");
        }

        public void Adicionar(Livro livro)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Insert<Livro>(livro);
        }

        public void Remover(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            Livro livro = BuscarPorId(id);
            connection.Delete<Livro>(livro);
        }

        public void Editar(Livro livro)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Update<Livro>(livro);
        }

        public List<Livro> Listar()
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.GetAll<Livro>().ToList();
        }

        public Livro BuscarPorId(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.Get<Livro>(id);
        }

        internal void Remover(Livro livro)
        {
            throw new NotImplementedException();
        }
    }
}
