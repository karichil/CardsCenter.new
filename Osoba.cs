namespace CardsCenter;
using Serilog;
public class Osoba : KlientBanku
{
    private string imie, nazwisko, PESEL;
    private Bank bank;

    public Osoba(string imieosoby, string nazwiskoosoby, string pesel)
    {
        imie = imieosoby;
        nazwisko = nazwiskoosoby;
        PESEL = pesel;
        
        Log.Information("Zostal dodany nowy klient banku "+bank+" Imie:"+imie+" Nazwisko: "+nazwisko+" PESEL: "+PESEL);
    }

    public string GetOsoba()
    {
        return String.Format("Osoba imie: "+imie+" nazwisko: "+nazwisko+" pesel: "+PESEL+base.GetKonta());
    }
    
}