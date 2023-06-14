using System.Runtime.ExceptionServices;
using Serilog;

namespace CardsCenter;

public class KlientCentrum
{
    private List<Bank> listaBank;
    private List<Firma> listaFirma;

    private KlientCentrum _klientCentrum;
    private Firma Firma;
    private Bank Bank;

    public KlientCentrum()
    {
        if (_klientCentrum == Firma)
        {
            listaFirma = new List<Firma>();
        }
        else if(_klientCentrum == Bank)
        {
            listaBank = new List<Bank>();
        }
    }

    public void DodajBank(Bank bank)
    {
        listaBank.Add(bank);
        Log.Information("Zostal dodany nowy bank "+bank);
    }

    public void DodajFirme(Firma firma)
    {
        listaFirma.Add(firma);
        Log.Information("Zostala dodana nowa firma "+firma);
    }

    public void UsunBank(Bank bank)
    {
        listaBank.Remove(bank);
        Log.Information("Bank "+bank+" zostal usuniety");
    }

    public void UsunFirme(Firma firma)
    {
        listaFirma.Remove(firma);
        Log.Information("Firma"+firma+" zostala usunieta");
    }
    
    
    public String GetBankList()
    {
        return String.Join("\n", listaBank.Select(x => $"Bank:{x.GetKlienci()}"));
    }

    public String GetFirmaList()
    {
        return String.Join("\n", listaFirma.Select(x => $"Firma:{x.GetFirma()}"));
    }
    

}