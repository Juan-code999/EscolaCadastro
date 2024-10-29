using Biblioteca;
using Biblioteca._01_Service.Interfaces;
using Biblioteca._02_Repositorios;
using Biblioteca._02_Repositorios.Interfaces;
using Biblioteca._03_Entidades;
using TrabalhoFinal._02_Repository;

namespace TrabalhoFinal._01_Services;

public class AlunoService : IAlunoService
{
    public IAlunoRepository repository { get; set; }
    public AlunoService(string _config)
    {
        repository = new AlunoRepository(_config);
    }
    public void Adicionar(Aluno aluno)
    {
        repository.Adicionar(aluno);
    }

    public void Remover(int id)
    {
        repository.Remover(id);
    }

    public List<Aluno> Listar()
    {
        return repository.Listar();
    }
    public Aluno BuscarPorId(int id)
    {
        return repository.BuscarPorId(id);
    }
    public void Editar(Aluno editatividade)
    {
        repository.Editar(editatividade);
    }
}
