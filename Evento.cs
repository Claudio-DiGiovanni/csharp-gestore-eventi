using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Evento
{
    string titolo;
    DateOnly data;
    int capienzaMax;
    int prenotazioni;

    public Evento(string titolo, string data, int capienzaMax)
    {
        Titolo = titolo;
        Data = DateOnly.ParseExact(data, "dd/MM/yyyy", null);
        CapienzaMax = capienzaMax;
        Prenotazioni = 0;
    }

    public string Titolo
    {
        get => titolo;
        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                titolo = value;
            }
            else
            {
                throw new ArgumentException("Il campo titolo non può essere vuoto");
            }
        }
    }
    public DateOnly Data
    {
        get => data;
        set
        {
            if (value > DateOnly.FromDateTime(DateTime.Now))
            {
                data = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(value), "La data deve essere superiore rispetto alla data odierna");
            }
        }
    }
    public int CapienzaMax { get => capienzaMax; private set { 
            if (value > 0)
            {
                capienzaMax = value;
            } 
            else
            {
                throw new ArgumentOutOfRangeException(nameof(value), "La capienza massima non può essere minore di zero");
            }
        } 
    }
    public int Prenotazioni { get => prenotazioni; private set => prenotazioni = value; }

    public void PrenotaPosti(int posti)
    {
       if (DateOnly.FromDateTime(DateTime.Now) > data)
        {
            throw new InvalidOperationException("L'evento è già passato");
        }
       else if (capienzaMax < posti || prenotazioni + posti > capienzaMax)
        {
            throw new InvalidOperationException("L'evento non ha abbastanza posti disponibili per la prenotazione richiesta");
        }
       else
        {
            prenotazioni += posti;
        }
    }
    public void DisdiciPosti(int posti)
    {
        if (DateOnly.FromDateTime(DateTime.Now) > data)
        {
            throw new InvalidOperationException("L'evento è già passato");
        }
        else if (capienzaMax < posti || prenotazioni - posti < 0)
        {
            throw new InvalidOperationException("L'evento non ha abbastanza posti prenotati per disdire la richiesta");
        }
        else
        {
            prenotazioni -= posti;
        }
    }

    public override string ToString()
    {
        return $"{data} - {titolo}";
    }
}

