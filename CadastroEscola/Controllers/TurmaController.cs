﻿using AutoMapper;
using Biblioteca;
using Biblioteca._01_Service;
using Biblioteca._01_Service.Interfaces;
using Biblioteca._03_Entidades;
using Microsoft.AspNetCore.Mvc;
using TrabalhoFinal._01_Services;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TurmaController : ControllerBase
    {
        private readonly ITurmaService _service;
        private readonly IMapper _mapper;

        /// <summary>
        /// Construtor do controlador de Turma.
        /// Inicializa os serviços necessários para manipulação dos dados de turma.
        /// </summary>
        /// <param name="config">Objeto de configuração contendo a string de conexão com o banco de dados.</param>
        /// <param name="mapper">Objeto AutoMapper para mapear entidades entre diferentes camadas.</param>
        /// <param name="turmaService">Instância do serviço de turma para realizar operações de CRUD.</param>
        public TurmaController(IConfiguration config, IMapper mapper, ITurmaService turmaService)
        {
            string _config = config.GetConnectionString("DefaultConnection");
            _service = turmaService;
            _mapper = mapper;
        }

        /// <summary>
        /// Adiciona uma nova turma ao sistema.
        /// Este método recebe um objeto Turma e o adiciona ao banco de dados.
        /// </summary>
        /// <param name="Turma">Objeto contendo os dados da turma a ser adicionada.</param>
        [HttpPost("adicionar-Turma")]
        public IActionResult AdicionarTurma(Turma Turma)
        {
            try
            {
                _service.Adicionar(Turma);
                return Ok();

            }
            catch (Exception erro)
            {

                return BadRequest("Ocorreu um erro ao Adicionar um Turma, " +
                $"o erro foi\n{erro.Message}");

            }
            
        }

        /// <summary>
        /// Lista todas as turmas cadastradas no sistema.
        /// Este método retorna uma lista de objetos Turma contendo todas as informações das turmas.
        /// </summary>
        /// <returns>Uma lista de objetos Turma.</returns>
        [HttpGet("listar-Turma")]
        public List<Turma> ListarTurma()
        {
            try
            {
                return _service.Listar();
            }
            catch (Exception erro)
            {

                throw new Exception("Ocorreu um erro ao Listar uma Turma, " +
                $"o erro foi\n{erro.Message}");
            }
        }

        /// <summary>
        /// Edita as informações de uma turma existente.
        /// Este método recebe um objeto Turma com os novos dados e os atualiza no banco de dados.
        /// </summary>
        /// <param name="p">Objeto Turma contendo as novas informações para a turma.</param>
        [HttpPut("editar-Turma")]
        public IActionResult EditarTurma(Turma p)
        {
            try
            {
                _service.Editar(p);
                return Ok();

            }
            catch (Exception erro)
            {

                return BadRequest("Ocorreu um erro ao Editar um Turma, " +
                $"o erro foi\n{erro.Message}");

            }
            
        }

        /// <summary>
        /// Deleta uma turma do sistema.
        /// Este método remove uma turma do banco de dados, baseado no seu identificador (ID).
        /// </summary>
        /// <param name="id">Identificador único da turma a ser deletada.</param>
        [HttpDelete("deletar-Turma")]
        public IActionResult DeletarTurma(int id)
        {
            try
            {
                _service.Remover(id);
                return Ok();

            }
            catch (Exception erro)
            {

                return BadRequest("Ocorreu um erro ao Deletar uma Turma, " +
                $"o erro foi\n{erro.Message}");

            }
            
        }
    }
}
