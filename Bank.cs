using Serilog;

namespace CardsCenter;
public class Bank:KlientCentrum
{
    private List<KlientBanku> listaKlientow;
    private string nazwa;
    private ILogger _logger;

    public Bank()
    {
        nazwa = "Bank";
    }

    public Bank(string nazwabanku)
    {
        nazwa = nazwabanku;
        if (listaKlientow == null)
        {
            listaKlientow = new List<KlientBanku>();
        }
    }

    public void DodajKlienta(KlientBanku klient)
    {
        listaKlientow.Add(klient);
        Log.Information("Zostal dodany nowy klient "+klient);
    }

    public void UsunKlienta(KlientBanku klient)
    {
        listaKlientow.Remove(klient);
        Log.Information("Z banku zostal usuniety klient "+klient);
        
    }
    
    public String GetKlienci()
    {
        return String.Join("\n", listaKlientow.Select(x => $"Konto:{x.GetKonta()}"));
    }
    
}