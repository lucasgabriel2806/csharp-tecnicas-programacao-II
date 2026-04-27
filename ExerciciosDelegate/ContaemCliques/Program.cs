using System;

// Delegate sem parâmetros
public delegate void CliqueHandler();

class Botao
{
    public event CliqueHandler Clique;

    public void SimularClique()
    {
        Console.WriteLine("Botão clicado!");
        Clique?.Invoke();
    }
}

class ContadorCliques
{
    private int totalCliques = 0;

    public void AoClicar()
    {
        totalCliques++;
        Console.WriteLine($"Total de cliques: {totalCliques}");
    }
}

class Program
{
    static void Main()
    {
        Botao botao = new Botao();
        ContadorCliques contador = new ContadorCliques();

        botao.Clique += contador.AoClicar;

        botao.SimularClique();
        botao.SimularClique();
        botao.SimularClique();
    }
}