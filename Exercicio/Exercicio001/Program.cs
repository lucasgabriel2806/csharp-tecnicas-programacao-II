using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

class Equipamento
{
    public string Nome { get; set; }
    public DateTime DataFabricacao { get; set; }
}

class Maquina : Equipamento
{
    public string Modelo { get; set; }
    public string HoraOperacao { get; set; }

    public Guid NumeroSerie { get; } = Guid.NewGuid();

    private string _observacao;

    public string Observacao
    {
        set { _observacao = value; }
    }
}

public class Fabrica
{
    public string Nome { get; set; }

    public ICollection<Maquina> Maquinas { get; set; }

    public Fabrica()
    {
        Maquinas = new List<Maquina>();
    }

    public void AdicionarMaquina(Maquina maquina)
    {
        Maquinas.Add(maquina);
    }

    public void ListarMaquinas()
    {
        foreach (var m in Maquinas)
        {
            Console.WriteLine($"Nome: {m.Nome}");
            Console.WriteLine($"Modelo: {m.Modelo}");
            Console.WriteLine($"Data Fabricação: {m.DataFabricacao:dd/MM/yyyy}");
            Console.WriteLine($"Número Série: {m.NumeroSerie}");
            Console.WriteLine("---------------------");
        }
    }

    public Maquina BuscarMaquinaPorModelo(string modelo)
    {
        return Maquinas.FirstOrDefault(
            m => m.Modelo.Equals(modelo, StringComparison.OrdinalIgnoreCase)
        );
    }
}

public class Operador
{
    public string Nome { get; set; }

    public async Task OperarMaquinaAsync(Fabrica fabrica, string modelo)
    {
        Console.WriteLine($"{Nome} está tentando operar a máquina modelo {modelo}");

        await Task.Delay(2000);

        Maquina maquina = fabrica.BuscarMaquinaPorModelo(modelo);

        if (maquina == null)
        {
            Console.WriteLine($"Máquina modelo {modelo} não encontrada na fábrica {fabrica.Nome}");
            return;
        }

        Console.WriteLine($"{Nome} agora está operando a máquina modelo {maquina.Modelo}");

        await Task.Delay(3000);
    }
}

class Program
{
    static async Task Main(string[] args)
    {
        Fabrica fabrica = new Fabrica
        {
            Nome = "Fabrica Tech"
        };

        Maquina m1 = new Maquina
        {
            Nome = "Cortadora",
            Modelo = "X100",
            DataFabricacao = new DateTime(2022, 5, 10),
            HoraOperacao = "08:00 - 17:00"
        };
        m1.Observacao = "Máquina nova";

        Maquina m2 = new Maquina
        {
            Nome = "Prensa",
            Modelo = "Y200",
            DataFabricacao = new DateTime(2023, 2, 15),
            HoraOperacao = "09:00 - 18:00"
        };
        m2.Observacao = "Alta pressão";

        fabrica.AdicionarMaquina(m1);
        fabrica.AdicionarMaquina(m2);

        Console.WriteLine("=== LISTA DE MÁQUINAS ===");
        fabrica.ListarMaquinas();

        Operador operador = new Operador
        {
            Nome = "Carlos"
        };

        Console.WriteLine("\n=== OPERAÇÃO ===");
        await operador.OperarMaquinaAsync(fabrica, "X100");

        Console.WriteLine("\n=== TESTE COM MODELO INEXISTENTE ===");
        await operador.OperarMaquinaAsync(fabrica, "Z999");
    }
}