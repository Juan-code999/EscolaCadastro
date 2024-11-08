using AutoMapper;
using Biblioteca._01_Service;
using Biblioteca._01_Service.Interfaces;
using Biblioteca._03_Entidades;
using Microsoft.AspNetCore.Mvc;
using TrabalhoFinal._01_Services;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AlunoController : ControllerBase
    {
        private readonly IAlunoService _service;
        private readonly IMapper _mapper;

        /// <summary>
        /// Construtor do controlador de Aluno.
        /// Inicializa os serviços necessários para manipulação dos dados de aluno.
        /// </summary>
        /// <param name="config">Objeto de configuração contendo a string de conexão com o banco de dados.</param>
        /// <param name="mapper">Objeto AutoMapper para mapear entidades entre diferentes camadas.</param>
        /// <param name="alunoService">Instância do serviço de aluno para realizar operações de CRUD.</param>
        public AlunoController(IConfiguration config, IMapper mapper, IAlunoService alunoService)
        {
            string _config = config.GetConnectionString("DefaultConnection");
            _service = alunoService;
            _mapper = mapper;
        }

        /// <summary>
        /// Adiciona um novo aluno ao sistema.
        /// Este método recebe um objeto Aluno e o adiciona ao banco de dados.
        /// </summary>
        /// <param name="AlunoDTO">Objeto contendo os dados do aluno a ser adicionado.</param>
        [HttpPost("adicionar-Aluno")]
        public void AdicionarAluno(Aluno AlunoDTO)
        {
            _service.Adicionar(AlunoDTO);
        }

        /// <summary>
        /// Lista todos os alunos cadastrados no sistema.
        /// Este método retorna uma lista de objetos Aluno contendo todas as informações dos alunos.
        /// </summary>
        /// <returns>Uma lista de objetos Aluno.</returns>
        [HttpGet("listar-Aluno")]
        public List<Aluno> ListarAluno()
        {
            return _service.Listar();
        }

        /// <summary>
        /// Edita as informações de um aluno existente.
        /// Este método recebe um objeto Aluno com os novos dados e os atualiza no banco de dados.
        /// </summary>
        /// <param name="p">Objeto Aluno contendo as novas informações para o aluno.</param>
        [HttpPut("editar-Aluno")]
        public void EditarAluno(Aluno p)
        {
            _service.Editar(p);
        }

        /// <summary>
        /// Deleta um aluno do sistema.
        /// Este método remove um aluno do banco de dados, baseado no seu identificador (ID).
        /// </summary>
        /// <param name="id">Identificador único do aluno a ser deletado.</param>
        [HttpDelete("deletar-Aluno")]
        public void DeletarAluno(int id)
        {
            _service.Remover(id);
        }
    }
}
