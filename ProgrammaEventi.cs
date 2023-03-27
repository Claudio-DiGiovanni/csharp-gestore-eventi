using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class ProgrammaEventi
{
    string titolo;
    List<Evento> eventi;

    public string Titolo { get => titolo; private set => titolo = value; }

    public ProgrammaEventi(string titolo)
    {
        this.Titolo = titolo;
        this.eventi = new List<Evento>();
    }
    public void AggiungiEvento(Evento evento)
    {
        eventi.Add(evento);
    }

    public List<Evento> ListaPerData(string data)
    {
        var eventiPerData = new List<Evento>();
        var dataDaCercare = DateOnly.ParseExact(data, "dd/MM/yyyy", null);

        foreach (var evento in eventi)
        {
            if (evento.Data == dataDaCercare)
            {
                eventiPerData.Add(evento);
            }
        }

        return eventiPerData;
    }

    public int NumeroEventi()
    {
        return eventi.Count;
    }

    public void SvuotaListaEventi()
    {
        eventi.Clear();
    }

    public static string StampaLista(List<Evento> lista)
    {
        var nl = Environment.NewLine;
        string result = "";
        foreach (var evento in lista)
        {
            result += evento.ToString() + nl;
        }
        return result;
    }

    public string Programmazione()
    {
        var nl = Environment.NewLine;
        var programmazione = titolo + nl;
        foreach ( var evento in eventi)
        {
            programmazione += evento.ToString() + nl;
        }
        return programmazione;
      
    }
}

