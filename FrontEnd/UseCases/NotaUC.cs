using Biblioteca._03_Entidades;
using Biblioteca._03_Entidades.DTOs;
using System.Net.Http.Json;

namespace FrontEnd.UseCases
{
    public class NotaUC
    {
        private readonly HttpClient _client;

        public NotaUC(HttpClient client)
        {
            _client = client;
        }

        public void CadastrarNota(Nota nota)
        {
            HttpResponseMessage response = _client.PostAsJsonAsync("Nota/adicionar-nota", nota).Result;
        }

        public List<CreateNotaDTO> ListarNotas()
        {
            return _client.GetFromJsonAsync<List<CreateNotaDTO>>("Nota/listar-notas").Result;
        }
    }
        
}
