using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteDicionario.Domain;
using TesteDicionario.Domain.Services;

namespace TesteDicionario.Services
{
    public class EventosDescontosServices 
    {
        private readonly EventosFinanceiro _regras;  

        public EventosDescontosServices()
        {
            _regras = new EventosFinanceiro();
        }

        public Dictionary<int, EventoDesconto> getDicionario(List<EventoDesconto> descontos)
        {
            return descontos.ToDictionary(x => x.Id, x => x);
        }

        public List<Evento> atualizarEventos(List<Evento> eventos,
            Dictionary<int, EventoDesconto>  dicionario) 
        { 
          foreach (var item in eventos)
            {
                if (dicionario.TryGetValue(item.ID, out var descontos))
                {
                    item.ValorTransacao = _regras.atualizarValorTransacao(item, descontos);
                }
            }
          return eventos;
        }
    }
}
