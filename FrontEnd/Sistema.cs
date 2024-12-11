using Biblioteca._03_Entidades;
using FrontEnd.UseCases;

namespace FrontEnd;
public class SistemaEscolar
{
    private static Usuario UsuarioLogado { get; set; }
    private readonly UsuarioUC _usuarioUC;
    private readonly AlunoUC _alunoUC;
    private readonly ProfessorUC _professorUC;
    private readonly TurmaUC _turmaUC;
    private object _UsuarioUC;

    public SistemaEscolar(HttpClient cliente)
    {
        _usuarioUC = new UsuarioUC(cliente);
        _alunoUC = new AlunoUC(cliente);
        _professorUC = new ProfessorUC(cliente);
        _turmaUC = new TurmaUC(cliente);
    }

    public void IniciarSistema()
    {
        int resposta = -1;
        while (resposta != 0)
        {
            if (UsuarioLogado == null)
            {
                resposta = ExibirLogin();

                if (resposta == 1)
                {
                    FazerLogin();
                }
                else if (resposta == 2)
                {
                    Usuario usuario = CriarUsuario();
                    _usuarioUC.CadastrarUsuario(usuario);
                    Console.WriteLine("Usuário cadastrado com sucesso");
                }
                else if (resposta == 3)
                {
                    List<Usuario> usuarios = _UsuarioUC.ListarUsuarios();
                    foreach (Usuario u in usuarios)
                    {
                        Console.WriteLine(u.ToString());
                    }
                }
            }
            else
            {
                ExibirMenuPrincipal();
            }
        }
    }

    public int ExibirLogin()
    {
        Console.WriteLine("--------- LOGIN ---------");
        Console.WriteLine("1 - Deseja Fazer Login");
        Console.WriteLine("2 - Deseja se Cadastrar");
        Console.WriteLine("3 - Listar Usuários Cadastrados");
        return int.Parse(Console.ReadLine());
    }

    public Usuario CriarUsuario()
    {
        Usuario usuario = new Usuario();
        Console.WriteLine("Digite seu nome: ");
        usuario.Nome = Console.ReadLine();
        Console.WriteLine("Digite seu username: ");
        usuario.Username = Console.ReadLine();
        Console.WriteLine("Digite sua senha: ");
        usuario.Senha = Console.ReadLine();
        Console.WriteLine("Digite seu email: ");
        usuario.Email = Console.ReadLine();
        return usuario;
    }

    public Aluno CriarAluno()
    {
        Aluno aluno = new Aluno();
        Console.WriteLine("Digite o nome do aluno: ");
        aluno.Nome = Console.ReadLine();
        Console.WriteLine("Digite a data de nascimento do aluno (dd/mm/yyyy): ");
        aluno.DataNascimento = DateTime.Parse(Console.ReadLine());
        return aluno;
    }

    public Professor CriarProfessor()
    {
        Professor professor = new Professor();
        Console.WriteLine("Digite o nome do professor: ");
        professor.Nome = Console.ReadLine();
        Console.WriteLine("Digite a especialidade do professor: ");
        professor.Especialidade = Console.ReadLine();
        return professor;
    }

    public Turma CriarTurma()
    {
        Turma turma = new Turma();
        Console.WriteLine("Digite o nome da turma: ");
        turma.Nome = Console.ReadLine();
        Console.WriteLine("Digite a data de início da turma (dd/mm/yyyy): ");
        turma.DataInicio = DateTime.Parse(Console.ReadLine());
        return turma;
    }

    public void FazerLogin()
    {
        Console.WriteLine("Digite seu username: ");
        string username = Console.ReadLine();
        Console.WriteLine("Digite sua senha: ");
        string senha = Console.ReadLine();
        CreateUsuarioDTO usuDTO = new CreateUsuarioDTO
        {
            Username = username,
            Senha = senha
        };
        Usuario usuario = _usuarioUC.FazerLogin(usuDTO);
        if (usuario == null)
        {
            Console.WriteLine("Usuário ou senha inválidos!!!");
        }
        UsuarioLogado = usuario;
    }

    public void ExibirMenuPrincipal()
    {
        Console.WriteLine("1 - Listar Alunos");
        Console.WriteLine("2 - Cadastrar Aluno");
        Console.WriteLine("3 - Cadastrar Professor");
        Console.WriteLine("4 - Cadastrar Turma");
        Console.WriteLine("Qual operação deseja realizar?");
        int resposta = int.Parse(Console.ReadLine());

        if (resposta == 1)
        {
            ListarAlunos();
        }
        else if (resposta == 2)
        {
            Aluno aluno = CriarAluno();
            _alunoUC.CadastrarAluno(Aluno);
            Console.WriteLine("Aluno cadastrado com sucesso");
        }
        else if (resposta == 3)
        {
            Professor professor = CriarProfessor();
            _professorUC.CadastrarProfessor(professor);
            Console.WriteLine("Professor cadastrado com sucesso");
        }
        else if (resposta == 4)
        {
            Turma turma = CriarTurma();
            _turmaUC.CadastrarTurma(turma);
            Console.WriteLine("Turma cadastrada com sucesso");
        }
    }

    private void ListarAlunos()
    {
        List<Aluno> alunos = _alunoUC.ListarAlunos();
        foreach (Aluno aluno in alunos)
        {
            Console.WriteLine(aluno.ToString());
        }
    }
}
