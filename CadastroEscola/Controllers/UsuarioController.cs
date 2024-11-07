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
        public UsuarioController(IConfiguration config, IMapper mapper, IUsuarioService usuarioService)
        {
            string _config = config.GetConnectionString("DefaultConnection");
            _service = usuarioService;
            _mapper = mapper;
        }
        [HttpPost("adicionar-Usuario")]
        public void AdicionarUsuario(Usuario usuario)
        {
            _service.Adicionar(usuario);
        }
        [HttpGet("listar-Usuario")]
        public List<Usuario> ListarUsuario()
        {
            return _service.Listar();
        }
        [HttpPut("editar-Usuario")]
        public void EditarUsuario(Usuario p)
        {
            _service.Editar(p);
        }
        [HttpDelete("deletar-Usuario")]
        public void DeletarAtividade(int id)
        {
            _service.Remover(id);
        }

    }
}
