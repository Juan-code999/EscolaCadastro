using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola._02_Repositorios.Data
{
    public static class InicializadorBd
    {
        public static void Inicializar()
        {
            using var connection = new SQLiteConnection("Data Source=Escola.db");

            string commandoSQL = @"   
                 CREATE TABLE IF NOT EXISTS Alunos(
                 Id INTEGER PRIMARY KEY AUTOINCREMENT,
                 Nome TEXT NOT NULL,
                 Idade INTEGER NOT NULL,
                 Peso REAL NOT NULL,
                 Altura REAL NOT NULL
                );";

          
            commandoSQL += @"   
                 CREATE TABLE IF NOT EXISTS Atividades(
                 Id INTEGER PRIMARY KEY AUTOINCREMENT,
                 Nome TEXT NOT NULL,
                 Tipo TEXT NOT NULL,
                 DataEntrega TEXT NOT NULL,
                 NotaMaxima REAL NOT NULL,
                 NotaObtida REAL NOT NULL,
                 AlunoId INTEGER NOT NULL,
                 FOREIGN KEY (AlunoId) REFERENCES Alunos(Id)
                );";

            commandoSQL += @"   
                 CREATE TABLE IF NOT EXISTS Livros(
                 Id INTEGER PRIMARY KEY AUTOINCREMENT,
                 Titulo TEXT NOT NULL,
                 Autor TEXT NOT NULL,
                 AnoPublicacao INTEGER
                );";

            commandoSQL += @"   
                 CREATE TABLE IF NOT EXISTS Notas(
                 Id INTEGER PRIMARY KEY AUTOINCREMENT,
                 AlunoId TEXT NOT NULL,
                 Valor REAL
                );";

            commandoSQL += @"   
                 CREATE TABLE IF NOT EXISTS Professors(
                 Id INTEGER PRIMARY KEY AUTOINCREMENT,
                 Nome TEXT NOT NULL,
                 Disciplina TEXT NOT NULL,
                 AnosDeExperiencia INTERGER
                );";


            connection.Execute(commandoSQL);
        }
    }

}
