using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppEventos.Models
{
    public class EventoContratado
    {
        public Evento EventoEscolhido { get; set; }
        public int QntIngresso { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFinal { get; set; }

        // Agora retornam os valores do Evento escolhido quando não atribuídos explicitamente
        public double ValorIngresso => EventoEscolhido?.ValorIngresso ?? 0.0;

        public string Lugar => EventoEscolhido?.Lugar ?? string.Empty;

        public int TotalDias => (DataFinal - DataInicio).Days + 1;

        public double ValorTotal => QntIngresso * ValorIngresso;
    }
}
