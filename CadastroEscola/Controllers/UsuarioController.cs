using AutoMapper;
using Biblioteca._01_Service.Interfaces;
using Biblioteca;
using Microsoft.AspNetCore.Mvc;
using Biblioteca._03_Entidades;

namespace ApiEscola.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _service;
        private readonly IMapper _mapper;

        /// <summary>
        /// Construtor do controlador de Usuário.
        /// Inicializa os serviços necessários para manipulação dos dados de usuário.
        /// </summary>
        /// <param name="config">Objeto de configuração contendo a string de conexão com o banco de dados.</param>
        /// <param name="mapper">Objeto AutoMapper para mapear entidades entre diferentes camadas.</param>
        /// <param name="usuarioService">Instância do serviço de usuário para realizar operações de CRUD.</param>
        public UsuarioController(IConfiguration config, IMapper mapper, IUsuarioService usuarioService)
        {
            string _config = config.GetConnectionString("DefaultConnection");
            _service = usuarioService;
            _mapper = mapper;
        }

        /// <summary>
        /// Adiciona um novo usuário ao sistema.
        /// Este método recebe um objeto Usuario e o adiciona ao banco de dados.
        /// </summary>
        /// <param name="usuario">Objeto contendo os dados do usuário a ser adicionado.</param>
        [HttpPost("adicionar-Usuario")]
        public void AdicionarUsuario(Usuario usuario)
        {
            _service.Adicionar(usuario);
        }

        /// <summary>
        /// Lista todos os usuários cadastrados no sistema.
        /// Este método retorna uma lista de objetos Usuario contendo todas as informações dos usuários.
        /// </summary>
        /// <returns>Uma lista de objetos Usuario.</returns>
        [HttpGet("listar-Usuario")]
        public List<Usuario> ListarUsuario()
        {
            return _service.Listar();
        }

        /// <summary>
        /// Edita as informações de um usuário existente.
        /// Este método recebe um objeto Usuario com os novos dados e os atualiza no banco de dados.
        /// </summary>
        /// <param name="p">Objeto Usuario contendo as novas informações para o usuário.</param>
        [HttpPut("editar-Usuario")]
        public void EditarUsuario(Usuario p)
        {
            _service.Editar(p);
        }

        /// <summary>
        /// Deleta um usuário do sistema.
        /// Este método remove um usuário do banco de dados, baseado no seu identificador (ID).
        /// </summary>
        /// <param name="id">Identificador único do usuário a ser deletado.</param>
        [HttpDelete("deletar-Usuario")]
        public void DeletarUsuario(int id)
        {
            _service.Remover(id);
        }
    }
}
