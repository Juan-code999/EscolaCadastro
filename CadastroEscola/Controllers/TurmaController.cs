﻿using AutoMapper;
using Biblioteca;
using Biblioteca._01_Service;
using Biblioteca._03_Entidades;
using Microsoft.AspNetCore.Mvc;
using TrabalhoFinal._01_Services;

namespace API.Controllers;

[ApiController]
[Route("[controller]")]
public class TurmaController : ControllerBase
{
    private readonly TurmaService _service;
    private readonly IMapper _mapper;
    public TurmaController(IConfiguration config, IMapper mapper)
    {
        string _config = config.GetConnectionString("DefaultConnection");
        _service = new TurmaService(_config);
        _mapper = mapper;
    }
    [HttpPost("adicionar-Turma")]
    public void AdicionarTurma(Turma Turma)
    {
        _service.Adicionar(Turma);
    }
    [HttpGet("listar-Turma")]
    public List<Turma> ListarTurma()
    {
        return _service.Listar();
    }
    [HttpPut("editar-Turma")]
    public void EditarTurma(Turma p)
    {
        _service.Editar(p);
    }
    [HttpDelete("deletar-Turma")]
    public void DeletarTurma(int id)
    {
        _service.Remover(id);
    }
}
