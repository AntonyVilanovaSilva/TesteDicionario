using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteDicionario.Domain;
using TesteDicionario.Infrastructure.Interface;

namespace TesteDicionario.Infrastructure
{
    public class EventoRepository : EventoRepositoryInterface
    {
         public void AddEvento(Evento evento)
         {
            throw new NotImplementedException();
         }

        public List<Evento> GetAll()
        {
            var dbEventos = new List<Evento>() 
            { 
              new Evento()
              {
                  ID = 1,
                  Descricao ="Ev1",
                  ValorTransacao =10 
              },
              new Evento()
              {
                   ID = 2,
                  Descricao ="Ev2",
                  ValorTransacao =10
              },
              new Evento()
              {

                  ID = 3,
                  Descricao ="Ev3",
                  ValorTransacao =10
              }

            };
            return dbEventos;
        }

        public List<Evento> getAll()
        {
            throw new NotImplementedException();
        }
    }
    
}
