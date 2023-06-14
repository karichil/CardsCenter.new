namespace CardsCenter;
using Serilog;
public abstract class Karta
{
    public double Saldo;
    public Konto konto;
    protected static string nrKarty;
    protected Random randomnrkonta = new Random();

    public Karta()
    {
        nrKarty = randomnrkonta.Next().ToString();
    }
    public Karta(string nrk)
    {
        nrKarty = nrk;
    }

    public abstract double GetSaldoKarty();
    public abstract string GetNrKarty();

    public abstract void WyplacZKarty(double kwota);

    public abstract void WplacNaKarte(double kwota);
}    