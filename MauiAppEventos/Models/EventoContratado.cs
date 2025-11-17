using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppEventos.Models
{
    class EventoContratado
    {
        public Evento EventoEscolhido { get; set;  }
        public int QntIngresso { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFinal { get; set; }

        public double ValorIngresso { get; set; }

        public string Lugar { get; set; }


        

         
        
    }
}
