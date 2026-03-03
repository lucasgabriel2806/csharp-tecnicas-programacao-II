Aluno aluno1 = new Aluno("Maria", "12345678900", "2023001");

Console.WriteLine($"Nome: {aluno1.Nome} \n " +
                  $"CPF: {aluno1.Cpf} \n " +
                  $"RA: {aluno1.Ra}");

Console.WriteLine("Digite o nome do professor: ");
var nomeProfessor = Console.ReadLine();

Console.WriteLine("Digite o CPF do professor: ");
var cpfProfessor = Console.ReadLine();

Console.WriteLine("Digite a titulação do professor: ");
var titulacaoProfessor = Console.ReadLine();

Professor professor1 = new Professor(nomeProfessor, cpfProfessor, titulacaoProfessor);
Professor.Exibir(professor1);

Console.ReadKey();

public class Pessoa
{
    public Pessoa(string? nome, string? cpf)
    {
        Nome = nome;
        Cpf = cpf;
    }
    public string? Nome { get; set; }
    public string? Cpf { get; set; }

}

public class Aluno : Pessoa
{
    public Aluno(string? nome, string? cpf, string? ra) : base(nome, cpf)
    {
        Ra = ra;           
    }
    public string? Ra { get; set; }
}

public class Professor : Pessoa
{
    public Professor(string? nome, string? cpf, string? titulacao) : base(nome, cpf)
    {
        Titulacao = titulacao;
    }
    public static void Exibir(Professor professor) => Console.WriteLine($"Nome: {professor.Nome} \n" +
                                                                    $"CPF: {professor.Cpf} \n" +
                                                                    $"Titulação: {professor.Titulacao}");
    public string? Titulacao { get; set; }
}