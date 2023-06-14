namespace CardsCenter;
using Serilog;

public abstract class KlientBanku
{
    private List<Konto> listaKont;
    public KlientBanku()
    {
        if (listaKont==null)
        {
            listaKont = new List<Konto>();   
        }
    }

    public void DodajKonto(Konto konto)
    {
        listaKont.Add(konto);
        Log.Information("Zostalo dodane nowe konto "+konto);
        
    }
    
    public void UsunKonto(Konto konto)
    {
        listaKont.Remove(konto);
        Log.Information("Zostal usuniety klient "+konto);
    }
    
    public string GetKonta()
    {
        return String.Join("\n", listaKont.Select(x => $"Nr konta:{x.GetNrKonta()}, {x.GetKarty()}"));
    }
    
    
}