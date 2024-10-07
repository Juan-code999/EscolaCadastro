using Biblioteca._02_Repositorios;
using Biblioteca._03_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca._01_Service
{
    public class NotaService
    {
        public NotaRepository repository { get; set; }

        public NotaService(string config)
        {
            repository = new NotaRepository(config);
        }

        public void Adicionar(Nota nota)
        {
            repository.Adicionar(nota);
        }

        public void Remover(int id)
        {
            repository.Remover(BuscarPorId(id));
        }

        public List<Nota> Listar()
        {
            return repository.Listar();
        }

        public Nota BuscarPorId(int id)
        {
            return repository.BuscarPorId(id);
        }

        public void Editar(Nota editNota)
        {
            repository.Editar(editNota);
        }
    }
}
