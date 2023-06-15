namespace CardsCenter;
using Serilog;
public class Osoba : KlientBanku
{
    private string imie, nazwisko, PESEL;

    public Osoba(string imieosoby, string nazwiskoosoby, string pesel)
    {
        imie = imieosoby;
        nazwisko = nazwiskoosoby;
        PESEL = pesel;
    }

    public string GetOsoba()
    {
        return String.Format(imie+" "+nazwisko+" pesel: "+PESEL);
    }

    public string GetPesel()
    {
        return PESEL;
    }
    
}