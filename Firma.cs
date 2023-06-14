using System.Runtime.ExceptionServices;

namespace CardsCenter;

public abstract class Firma:KlientCentrum
{
    private string nazwa, KRS;

    public Firma(string nazwafirmy, string krs)
    {
        nazwa = nazwafirmy;
        KRS = krs;
    }

    public abstract string GetFirma();
}