using Biblioteca._03_Entidades;
using Biblioteca._03_Entidades.DTOs;
using System.Net.Http.Json;

namespace FrontEnd.UseCases
{
    public class LivroUC
    {
        private readonly HttpClient _client;

        public LivroUC(HttpClient client)
        {
            _client = client;
        }

        public void CadastrarLivro(Livro livro)
        {
            HttpResponseMessage response = _client.PostAsJsonAsync("Livro/adicionar-livro", livro).Result;
        }

        public List<CreateLivroDTO> ListarLivros()
        {
            return _client.GetFromJsonAsync<List<CreateLivroDTO>>("Livro/listar-livros").Result;
        }
    }

}
