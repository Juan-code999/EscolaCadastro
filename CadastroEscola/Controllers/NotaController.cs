using AutoMapper;
using Biblioteca._01_Service;
using Biblioteca._01_Service.Interfaces;
using Biblioteca._03_Entidades;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class NotaController : ControllerBase
    {
        private readonly INotaService _service;
        private readonly IMapper _mapper;

        /// <summary>
        /// Construtor do controlador de Nota.
        /// Inicializa os serviços necessários para manipulação dos dados de nota.
        /// </summary>
        /// <param name="config">Objeto de configuração contendo a string de conexão com o banco de dados.</param>
        /// <param name="mapper">Objeto AutoMapper para mapear entidades entre diferentes camadas.</param>
        /// <param name="notaService">Instância do serviço de nota para realizar operações de CRUD.</param>
        public NotaController(IConfiguration config, IMapper mapper, INotaService notaService)
        {
            string _config = config.GetConnectionString("DefaultConnection");
            _service = notaService;
            _mapper = mapper;
        }

        /// <summary>
        /// Adiciona uma nova nota ao sistema.
        /// Este método recebe um objeto Nota e o adiciona ao banco de dados.
        /// </summary>
        /// <param name="nota">Objeto contendo os dados da nota a ser adicionada.</param>
        [HttpPost("adicionar-Nota")]
        public void AdicionarNota(Nota nota)
        {
            _service.Adicionar(nota);
        }

        /// <summary>
        /// Lista todas as notas cadastradas no sistema.
        /// Este método retorna uma lista de objetos Nota contendo todas as informações das notas.
        /// </summary>
        /// <returns>Uma lista de objetos Nota.</returns>
        [HttpGet("listar-Nota")]
        public List<Nota> ListarNota()
        {
            return _service.Listar();
        }

        /// <summary>
        /// Edita as informações de uma nota existente.
        /// Este método recebe um objeto Nota com os novos dados e os atualiza no banco de dados.
        /// </summary>
        /// <param name="p">Objeto Nota contendo as novas informações para a nota.</param>
        [HttpPut("editar-Nota")]
        public void EditarNota(Nota p)
        {
            _service.Editar(p);
        }

        /// <summary>
        /// Deleta uma nota do sistema.
        /// Este método remove uma nota do banco de dados, baseado no seu identificador (ID).
        /// </summary>
        /// <param name="id">Identificador único da nota a ser deletada.</param>
        [HttpDelete("deletar-Nota")]
        public void DeletarNota(int id)
        {
            _service.Remover(id);
        }
    }
}
