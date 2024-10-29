using AutoMapper;
using Biblioteca._01_Service;
using Biblioteca._01_Service.Interfaces;
using Biblioteca._03_Entidades;
using Microsoft.AspNetCore.Mvc;
using TrabalhoFinal._01_Services;

namespace API.Controllers;

[ApiController]
[Route("[controller]")]
public class AlunoController : ControllerBase
{
    private readonly IAlunoService _service;
    private readonly IMapper _mapper;
    public AlunoController(IConfiguration config, IMapper mapper)
    {
        string _config = config.GetConnectionString("DefaultConnection");
        _service = new AlunoService(_config);
        _mapper = mapper;
    }
    [HttpPost("adicionar-Aluno")]
    public void AdicionarAluno(Aluno AlunoDTO)
    {
        _service.Adicionar(AlunoDTO);
    }
    [HttpGet("listar-Aluno")]
    public List<Aluno> ListarAluno()
    {
        return _service.Listar();
    }
    [HttpPut("editar-Aluno")]
    public void EditarAluno(Aluno p)
    {
        _service.Editar(p);
    }
    [HttpDelete("deletar-Aluno")]
    public void DeletarAluno(int id)
    {
        _service.Remover(id);
    }
}
