using Composicao;
// Composição do lado de Pessoa(Bilateral) Pessa->Celular
Pessoa pessoa1 = new Pessoa("João", 11, "999999999");
pessoa1.SetCelular(14, "9888888888");
Console.WriteLine("Composição do lado do Todo(Pessoa->Celular)");
Console.WriteLine($"Nome: {pessoa1.Nome}");
foreach (var dado in pessoa1.Celulares)
{
    Console.WriteLine($"({dado.Ddd}) - {dado.Numero}");
}

// Composição do lado de Celular(Bilateral) Celular->Pessoa
Pessoa pessoa2 = new Pessoa("Maria");
Celular cel1 = new Celular(21, "977777777", pessoa2);
Console.WriteLine("Composição do lado da Parte(Celular->Pessoa)");
Console.WriteLine($"Nome: {cel1.ProprietarioCelular.Nome} - Celular: ({cel1.Ddd}){cel1.Numero}");


namespace Composicao
{
    class Pessoa
    {
        public Pessoa(string nome, int ddd, string numero)
        {
            Nome = nome;
            Celulares.Add(new Celular(ddd, numero));
        }
        public Pessoa(string nome)
        {
            Nome = nome;
        }
        public void SetCelular(int ddd, string numero)
        {
            Celulares.Add(new Celular(ddd, numero));
        }
        public string? Nome { get; set; }
        public List<Celular> Celulares = new List<Celular>();

    }
    class Celular
    {
        public Celular(int ddd, string numero)
        {
            Ddd = ddd;
            Numero = numero;
        }

        public Celular(int ddd, string numero, Pessoa pessoa)
        {
            Ddd = ddd;
            Numero = numero;
            ProprietarioCelular = pessoa;
        }

        public int Ddd { get; set; }
        public string Numero { get; set; }
        public Pessoa ProprietarioCelular { get; set; }
    }
}
