using Biblioteca._01_Service.Interfaces;
using Biblioteca._02_Repositorios.Interfaces;
using Biblioteca._03_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca._01_Service
{
    public class UsuarioService : IUsuarioService
    {
        
            private readonly IUsuarioRepository repository;

            public UsuarioService(IUsuarioRepository usuarioRepository)
            {
                repository = usuarioRepository;
            }

            public void Adicionar(Usuario usuario)
            {
                repository.Adicionar(usuario);
            }

            public void Remover(int id)
            {
                repository.Remover(id);
            }

            public List<Usuario> Listar()
            {
                return repository.Listar();
            }

            public Usuario BuscarPorId(int id)
            {
                return repository.BuscarPorId(id);
            }

            public void Editar(Usuario editUsuario)
            {
                repository.Editar(editUsuario);
            }
        
    }
}
