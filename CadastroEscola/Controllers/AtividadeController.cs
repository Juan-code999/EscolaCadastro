using AutoMapper;
using Biblioteca;
using Biblioteca._01_Service;
using Biblioteca._01_Service.Interfaces;
using Biblioteca._03_Entidades;
using Microsoft.AspNetCore.Mvc;
using TrabalhoFinal._01_Services;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AtividadeController : ControllerBase
    {
        private readonly IAtividadeService _service;
        private readonly IMapper _mapper;

        /// <summary>
        /// Construtor do controlador de Atividade.
        /// Inicializa os serviços necessários para manipulação dos dados de atividade.
        /// </summary>
        /// <param name="config">Objeto de configuração contendo a string de conexão com o banco de dados.</param>
        /// <param name="mapper">Objeto AutoMapper para mapear entidades entre diferentes camadas.</param>
        /// <param name="atividadeService">Instância do serviço de atividade para realizar operações de CRUD.</param>
        public AtividadeController(IConfiguration config, IMapper mapper, IAtividadeService atividadeService)
        {
            string _config = config.GetConnectionString("DefaultConnection");
            _service = atividadeService;
            _mapper = mapper;
        }

        /// <summary>
        /// Adiciona uma nova atividade ao sistema.
        /// Este método recebe um objeto Atividade e o adiciona ao banco de dados.
        /// </summary>
        /// <param name="atividade">Objeto contendo os dados da atividade a ser adicionada.</param>
        [HttpPost("adicionar-Atividade")]
        public void AdicionarAtividade(Atividade atividade)
        {
            _service.Adicionar(atividade);
        }

        /// <summary>
        /// Lista todas as atividades cadastradas no sistema.
        /// Este método retorna uma lista de objetos Atividade contendo todas as informações das atividades.
        /// </summary>
        /// <returns>Uma lista de objetos Atividade.</returns>
        [HttpGet("listar-Atividade")]
        public List<Atividade> ListarAtividade()
        {
            return _service.Listar();
        }

        /// <summary>
        /// Edita as informações de uma atividade existente.
        /// Este método recebe um objeto Atividade com os novos dados e os atualiza no banco de dados.
        /// </summary>
        /// <param name="p">Objeto Atividade contendo as novas informações para a atividade.</param>
        [HttpPut("editar-Atividade")]
        public void EditarAtividade(Atividade p)
        {
            _service.Editar(p);
        }

        /// <summary>
        /// Deleta uma atividade do sistema.
        /// Este método remove uma atividade do banco de dados, baseado no seu identificador (ID).
        /// </summary>
        /// <param name="id">Identificador único da atividade a ser deletada.</param>
        [HttpDelete("deletar-Atividade")]
        public void DeletarAtividade(int id)
        {
            _service.Remover(id);
        }
    }
}
