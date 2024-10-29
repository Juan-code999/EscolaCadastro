using AutoMapper;
using Biblioteca._01_Service;
using Biblioteca._01_Service.Interfaces;
using Biblioteca._03_Entidades;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("[controller]")]
public class NotaController : ControllerBase
{
    private readonly INotaService _service;
    private readonly IMapper _mapper;
    public NotaController(IConfiguration config, IMapper mapper)
    {
        string _config = config.GetConnectionString("DefaultConnection");
        _service = new NotaService(_config);
        _mapper = mapper;
    }
    [HttpPost("adicionar-Nota")]
    public void AdicionarNota(Nota nota)
    {
        _service.Adicionar(nota);
    }
    [HttpGet("listar-Nota")]
    public List<Nota> ListarNota()
    {
        return _service.Listar();
    }
    [HttpPut("editar-Nota")]
    public void EditarNota(Nota p)
    {
        _service.Editar(p);
    }
    [HttpDelete("deletar-Nota")]
    public void DeletarNota(int id)
    {
        _service.Remover(id);
    }
}
