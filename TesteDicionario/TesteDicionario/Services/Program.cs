using TesteDicionario.Domain;

var dbEvento = new List<Evento>() {

    new Evento()
    {
        ID = 1,
        Descricao ="Ev1",
        ValorTransacao =10
    },

    new Evento() { 
        ID = 2,
        Descricao ="Ev2",
        ValorTransacao =10
    },

    new Evento() { 
        ID = 3,
        Descricao ="Ev3",
        ValorTransacao =10
    }
};

var dbEventosDesconto = new List<EventoDesconto>()
{
    new EventoDesconto()
    {
        Id = 1,
        ValorDesconto =5
    },
    new EventoDesconto()
    {
        Id = 3,
        ValorDesconto =3
    },

};

var descontosDicionarios = dbEventosDesconto.ToDictionary(x => x.Id, x => x);

foreach (var item in dbEvento)
{
    if (descontosDicionarios.TryGetValue(item.ID, out var descontos))
    {
        var ValorDescontado = item.ValorTransacao - descontos.ValorDesconto;
        Console.WriteLine($"Chave {item.ID} Valor Anterior {item.ValorTransacao} ValorTransaçãoFinal {ValorDescontado}");
    }
    else
    {
        Console.WriteLine($"Chave {item.ID}" +
    $"Continuou o mesmo");
    }
}