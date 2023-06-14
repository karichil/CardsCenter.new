namespace CardsCenter;

public class FirmaTransportowa : Firma
{
    private string nazwaTransport, KRSTransportu;

    public FirmaTransportowa(string nazwatransport, string krstransport) : base(nazwatransport, krstransport)
    {
        nazwaTransport = nazwatransport;
        KRSTransportu = krstransport;
    }

    public override string GetFirma()
    {
        return String.Format("Nazwa:" + nazwaTransport + " KRS:" + KRSTransportu);
    }
}