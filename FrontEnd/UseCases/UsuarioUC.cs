using Biblioteca._03_Entidades;
using Biblioteca._03_Entidades.DTOs;
using System.Net.Http.Json;

namespace FrontEnd.UseCases
{
    public class UsuarioUC
    {
        private readonly HttpClient _client;

        public UsuarioUC(HttpClient client)
        {
            _client = client;
        }

        public void CadastrarUsuario(Usuario usuario)
        {
            HttpResponseMessage response = _client.PostAsJsonAsync("Usuario/adicionar-usuario", usuario).Result;
        }

        public List<CreateUsuarioDTO> ListarUsuarios()
        {
            return _client.GetFromJsonAsync<List<CreateUsuarioDTO>>("Usuario/listar-usuarios").Result;
        }
    }

}
