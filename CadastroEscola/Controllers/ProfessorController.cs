

using AutoMapper;
using Biblioteca._01_Service;
using Biblioteca._01_Service.Interfaces;
using Biblioteca._03_Entidades;
using Microsoft.AspNetCore.Mvc;
using TrabalhoFinal._01_Services;

namespace API.Controllers;

[ApiController]
[Route("[controller]")]
public class ProfesorController : ControllerBase
{
    private readonly IProfessorService _service;
    private readonly IMapper _mapper;
    public ProfesorController(IConfiguration config, IMapper mapper, IProfessorService professorService)
    {
        string _config = config.GetConnectionString("DefaultConnection");
        _service = professorService;
        _mapper = mapper;
    }
    [HttpPost("adicionar-Professor")]
    public void AdicionarProfessor(Professor ProfessorDTO)
    {
        _service.Adicionar(ProfessorDTO);
    }
    [HttpGet("listar-Professor")]
    public List<Professor> ListarProfessor()
    {
        return _service.Listar();
    }
    [HttpPut("editar-Professor")]
    public void EditarProfessor(Professor p)
    {
        _service.Editar(p);
    }
    [HttpDelete("deletar-Professor")]
    public void DeletarProfessor(int id)
    {
        _service.Remover(id);
    }
}
