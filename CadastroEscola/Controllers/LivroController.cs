using AutoMapper;
using Biblioteca._01_Service;
using Biblioteca._03_Entidades;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("[controller]")]
public class LivroController : ControllerBase
{
    private readonly LivroService _service;
    private readonly IMapper _mapper;
    public LivroController(IConfiguration config, IMapper mapper)
    {
        string _config = config.GetConnectionString("DefaultConnection");
        _service = new LivroService(_config);
        _mapper = mapper;
    }
    [HttpPost("adicionar-Livro")]
    public void AdicionarLivro(Livro livro)
    {
        _service.Adicionar(livro);
    }
    [HttpGet("listar-Livro")]
    public List<Livro> ListarLivro()
    {
        return _service.Listar();
    }
    [HttpPut("editar-Livro")]
    public void EditarLivro(Livro l)
    {
        _service.Editar(l);
    }
    [HttpDelete("deletar-Livro")]
    public void DeletarLivro(int id)
    {
        _service.Remover(id);
    }
}
