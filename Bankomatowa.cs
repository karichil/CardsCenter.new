namespace CardsCenter;
using Serilog;

public class Bankomatowa:Karta
{
    private Random randomnrkarty = new Random();
    public Bankomatowa(string nrkarty) : base(nrKarty)
    {
        nrKarty = nrkarty;
    }
    
    public Bankomatowa()
    {
        nrKarty = randomnrkarty.Next().ToString();
    }

    public override bool SprawdzAutoryzacje(double kwota)
    {
        return false;
    }

    public override double GetSaldoKarty()
    {
        return Saldo;
    }

    public override string GetNrKarty()
    {
        return nrKarty;
    }

    public override void WyplacZKarty(double kwota)
    {
        if (kwota <= Saldo)
        {
            Console.WriteLine("Kwota "+kwota+" zostala wyplacona.");
            Saldo -= kwota;
            //SprawdzAutoryzacje(kwota);
            Log.Information("Platnosc: karta bankomatowa "+Karta.nrKarty+" wyplacona kwota "+kwota);
        }
        else if (kwota > Saldo)
        {
            Console.WriteLine("Nie możesz wypłacić tej kwoty, nie posiadasz takiech srodkow na koncie!");
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
            Console.WriteLine("Wplata " + kwota + " , saldo karty wynosi " + Saldo);
            Log.Information("Na karte bankomatowa "+Karta.nrKarty+" zostala wplacona kwota "+Saldo);
        }
        else
        {
            Console.WriteLine("Niepoprawna kwota!");
        }
    }
}
