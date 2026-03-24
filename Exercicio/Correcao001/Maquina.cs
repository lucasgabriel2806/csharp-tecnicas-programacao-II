using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Correcao001
{
    internal class Maquina : Equipamento
    {
        public Maquina(string modelo, string horaOperacao, string obs, string? nome, DateTime? dataFabricacao) : base(nome, dataFabricacao)
        {
            Modelo = modelo;
            HoraOperacao = horaOperacao;
            Observacao = obs;
        }
        public string? Modelo { get; set; }
        public string? HoraOperacao { get; set; }

        private Guid numeroSerie = new Guid();
        public Guid NumeroSerie 
        { 
            get { return numeroSerie; }
        }
        private string? observacao;
        public string? Observacao 
        { 
            set { observacao = value; }
        }
    }
}
