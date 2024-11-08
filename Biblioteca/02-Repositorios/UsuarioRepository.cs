﻿using Biblioteca._02_Repositorios.Interfaces;
using Biblioteca._03_Entidades;
using Dapper.Contrib.Extensions;
using Microsoft.Extensions.Configuration;
using System.Data.SQLite;

namespace Biblioteca._02_Repositorios
{
    public class UsuarioRepository : IUsuarioRepository
    {
        
            private readonly string ConnectionString;

            public UsuarioRepository(IConfiguration config)
            {
                ConnectionString = config.GetConnectionString("DefaultConnection");
            }

            public void Adicionar(Usuario usuario)
            {
                using var connection = new SQLiteConnection(ConnectionString);
                connection.Insert<Usuario>(usuario);
            }

            public void Remover(int id)
            {
                using var connection = new SQLiteConnection(ConnectionString);
                Usuario usuario = BuscarPorId(id);
                connection.Delete<Usuario>(usuario);
            }

            public void Editar(Usuario usuario)
            {
                using var connection = new SQLiteConnection(ConnectionString);
                connection.Update<Usuario>(usuario);
            }

            public List<Usuario> Listar()
            {
                using var connection = new SQLiteConnection(ConnectionString);
                return connection.GetAll<Usuario>().ToList();
            }

            public Usuario BuscarPorId(int id)
            {
                using var connection = new SQLiteConnection(ConnectionString);
                return connection.Get<Usuario>(id);
            }

      
      
    }
}