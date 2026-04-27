using System;
using System.Collections.Generic;
using System.Linq;

// ================= EXTENSION =================
public static class ListExtensions
{
    public static int SomarImpares(this List<int> lista)
    {
        return lista.Where(x => x % 2 != 0).Sum();
    }
}

// ================= MODELOS =================
class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }
}

class Produto
{
    public string Nome { get; set; }
    public decimal Preco { get; set; }
}

class Cliente
{
    public string Nome { get; set; }
}

class Pedido
{
    public Cliente Cliente { get; set; }
    public List<Produto> Produtos { get; set; }
}

// ================= PROGRAMA =================
class Program
{
    static void Main()
    {
        // ================= PARTE 1 e 2 =================
        Console.WriteLine("=== LISTA DE INTEIROS ===");

        List<int> numeros = new List<int> { 5, 12, 8, 20, 3, 15, 7 };

        int somaImpares = numeros.SomarImpares();
        int maior = numeros.Max();
        int somaMaioresQue10 = numeros.Where(x => x > 10).Sum();

        Console.WriteLine($"Soma dos ímpares: {somaImpares}");
        Console.WriteLine($"Maior número: {maior}");
        Console.WriteLine($"Soma > 10: {somaMaioresQue10}");

        // ================= PARTE 3 =================
        Console.WriteLine("\n=== PESSOAS ===");

        List<Pessoa> pessoas = new List<Pessoa>
        {
            new Pessoa { Nome = "João", Idade = 17 },
            new Pessoa { Nome = "Maria", Idade = 22 },
            new Pessoa { Nome = "Carlos", Idade = 30 }
        };

        var maioresDeIdade = pessoas.Where(p => p.Idade > 18);
        var nomesOrdenados = pessoas
            .OrderBy(p => p.Nome)
            .Select(p => p.Nome)
            .ToList();

        Console.WriteLine("Maiores de 18:");
        foreach (var p in maioresDeIdade)
            Console.WriteLine($"{p.Nome} - {p.Idade}");

        Console.WriteLine("\nNomes ordenados:");
        nomesOrdenados.ForEach(nome => Console.WriteLine(nome));

        // ================= PARTE 4 =================
        Console.WriteLine("\n=== PEDIDOS ===");

        var cliente1 = new Cliente { Nome = "Ana" };
        var cliente2 = new Cliente { Nome = "Bruno" };

        var pedidos = new List<Pedido>
        {
            new Pedido
            {
                Cliente = cliente1,
                Produtos = new List<Produto>
                {
                    new Produto { Nome = "Notebook", Preco = 3000 },
                    new Produto { Nome = "Mouse", Preco = 100 }
                }
            },
            new Pedido
            {
                Cliente = cliente1,
                Produtos = new List<Produto>
                {
                    new Produto { Nome = "Teclado", Preco = 200 }
                }
            },
            new Pedido
            {
                Cliente = cliente2,
                Produtos = new List<Produto>
                {
                    new Produto { Nome = "Monitor", Preco = 1200 }
                }
            }
        };

        // Agrupar pedidos por cliente
        var pedidosPorCliente = pedidos.GroupBy(p => p.Cliente.Nome);

        Console.WriteLine("\nPedidos por cliente:");
        foreach (var grupo in pedidosPorCliente)
        {
            Console.WriteLine($"Cliente: {grupo.Key}");
            foreach (var pedido in grupo)
            {
                Console.WriteLine($"  Pedido com {pedido.Produtos.Count} produtos");
            }
        }

        // Clientes com total acima de 500
        var clientesAcima500 = pedidos
            .GroupBy(p => p.Cliente.Nome)
            .Where(g => g.Sum(p => p.Produtos.Sum(prod => prod.Preco)) > 500)
            .Select(g => g.Key);

        Console.WriteLine("\nClientes com pedidos acima de R$ 500:");
        foreach (var nome in clientesAcima500)
            Console.WriteLine(nome);

        // Total por cliente
        var totalPorCliente = pedidos
            .GroupBy(p => p.Cliente.Nome)
            .Select(g => new
            {
                Cliente = g.Key,
                Total = g.Sum(p => p.Produtos.Sum(prod => prod.Preco))
            });

        Console.WriteLine("\nTotal por cliente:");
        foreach (var item in totalPorCliente)
            Console.WriteLine($"{item.Cliente}: R$ {item.Total}");
    }
}