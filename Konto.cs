using System.Runtime.InteropServices;
using Serilog;

namespace CardsCenter;

public class Konto
{
    private string nrKonta;
    private double saldo;
    private Random randomnrkonta = new Random();
    private List<Karta> listKart;
    private Karta karta;

    public Konto()
    {
        nrKonta = randomnrkonta.Next().ToString();
    }
    
    public Konto(string nrkonta)
    { 
        listKart = new List<Karta>();
        nrKonta = nrkonta;
    }
    
    public String GetNrKonta()
    {
        return nrKonta;
    }

    public void DodajKarte(Karta karta)
    {
        listKart.Add(karta);
        Log.Information("Karta: "+karta.GetNrKarty()+" zostala dodana");
    }
    
    public void UsunKarte(Karta karta)
    {
        listKart.Remove(karta);
        Log.Information("Karta "+karta.GetNrKarty()+" zostala usunieta");
    }
    
    public String GetKarty()
    {
        return String.Join("\n", listKart.Select(x => $"Nr karty:{x.GetNrKarty()}, saldo: {x.GetSaldoKarty()}"));
    }
    
}
