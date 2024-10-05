using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteDicionario.Domain;

namespace TesteDicionario.Infrastructure.Interface
{
    public interface EventoRepositoryInterface
    {
        List<Evento> getAll();
        void AddEvento(Evento evento);
    }
}
