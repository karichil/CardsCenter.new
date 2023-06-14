namespace CardsCenter;
using Serilog;

public abstract class KlientBanku
{
    private List<Konto> listaKont;
    private Konto konto;
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
        Log.Information("Konto: "+ konto.GetNrKonta()+" zostalo dodane");
        
    }
    
    public void UsunKonto(Konto konto)
    {
        listaKont.Remove(konto);
        Log.Information("Konto: "+ konto.GetNrKonta()+" zostalo usuniete");
    }
    
    public string GetKonta()
    {
        return String.Join("\n", listaKont.Select(x => $"Nr konta:{x.GetNrKonta()}, {x.GetKarty()}"));
    }
    
    
}