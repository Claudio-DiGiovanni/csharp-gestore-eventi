
menu();
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