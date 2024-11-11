using AutoMapper;
using Biblioteca._01_Service;
using Biblioteca._01_Service.Interfaces;
using Biblioteca._03_Entidades;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
  
    [ApiController]
    [Route("[controller]")]
    public class LivroController : ControllerBase
    {
        private readonly ILivroService _service;
        private readonly IMapper _mapper;

        /// <summary>
        /// Construtor do controlador de Livro.
        /// Inicializa os serviços necessários para manipulação dos dados de livro.
        /// </summary>
        /// <param name="config">Objeto de configuração contendo a string de conexão com o banco de dados.</param>
        /// <param name="mapper">Objeto AutoMapper para mapear entidades entre diferentes camadas.</param>
        /// <param name="livroService">Instância do serviço de livro para realizar operações de CRUD.</param>
        public LivroController(IConfiguration config, IMapper mapper, ILivroService livroService)
        {
            string _config = config.GetConnectionString("DefaultConnection");
            _service = livroService;
            _mapper = mapper;
        }

        /// <summary>
        /// Adiciona um novo livro ao sistema.
        /// Este método recebe um objeto Livro e o adiciona ao banco de dados.
        /// </summary>
        /// <param name="livro">Objeto contendo os dados do livro a ser adicionado.</param>
        [HttpPost("adicionar-Livro")]
        public IActionResult AdicionarLivro(Livro livro)
        {
            try
            {
                _service.Adicionar(livro);
                return Ok();

            }
            catch (Exception erro)
            {

                return BadRequest("Ocorreu um erro ao Adicionar um Livro, " +
                $"o erro foi\n{erro.Message}");

            }
            
        }

        /// <summary>
        /// Lista todos os livros cadastrados no sistema.
        /// Este método retorna uma lista de objetos Livro contendo todas as informações dos livros.
        /// </summary>
        /// <returns>Uma lista de objetos Livro.</returns>
        [HttpGet("listar-Livro")]
        public List<Livro> ListarLivro()
        {
            try
            {
                return _service.Listar();
            }
            catch (Exception erro)
            {

                throw new Exception("Ocorreu um erro ao Listar um Livro, " +
                $"o erro foi\n{erro.Message}");
            }
        }

        /// <summary>
        /// Edita as informações de um livro existente.
        /// Este método recebe um objeto Livro com os novos dados e os atualiza no banco de dados.
        /// </summary>
        /// <param name="l">Objeto Livro contendo as novas informações para o livro.</param>
        [HttpPut("editar-Livro")]
        public IActionResult EditarLivro(Livro l)
        {
            try
            {
                _service.Editar(l);
                return Ok();

            }
            catch (Exception erro)
            {

                return BadRequest("Ocorreu um erro ao Editar um Livro, " +
                $"o erro foi\n{erro.Message}");

            }
            
        }

        /// <summary>
        /// Deleta um livro do sistema.
        /// Este método remove um livro do banco de dados, baseado no seu identificador (ID).
        /// </summary>
        /// <param name="id">Identificador único do livro a ser deletado.</param>
        [HttpDelete("deletar-Livro")]
        public IActionResult DeletarLivro(int id)
        {
            try
            {
                _service.Remover(id);
                return Ok();

            }
            catch (Exception erro)
            {

                return BadRequest("Ocorreu um erro ao Remover um Livro, " +
                $"o erro foi\n{erro.Message}");

            }
           
        }
    }
}
