using System.Security.Principal;

namespace CardsCenter;
using Serilog;

public class Centrum
{
    private List<KlientCentrum> listaKlientCentrum;
    private string nazwa;

    public Centrum()
    {
        listaKlientCentrum = new List<KlientCentrum>();
    }

    public void DodajKlientaCentrum(KlientCentrum klientcentrum)
    {
        listaKlientCentrum.Add(klientcentrum);
        Log.Information("Zostal dodany nowy klient Centrum "+klientcentrum.GetKlientCentrum());
    }

    public void UsunKlientaCentrum(KlientCentrum klientcentrum)
    {
        listaKlientCentrum.Remove(klientcentrum);
        Log.Information("Z Centrum zostal usuniety klient "+klientcentrum.GetKlientCentrum());
    }
}