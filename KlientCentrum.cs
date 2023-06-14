using System.Runtime.ExceptionServices;
using Serilog;

namespace CardsCenter;

public abstract class KlientCentrum
{
    private List<KlientCentrum> listaKlientCentrum;

    public KlientCentrum()
    {
        listaKlientCentrum = new List<KlientCentrum>();
    }

    public void DodajBank(Bank bank)
    {
        listaKlientCentrum.Add(bank);
        Log.Information("Klient centrum: "+bank.GetNazwaBanku()+" zostal dodany");
    }

    public void DodajFirme(Firma firma)
    {
        listaKlientCentrum.Add(firma);
        Log.Information("Klient centrum: "+firma.GetFirma()+" zostal dodany");
    }

    public void UsunBank(Bank bank)
    {
        listaKlientCentrum.Remove(bank);
        Log.Information("Klient centrum: "+bank.GetNazwaBanku()+" zostal usuniety");
    }

    public void UsunFirme(Firma firma)
    {
        listaKlientCentrum.Remove(firma);
        Log.Information("Klient centrum: "+firma.GetFirma()+" zostal usuniety");
    }

    public abstract string GetKlientCentrum();
}