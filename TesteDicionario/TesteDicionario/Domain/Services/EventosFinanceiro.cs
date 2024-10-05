using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteDicionario.Domain.Services
{
    public class EventosFinanceiro
    {
        public double atualizarValorTransacao(Evento objEvento, EventoDesconto objDesconto)
        {
            return objEvento.ValorTransacao - objEvento.ValorTransacao;
        }
    }
}
