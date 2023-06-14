using Serilog;

namespace CardsCenter;
public class Bank:KlientCentrum
{
    private List<KlientBanku> listaKlientow;
    private string nazwaBanku;

    public Bank()
    {
        nazwaBanku = "Bank";
        listaKlientow = new List<KlientBanku>();
    }

    public Bank(string nazwabanku)
    {
        nazwaBanku = nazwabanku;
        listaKlientow = new List<KlientBanku>();
    }

    public string GetNazwaBanku()
    {
        return nazwaBanku;
    }

    public void DodajKlienta(Osoba osoba)
    {
        listaKlientow.Add(osoba);
        Log.Information("Klient banku: "+ osoba.GetOsoba()+" zostal dodany");
    }

    public void UsunKlienta(Osoba osoba)
    {
        listaKlientow.Remove(osoba);
        Log.Information("Klient banku: "+ osoba.GetOsoba()+" zostal usuniety");
        
    }
    
    public String GetKlienci()
    {
        return String.Join("\n", listaKlientow.Select(x => $"Konto:{x.GetKonta()}"));
    }

    public override string GetKlientCentrum()
    {
        return GetNazwaBanku();
    }
}