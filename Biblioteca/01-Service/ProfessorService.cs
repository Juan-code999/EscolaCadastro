﻿using Biblioteca._02_Repositorios;
using Biblioteca._03_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca._01_Service
{
    public class ProfessorService
    {
        public ProfessorRepository repository { get; set; }

        public ProfessorService(string config)
        {
            repository = new ProfessorRepository(config);
        }

        public void Adicionar(Professor professor)
        {
            repository.Adicionar(professor);
        }

        public void Remover(int id)
        {
            repository.Remover(BuscarPorId(id));
        }

        public List<Professor> Listar()
        {
            return repository.Listar();
        }

        public Professor BuscarPorId(int id)
        {
            return repository.BuscarPorId(id);
        }

        public void Editar(Professor editProfessor)
        {
            repository.Editar(editProfessor);
        }
    }
}
