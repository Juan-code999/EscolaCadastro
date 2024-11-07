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
    public class ProfessorRepository : IProfessoresRepository
    {
        private readonly string ConnectionString;

        public ProfessorRepository(IConfiguration config)
        {
            ConnectionString = config.GetConnectionString("DefaultConnection");
        }

        public void Adicionar(Professor professor)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Insert<Professor>(professor);
        }

        public void Remover(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            Professor professor = BuscarPorId(id);
            connection.Delete<Professor>(professor);
        }

        public void Editar(Professor professor)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            object value = connection.Update<Professor>(professor);
        }

        public List<Professor> Listar()
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.GetAll<Professor>().ToList();
        }

        public Professor BuscarPorId(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.Get<Professor>(id);
        }

        
    }
}
