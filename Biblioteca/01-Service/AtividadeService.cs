using Biblioteca._02_Repositorios;
using Biblioteca._03_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca._01_Service
{
    public class AtividadesService
    {
        public AtividadeRepository repository { get; set; }

        public AtividadesService(string config)
        {
            repository = new AtividadeRepository(config);
        }

        public void Adicionar(Atividades atividade)
        {
            repository.Adicionar(atividade);
        }
        public void Remover(int id)
        {
            repository.Remover(id);
        }

        public List<Atividades> Listar()
        {
            return repository.Listar();
        }

        public Atividades BuscarAtividadePorId(int id)
        {
            return repository.BuscarPorId(id);
        }

        public void Editar(Atividades atividade)
        {
            repository.Editar(atividade);
        }
    }
