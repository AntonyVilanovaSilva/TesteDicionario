using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteDicionario.Domain;

namespace TesteDicionario.Infrastructure
{
    public class EventosRepositoryDesconto
    {
        public List<EventoDesconto> GetAll()
        {
            var dbEventosDesconto = new List<EventoDesconto>() 
            { 
                new EventoDesconto()
                {
                     Id = 1,
                     ValorDesconto =5
                },
                new EventoDesconto()
                {
                    Id= 2,
                    ValorDesconto =5
                }
            };

            return dbEventosDesconto;
        }
    }
}
