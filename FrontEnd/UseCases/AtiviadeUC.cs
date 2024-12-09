using Biblioteca;
using Biblioteca._03_Entidades.DTOs;
using System.Net.Http.Json;

namespace FrontEnd.UseCases
{
    public class AtividadeUC
    {
        private readonly HttpClient _client;

        public AtividadeUC(HttpClient client)
        {
            _client = client;
        }

        public void CadastrarAtividade(Atividade atividade)
        {
            HttpResponseMessage response = _client.PostAsJsonAsync("Atividade/adicionar-atividade", atividade).Result;
        }

        public List<CreateAtividadeDTO> ListarAtividades()
        {
            return _client.GetFromJsonAsync<List<CreateAtividadeDTO>>("Atividade/listar-atividades").Result;
        }
    }

}
