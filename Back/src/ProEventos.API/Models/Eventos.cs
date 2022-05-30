using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProEventos.API.Models
{
    public class Eventos
    {
        public int EventosId { get; set; }
        public string Local { get; set; }
        public string DataEvento { get; set; }
        public string Evento { get; set; }
        public int QtdPessoas { get; set; }
        public string Vendas { get; set; }
        public string ImagemURL { get; set; }
    }
}