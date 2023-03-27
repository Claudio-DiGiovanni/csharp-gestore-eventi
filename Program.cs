
var evento1 = new Evento("Ciao", "15/07/2023", 150);
var evento2 = new Evento("Ciao", "15/07/2023", 150);
var evento3 = new Evento("Ciao", "15/07/2023", 150);
var evento4 = new Evento("Ciao", "15/07/2023", 150);
var evento5 = new Evento("Ciao", "15/07/2023", 150);
var evento6 = new Evento("Ciao", "15/07/2023", 150);
var evento7 = new Evento("Ciao", "15/07/2023", 150);
var evento8 = new Evento("Ciao", "15/07/2023", 150);
var evento9 = new Evento("Ciao", "15/07/2023", 150);
var evento10 = new Evento("Ciao", "15/07/2023", 150);
var evento11 = new Evento("Ciao", "15/07/2023", 150);
var evento12 = new Evento("Ciao", "15/07/2023", 150);
var evento13 = new Evento("Ciao", "15/07/2023", 150);
var evento14 = new Evento("Ciao", "15/07/2023", 150);
var evento15= new Evento("Ciao", "15/07/2023", 150);
var evento16 = new Evento("Ciao", "15/07/2023", 150);

var programmazione = new ProgrammaEventi("Programmazione");

programmazione.AggiungiEvento(evento1);
programmazione.AggiungiEvento(evento2);
programmazione.AggiungiEvento(evento3);
programmazione.AggiungiEvento(evento4);
programmazione.AggiungiEvento(evento5);
programmazione.AggiungiEvento(evento6);
programmazione.AggiungiEvento(evento7);
programmazione.AggiungiEvento(evento8);
programmazione.AggiungiEvento(evento9);
programmazione.AggiungiEvento(evento10);
programmazione.AggiungiEvento(evento11);
programmazione.AggiungiEvento(evento12);
programmazione.AggiungiEvento(evento13);
programmazione.AggiungiEvento(evento14);
programmazione.AggiungiEvento(evento15);
programmazione.AggiungiEvento(evento16);

Console.WriteLine(programmazione.Programmazione());
void menu()
{
    Console.WriteLine("Inserisci un nuovo evento: ");
    Console.WriteLine("Inserisci titolo dell'evento: ");
    var titolo = Console.ReadLine();
    Console.WriteLine("Inserisci la data dell'evento ( gg/mm/yyyy ): ");
    var data = Console.ReadLine();
    Console.WriteLine("Inserisci la capienza massima dell'evento: ");
    var capienzaMax = Convert.ToInt32(Console.ReadLine());
    var evento = new Evento(titolo, data, capienzaMax);
    Console.WriteLine("Vuoi fare delle prenotazioni? ( y / N )");
    var input = Console.ReadLine();
    if (input == "y")
    {
        Console.WriteLine("Quanti posti vuoi prenotare?");
        var prenotazioni = Convert.ToInt32(Console.ReadLine());
        evento.PrenotaPosti(prenotazioni);
    }
    Console.WriteLine($"I posti disponibili per l'evento {evento.Titolo} sono {evento.CapienzaMax - evento.Prenotazioni}.");
    Console.WriteLine($"Sono stati prenotati {evento.Prenotazioni} posti su {evento.CapienzaMax}.");
    var disdizione = true;
    while(disdizione)
    {
        Console.WriteLine("Vuoi disdire dei posti? ( y / N )");
        var input2 = Console.ReadLine();
        if (input2 == "y")
        {
            Console.WriteLine("Quanti posti vuoi disdire?");
            var disdici = Convert.ToInt32(Console.ReadLine());
            evento.DisdiciPosti(disdici);
            Console.WriteLine($"Sono stati prenotati {evento.Prenotazioni}.");
            Console.WriteLine($"Rimangono {evento.CapienzaMax - evento.Prenotazioni} disponibili.");
        }
        else disdizione = false;
    }
    evento.ToString();
    Console.WriteLine($"Sono stati prenotati {evento.Prenotazioni}.");
    Console.WriteLine($"Rimangono {evento.CapienzaMax - evento.Prenotazioni} disponibili.");
}