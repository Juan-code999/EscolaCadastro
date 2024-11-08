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
    public class ProfesorController : ControllerBase
    {
        private readonly IProfessorService _service;
        private readonly IMapper _mapper;

        /// <summary>
        /// Construtor do controlador de Professor.
        /// Inicializa os serviços necessários para manipulação dos dados de professor.
        /// </summary>
        /// <param name="config">Objeto de configuração contendo a string de conexão com o banco de dados.</param>
        /// <param name="mapper">Objeto AutoMapper para mapear entidades entre diferentes camadas.</param>
        /// <param name="professorService">Instância do serviço de professor para realizar operações de CRUD.</param>
        public ProfesorController(IConfiguration config, IMapper mapper, IProfessorService professorService)
        {
            string _config = config.GetConnectionString("DefaultConnection");
            _service = professorService;
            _mapper = mapper;
        }

        /// <summary>
        /// Adiciona um novo professor ao sistema.
        /// Este método recebe um objeto Professor e o adiciona ao banco de dados.
        /// </summary>
        /// <param name="ProfessorDTO">Objeto contendo os dados do professor a ser adicionado.</param>
        [HttpPost("adicionar-Professor")]
        public void AdicionarProfessor(Professor ProfessorDTO)
        {
            _service.Adicionar(ProfessorDTO);
        }

        /// <summary>
        /// Lista todos os professores cadastrados no sistema.
        /// Este método retorna uma lista de objetos Professor contendo todas as informações dos professores.
        /// </summary>
        /// <returns>Uma lista de objetos Professor.</returns>
        [HttpGet("listar-Professor")]
        public List<Professor> ListarProfessor()
        {
            return _service.Listar();
        }

        /// <summary>
        /// Edita as informações de um professor existente.
        /// Este método recebe um objeto Professor com os novos dados e os atualiza no banco de dados.
        /// </summary>
        /// <param name="p">Objeto Professor contendo as novas informações para o professor.</param>
        [HttpPut("editar-Professor")]
        public void EditarProfessor(Professor p)
        {
            _service.Editar(p);
        }

        /// <summary>
        /// Deleta um professor do sistema.
        /// Este método remove um professor do banco de dados, baseado no seu identificador (ID).
        /// </summary>
        /// <param name="id">Identificador único do professor a ser deletado.</param>
        [HttpDelete("deletar-Professor")]
        public void DeletarProfessor(int id)
        {
            _service.Remover(id);
        }
    }
}
