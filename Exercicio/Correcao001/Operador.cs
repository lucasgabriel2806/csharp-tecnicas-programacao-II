using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Correcao001
{
    class Operador
    {
        public Operador(string nome, Maquina maquinaOperador)
        {
            Nome = nome;
            MaquinaOperador = maquinaOperador;            
        }
        public string? Nome { get; set; }
        public Maquina? MaquinaOperador { get; set; }

        public async Task OperarMaquinaAsync(Fabrica fabrica, string modelo)
        {
            Console.WriteLine($"{Nome} está tentando operar a máquina modelo {MaquinaOperador.Modelo}");
            await Task.Delay(2000);
            var maquina = fabrica.BuscarMaquinasPorModelo(modelo);
            if (maquina == null)
            {
                Console.WriteLine($"Máquina Modelo {modelo} não enciontrada na Fábrica {fabrica.Nome};");
            }
            else
            {
                Console.WriteLine($"{Nome} agora está operando a máquina modelo {maquina.Modelo}");
                await Task.Delay(2000);
            }
        }
    }
}
