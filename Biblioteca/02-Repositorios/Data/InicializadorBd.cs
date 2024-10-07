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
                 CREATE TABLE IF NOT EXISTS Aluno(
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
                 NotaObtida REAL,
                 AlunoId INTEGER,
                 FOREIGN KEY (AlunoId) REFERENCES Alunos(Id)
                );";

            connection.Execute(commandoSQL);
        }
    }

}
