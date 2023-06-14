namespace CardsCenter;
using Serilog;

public class Kredytowa:Karta
{
    private double dlug, limit;

    public Kredytowa(string nrkarty) : base(nrKarty)
    {
        nrKarty = nrkarty;
        dlug = 0;
        limit = -50000;
    }

    public override string GetNrKarty()
    {
        return nrKarty;
    }
    

    public override void WyplacZKarty(double kwota)
    {
        if (kwota <= limit)
        {
            Console.WriteLine("Kwota "+kwota+" zostala wyplacona, dlug wynosi "+dlug);
            dlug -= kwota;
            Log.Information("Na karte kredotowa "+Karta.nrKarty+" zostal nalozony dlug "+dlug);
        }
        else if (kwota > limit)
        {
            Console.WriteLine("Limit został przekroczony mozesz wyplacic max : "+limit);
        }
        else
        {
            Console.WriteLine("Niepoprawna kwota!");
        }
    }

    public override void WplacNaKarte(double kwota)
    {
        if (dlug < 0)
        {
            dlug += kwota;
            Log.Information("Na karte kredotowa "+Karta.nrKarty+" zostala wlpacona ktowa  "+kwota+" dlug wynosi "+dlug);
        }
        else
        {
            Console.WriteLine("Nie mozesz wplacac na karte kredytowa jesli nie masz dlugu!");
        }
    }
}