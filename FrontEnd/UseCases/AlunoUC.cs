using Biblioteca._03_Entidades.DTOs;
using FrontEnd.Models;
using System.Net.Http.Json;

namespace FrontEnd.UseCases
{
    public class AlunoUC
    {
        private readonly HttpClient _client;

        public AlunoUC(HttpClient client)
        {
            _client = client;
        }

        public void CadastrarAluno(Aluno aluno)
        {
            HttpResponseMessage response = _client.PostAsJsonAsync("Aluno/adicionar-aluno", aluno).Result;
        }

        public List<CreateAlunoDTO> ListarAlunos()
        {
            return _client.GetFromJsonAsync<List<CreateAlunoDTO>>("Aluno/listar-alunos").Result;
        }
    }

}
