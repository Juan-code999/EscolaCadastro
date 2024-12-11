using System;
using System.Collections.Generic;

namespace SistemaEscolar
{
    class Program
    {
        static void Main(string[] args)
        {
            SistemaEscolar sistema = new SistemaEscolar();
            sistema.IniciarSistema();
        }
    }

    public class SistemaEscolar
    {
        private static Usuario UsuarioLogado { get; set; }
        private readonly List<Usuario> _usuarios = new List<Usuario>();
        private readonly List<Aluno> _alunos = new List<Aluno>();
        private readonly List<Professor> _professores = new List<Professor>();
        private readonly List<Turma> _turmas = new List<Turma>();

        public void IniciarSistema()
        {
            ExibirTelaInicial();

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
                        CadastrarUsuario(usuario);
                        Console.WriteLine("Usuário cadastrado com sucesso");
                    }
                    else if (resposta == 3)
                    {
                        ListarUsuarios();
                    }
                }
                else
                {
                    ExibirMenuPrincipal();
                }
            }
        }

        public void ExibirTelaInicial()
        {
            Console.WriteLine("Bem-vindo ao Sistema Escolar!");
            Console.WriteLine("Por favor, revise as informações abaixo antes de continuar.");
            Console.WriteLine("1. Verifique seus dados pessoais.");
            Console.WriteLine("2. Confirme seu endereço.");
            Console.WriteLine("3. Revise suas preferências de curso.");
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
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

        public void CadastrarUsuario(Usuario usuario)
        {
            _usuarios.Add(usuario);
        }

        public void ListarUsuarios()
        {
            if (_usuarios.Count == 0)
            {
                Console.WriteLine("Nenhum usuário cadastrado.");
                return;
            }

            foreach (Usuario usuario in _usuarios)
            {
                Console.WriteLine(usuario.ToString());
            }
        }

        public void FazerLogin()
        {
            Console.WriteLine("Digite seu username: ");
            string username = Console.ReadLine();
            Console.WriteLine("Digite sua senha: ");
            string senha = Console.ReadLine();

            Usuario usuario = _usuarios.Find(u => u.Username == username && u.Senha == senha);

            if (usuario == null)
            {
                Console.WriteLine("Usuário ou senha inválidos!!!");
            }
            else
            {
                UsuarioLogado = usuario;
                Console.WriteLine("Login realizado com sucesso!");
            }
        }

        public void ExibirMenuPrincipal()
        {
            Console.WriteLine("--------- MENU PRINCIPAL ---------");
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
                CadastrarAluno(aluno);
                Console.WriteLine("Aluno cadastrado com sucesso");
            }
            else if (resposta == 3)
            {
                Professor professor = CriarProfessor();
                CadastrarProfessor(professor);
                Console.WriteLine("Professor cadastrado com sucesso");
            }
            else if (resposta == 4)
            {
                Turma turma = CriarTurma();
                CadastrarTurma(turma);
                Console.WriteLine("Turma cadastrada com sucesso");
            }
        }

        public void ListarAlunos()
        {
            if (_alunos.Count == 0)
            {
                Console.WriteLine("Nenhum aluno cadastrado.");
                return;
            }

            foreach (Aluno aluno in _alunos)
            {
                Console.WriteLine(aluno.ToString());
            }
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

        public void CadastrarAluno(Aluno aluno)
        {
            _alunos.Add(aluno);
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

        public void CadastrarProfessor(Professor professor)
        {
            _professores.Add(professor);
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

        public void CadastrarTurma(Turma turma)
        {
            _turmas.Add(turma);
        }
    }

    public class Usuario
    {
        public string Nome { get; set; }
        public string Username { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return $"Nome: {Nome}, Username: {Username}, Email: {Email}";
        }
    }

    public class Aluno
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }

        public override string ToString()
        {
            return $"Nome: {Nome}, Data de Nascimento: {DataNascimento.ToShortDateString()}";
        }
    }

    public class Professor
    {
        public string Nome { get; set; }
        public string Especialidade { get; set; }

        public override string ToString()
        {
            return $"Nome: {Nome}, Especialidade: {Especialidade}";
        }
    }

    public class Turma
    {
        public string Nome { get; set; }
        public DateTime DataInicio { get; set; }

        public override string ToString()
        {
            return $"Nome: {Nome}, Data de Início: {DataInicio.ToShortDateString()}";
        }
    }

    public class UsuarioLoginDTO
    {
        public string Username { get; set; }
        public string Senha { get; set; }
    }
}
