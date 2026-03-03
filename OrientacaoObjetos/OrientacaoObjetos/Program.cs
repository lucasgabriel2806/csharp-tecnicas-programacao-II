// Usando

using OrientacaoObjetos;

Produto produto1 = new Produto();
produto1.Nome = "Notebook";
produto1.Preco = 3500.00;

Produto produto2 = new Produto("Mouse", 14.99);

Console.WriteLine("Nome: " + produto1.Nome);
Console.WriteLine($"Preço: {produto1.Preco}");

Console.WriteLine();

Console.WriteLine("Nome: " + produto2.Nome);
Console.WriteLine($"Preço: {produto2.Preco}");

Console.WriteLine();

// objeto Produto2

Produto2 produto3 = new("Teclado", 25.50, 100);
produto3.Exibir();

Console.ReadKey();

// Declarando

public class Produto
{
    public Produto(){}
    public Produto(string nome, double Preco)
    {
        Nome = nome;
        this.Preco = Preco;
    }
    public string? Nome { get; set; }

    public double Preco { get; set; }
}