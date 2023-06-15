namespace CardsCenter;
using Serilog;

public class Kredytowa:Karta
{
    private double dlug, limit;
    private Random randomnrkarty = new Random();

    public Kredytowa(string nrkarty) : base(nrKarty)
    {
        nrKarty = nrkarty;
        dlug = 0;
        limit = -50000;
    }
    public Kredytowa()
    {
        nrKarty = randomnrkarty.Next().ToString();
    }

    public override double GetSaldoKarty()
    {
        return Saldo;
    }

    public override string GetNrKarty()
    {
        return nrKarty;
    }
    
    public override bool SprawdzAutoryzacje(double kwota)
    {
        if (kwota <= Saldo)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    

    public override void WyplacZKarty(double kwota)
    {
        if (kwota <= limit)
        {
            Console.WriteLine("Kwota "+kwota+" zostala wyplacona, dlug wynosi "+dlug);
            dlug -= kwota;
            Log.Information("Platnosc: karta kredotowa "+Karta.nrKarty+" nalozony dlug "+dlug);
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
            Log.Information("Wplata " + kwota + ", dlug wynosi "+dlug);
        }
        else
        {
            Console.WriteLine("Nie mozesz wplacac na karte kredytowa jesli nie masz dlugu!");
        }
    }
}