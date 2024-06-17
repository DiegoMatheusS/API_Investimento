using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using API_Investimento.Models;
using Investimento.Models;
using Investimento.Models.Enuns;

namespace Investimento.Models
{
    public class Moeda
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public double Valor { get; set; }
        public double Quantidade { get; set; }
        public DateTime Data { get; set; }
        public double Lucro { get; set; }
        public double Prejuizo { get; set; }
        public double Imposto { get; set; }
        public int? UsuarioId { get; set; }
	    public OperacaoEnum Operacao { get; set; }

        [JsonIgnore]
        public Usuario? Usuario { get; set; }
    }
}