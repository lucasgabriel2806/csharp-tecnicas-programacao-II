using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Correcao001
{
    internal class Equipamento
    {
        public Equipamento(string nome, DateTime dataFabricacao)
        {
            Nome = nome;
            DataFabricacao = dataFabricacao;
        }
        public string? Nome { get; set; }
        public DateTime? DataFabricacao { get; set; }
    }
}
