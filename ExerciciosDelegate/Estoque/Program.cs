using System;

// Classe para dados do evento
public class EstoqueEventArgs : EventArgs
{
    public string Produto { get; set; }
    public int Quantidade { get; set; }
}

class Estoque
{
    public string Produto { get; set; }
    public int Quantidade { get; private set; }
    public int LimiteMinimo { get; set; } = 5;

    public event EventHandler<EstoqueEventArgs> EstoqueBaixo;

    public void Remover(int quantidade)
    {
        Quantidade -= quantidade;
        Console.WriteLine($"Estoque atual de {Produto}: {Quantidade}");

        if (Quantidade < LimiteMinimo)
        {
            EstoqueBaixo?.Invoke(this, new EstoqueEventArgs
            {
                Produto = Produto,
                Quantidade = Quantidade
            });
        }
    }
}

class AlertaEstoque
{
    public void AoEstoqueBaixo(object sender, EstoqueEventArgs e)
    {
        Console.WriteLine($"⚠️ Estoque baixo! Produto: {e.Produto}, Quantidade: {e.Quantidade}");
    }
}

class Program
{
    static void Main()
    {
        Estoque estoque = new Estoque
        {
            Produto = "Mouse",
            Quantidade = 10,
            LimiteMinimo = 5
        };

        AlertaEstoque alerta = new AlertaEstoque();

        estoque.EstoqueBaixo += alerta.AoEstoqueBaixo;

        estoque.Remover(3);
        estoque.Remover(3); // dispara evento
    }
}