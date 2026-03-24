using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Correcao001
{
    internal class Fabrica
    {
        public Fabrica(string nomeFabrica, string modelo, string horaOperacao, string obs, string? nome, DateTime? dataFabricacao)
        {
            Nome = nomeFabrica;
            MaquinaFabrica.Add(new Maquina(modelo, horaOperacao, obs, nome, dataFabricacao));
        }
        public string? Nome { get; set; }
        public ICollection<Maquina> MaquinaFabrica { get; set; } = new List<Maquina>();
        
        public void AdicionarMaquina(string modelo, string horaOperacao, string obs, string? nome, DateTime? dataFabricacao)
        {
            MaquinaFabrica.Add(new Maquina(modelo, horaOperacao, obs, nome, dataFabricacao));
        }
        public void ListarMaquinas()
        {
            foreach(var maquina in MaquinaFabrica)
            {
                Console.WriteLine($"Modelo: {maquina.Modelo}\nHoras Operação: {maquina.HoraOperacao}\n" +
                                  $"Número de Serie: {maquina.NumeroSerie}\nNome do Equipamento: {maquina.Nome}\n" +
                                  $"Data da Fabricação: {maquina.DataFabricacao}");
            }
        }

        public ICollection<Maquina> BuscarMaquinasPorModelo(string modelo)
        {
            //foreach (var maquina in MaquinaFabrica)
            //{
            //    if(maquina.Modelo == modelo)
            //    {
            //        return maquina;
            //    }
            //}
            //return null;

            var lista = MaquinaFabrica.ToList();
            var maquina = lista.Find(m => m.Modelo == modelo);
            return maquina;
        }
    }
}
