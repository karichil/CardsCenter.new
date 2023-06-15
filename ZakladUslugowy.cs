namespace CardsCenter;


public class ZakladUslugowy : Firma
{
    private string nazwaZakladu, KRSZakladu;

    public ZakladUslugowy(string nazwazaklad, string krszaklad) : base(nazwazaklad, krszaklad)
    {
        nazwaZakladu = nazwazaklad;
        KRSZakladu = krszaklad;
    }

    public override string GetFirma()
    {
        return String.Format("Nazwa zakladu transportowego: " + nazwaZakladu + " KRS:" + KRSZakladu);
    }
    public override string GetKlientCentrum()
    {
        return GetFirma();
    }
}    