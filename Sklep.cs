namespace CardsCenter;

public class Sklep:Firma
{
    private string nazwaSklapu, KRSSklapu;

    public Sklep(string nazwasklep, string krssklep) : base(nazwasklep,krssklep)
    {
        nazwaSklapu = nazwasklep;
        KRSSklapu = krssklep;
    }

    public override string GetFirma()
    {
        return String.Format("Nazwa:" + nazwaSklapu + " KRS:" + KRSSklapu);
    }
}