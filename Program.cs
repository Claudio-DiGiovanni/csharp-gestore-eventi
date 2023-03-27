menu();
void menu()
{
    Console.WriteLine("Benvenuto nel gestore degli eventi.");
    Console.WriteLine("Come si deve chiamare la lista degli eventi?");
    var nomeLista = Console.ReadLine();
    var programmazione = new ProgrammaEventi(nomeLista);
    Console.WriteLine("quanti eventi vuoi registrare?");
    var nEventi = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < nEventi; i++)
    {
        try
        {
            Console.WriteLine($"Inserisci l'evento numero {i+1}: ");
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
            while (disdizione)
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

            programmazione.AggiungiEvento(evento);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
            i--;
        }
        

    }
    Console.WriteLine($"Nella lista {programmazione.Titolo} sono presenti {programmazione.NumeroEventi()} eventi.");
    Console.WriteLine(programmazione.Programmazione());
    Console.WriteLine("Inserisci una data da cercare: ( gg/MM/yyyy )");
    var dataDaCercare = Console.ReadLine();
    var listaPerData = programmazione.ListaPerData(dataDaCercare);
    Console.WriteLine($"Eventi in data {dataDaCercare}");
    Console.WriteLine(ProgrammaEventi.StampaLista(listaPerData));
    programmazione.SvuotaListaEventi();


}