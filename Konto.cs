using Serilog;

namespace CardsCenter;

public class Konto
{
    private string nrKonta;
    private double saldo;
    private Random randomnrkonta = new Random();
    private List<Karta> listKart;

    public Konto()
    {
        nrKonta = randomnrkonta.Next().ToString();
    }
    
    public Konto(string nrkonta)
    {
        if (listKart == null)
        {
            listKart = new List<Karta>();
        }
        nrKonta = nrkonta;
    }

    public double GetSaldo()
    {
        return saldo;
    }

    public String GetNrKonta()
    {
        return nrKonta;
    }

    public void DodajKarte(Karta karta)
    {
        karta.Saldo = saldo;
        karta.konto = this;
        listKart.Add(karta);
        Log.Information("Zostala dodana nowa "+karta);
    }
    
    public void UsunKarte(Karta karta)
    {
        listKart.Remove(karta);
        Log.Information("Karta "+karta+" zostala usunieta");
    }
    
    public void Wyplac(double kwota)
    {
        if (kwota <= saldo)
        {
            saldo -= kwota;
            Console.WriteLine("Kwota "+kwota+" zostala wyplacona.");
            Log.Information("Kwota "+kwota+" zostala wyplacona, saldo konta"+ GetNrKonta() +"wynosi "+saldo);
        }
        else if (kwota > saldo)
        {
            Console.WriteLine("Na koncie nie ma takiej kwoty, saldo wynisi "+saldo);
            Log.Information("Blad transakcji, na koncie nie ma takich srodkow");
        }
        else
        {
            Console.WriteLine("Niepoprawna kwota!");
        }

        UpdateSaldo(saldo);
    }

    public void Wplac(double kwota)
    {
        if (kwota >= 0)
        {
            saldo += kwota;
            Console.WriteLine("Kwota "+kwota+" zostala wplacona, saldo konta wynosi "+ saldo);
            Log.Information("Kwota "+kwota+" zostala wplacona, saldo konta wynosi "+ saldo);
        }
        else
        {
            Console.WriteLine("Niepoprawna kwota!");
        }
        UpdateSaldo(saldo);
    }

    public String GetKarty()
    {
        return String.Join("\n", listKart.Select(x => $"Nr karty:{x.GetNrKarty()}, saldo: {x.GetSaldoKarty()}"));
    }

    public void UpdateSaldo(double updatesaldo)
    {
        saldo = updatesaldo;
        foreach ( var karta in listKart) {
            karta.Saldo = saldo;
        }
    }
    
}
