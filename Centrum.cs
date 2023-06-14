namespace CardsCenter;
using Serilog;
using System.IO;

public class Centrum
{
    private List<KlientCentrum> listaKlientCentrum;
    private string archiwum=@"C:\Users\karin\OneDrive\Pulpit\CardsCenter\CardsCenter\bin\Debug\net6.0\log.txt";

    public Centrum()
    {
        File.OpenRead(archiwum);
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
    
    public void PrzeszukajArchiwum(string parametr)
    {
        using (StreamReader odczyt = new StreamReader("log.txt"))
        {
            string linia;
            while ((linia = odczyt.ReadLine()) != null)
            {
                if (linia.Contains(parametr))
                {
                    Console.WriteLine(linia);
                }
            }
        }
    } 

}