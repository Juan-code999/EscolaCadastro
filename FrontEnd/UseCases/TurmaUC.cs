using Biblioteca._03_Entidades;
using Biblioteca._03_Entidades.DTOs;
using System.Net.Http.Json;

namespace FrontEnd.UseCases
{
    public class TurmaUC
    {
        private readonly HttpClient _client;

        public TurmaUC(HttpClient client)
        {
            _client = client;
        }

        public void CadastrarTurma(Turma turma)
        {
            HttpResponseMessage response = _client.PostAsJsonAsync("Turma/adicionar-turma", turma).Result;
        }

        public List<CreateTurmaDTO> ListarTurmas()
        {
            return _client.GetFromJsonAsync<List<CreateTurmaDTO>>("Turma/listar-turmas").Result;
        }
    }

}
