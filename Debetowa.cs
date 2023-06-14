using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;
using Serilog;

namespace CardsCenter;

public class Debetowa:Karta
{
    private double limit;
    public Debetowa(string nrkarty) : base(nrKarty)
    {
        nrKarty = nrkarty;
        limit = -1000;
    }

    public override string GetNrKarty()
    {
        return nrKarty;
    }
    
    public override void WyplacZKarty(double kwota)
    {
        if (kwota <= Saldo-limit)
        {
            Console.WriteLine("Kwota "+kwota+" zostala wyplacona.");
            Saldo -= kwota;
            konto.UpdateSaldo(Saldo);
            Log.Information("Z karty debetowej "+Karta.nrKarty+" zostala wyplacona kwota "+kwota);
        }
        else if (kwota > Saldo-limit)
        {
            double max = Saldo - limit;
            Console.WriteLine("Limit został przekroczony mozesz wyplacic max : "+max);
        }
        else
        {
            Console.WriteLine("Niepoprawna kwota!");
        }
    }

    public override void WplacNaKarte(double kwota)
    {
        if (kwota > 0)
        {
            Saldo += kwota;
            Console.WriteLine("Kwota " + kwota + " zostala wplacona, saldo karty wynosi " + Saldo);
            Log.Information("Na karte debetowa "+Karta.nrKarty+" zostala wplacona kwota "+Saldo);
        }
        else
        {
            Console.WriteLine("Niepoprawna kwota!");
        }
    }
}