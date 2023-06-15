namespace CardsCenter;
using Serilog;
public abstract class Karta
{
    public double Saldo;
    public Konto konto;
    protected static string nrKarty;
    
    public Karta(string nrk)
    {
        nrKarty = nrk;
    }

    public Karta(){}
    
    public abstract bool SprawdzAutoryzacje(double kwota);

    public abstract double GetSaldoKarty();
    public abstract string GetNrKarty();

    public abstract void WyplacZKarty(double kwota);

    public abstract void WplacNaKarte(double kwota);
}    