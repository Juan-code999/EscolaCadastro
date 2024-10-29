using AutoMapper;
using Biblioteca._01_Service;
using Biblioteca._01_Service.Interfaces;
using Biblioteca._03_Entidades;
using Microsoft.AspNetCore.Mvc;
using TrabalhoFinal._01_Services;

namespace API.Controllers;

[ApiController]
[Route("[controller]")]
public class AtividadeController : ControllerBase
{
    private readonly IAtividadeService _service;
    private readonly IMapper _mapper;
    public AtividadeController(IConfiguration config, IMapper mapper)
    {
        string _config = config.GetConnectionString("DefaultConnection");
        _service = new AtividadeService(_config);
        _mapper = mapper;
    }
    [HttpPost("adicionar-Atividade")]
    public void AdicionarAtividade(Atividade atividade)
    {
        _service.Adicionar(atividade);
    }
    [HttpGet("listar-Atividade")]
    public List<Atividade> ListarAtividade()
    {
        return _service.Listar();
    }
    [HttpPut("editar-Atividade")]
    public void EditarAtividade(Atividade p)
    {
        _service.Editar(p);
    }
    [HttpDelete("deletar-Atividade")]
    public void DeletarAtividade(int id)
    {
        _service.Remover(id);
    }
}
