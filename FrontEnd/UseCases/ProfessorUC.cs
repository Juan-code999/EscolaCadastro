using Biblioteca._03_Entidades;
using Biblioteca._03_Entidades.DTOs;
using System.Net.Http.Json;

namespace FrontEnd.UseCases
{
    public class ProfessorUC
    {
        private readonly HttpClient _client;

        public ProfessorUC(HttpClient client)
        {
            _client = client;
        }

        public void CadastrarProfessor(Professor professor)
        {
            HttpResponseMessage response = _client.PostAsJsonAsync("Professor/adicionar-professor", professor).Result;
        }

        public List<CreateProfessorDTO> ListarProfessores()
        {
            return _client.GetFromJsonAsync<List<CreateProfessorDTO>>("Professor/listar-professores").Result;
        }
    }

}
