using System.Security.Cryptography.X509Certificates;
using CardsCenter;
using Serilog;

namespace CardsCenter
{
    public class Program
    {
        public static void Main()
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.File("archiwum.txt")
                .CreateLogger();


            Centrum centrum = new Centrum();

            KlientCentrum klientCentrum1 = new Bank("Bank1");
            KlientCentrum klientCentrum2 = new Sklep("Sklep1", "1");
            KlientCentrum klientCentrum3 = new Sklep("Sklep2", "2");
            KlientCentrum klientCentrum4 = new FirmaTransportowa("FirmaTransportowa1", "3");
            KlientCentrum klientCentrum5 = new FirmaTransportowa("FirmaTransportowa2", "4");
            KlientCentrum klientCentrum6 = new FirmaTransportowa("FirmaTransportowa3", "5");
            KlientCentrum klientCentrum7 = new ZakladUslugowy("ZakladUslugowy1", "6");
            KlientCentrum klientCentrum8 = new ZakladUslugowy("ZakladUslugowy2", "7");
            
            centrum.DodajKlientaCentrum(new Bank("Bank1"));
            centrum.DodajKlientaCentrum(new Sklep("Sklep1", "1"));
            centrum.DodajKlientaCentrum(new Sklep("Sklep2", "2"));
            centrum.DodajKlientaCentrum(new FirmaTransportowa("FirmaTransportowa1", "3"));
            centrum.DodajKlientaCentrum(new FirmaTransportowa("FirmaTransportowa2", "4"));
            centrum.DodajKlientaCentrum(new FirmaTransportowa("FirmaTransportowa3", "5");
            centrum.DodajKlientaCentrum(klientCentrum7);
            centrum.DodajKlientaCentrum(klientCentrum8);
            
            
            

            KlientBanku osoba1 = new Osoba("ala", "nowak", "123");
            KlientBanku osoba2 = new Osoba("adam", "kowalski", "456");
            KlientBanku osoba3 = new Osoba("alina", "kwiat", "789");

            Konto konto1 = new Konto();
            Konto konto2 = new Konto();
            Konto konto3 = new Konto();
            Konto konto4 = new Konto();

            osoba1.DodajKonto(konto1);
            osoba1.DodajKonto(konto2);
            osoba2.DodajKonto(konto3);
            osoba3.DodajKonto(konto4);

            Karta karta1 = new Bankomatowa();
            Karta karta2 = new Debetowa();
            Karta karta3 = new Kredytowa();
            Karta karta4 = new Bankomatowa();
            Karta karta5 = new Kredytowa();
            Karta karta6 = new Bankomatowa();
            Karta karta7 = new Debetowa();

            konto1.DodajKarte(karta1);
            konto1.DodajKarte(karta2);
            konto1.DodajKarte(karta3);
            konto2.DodajKarte(karta4);
            konto2.DodajKarte(karta5);
            konto3.DodajKarte(karta6);
            konto3.DodajKarte(karta7);

            karta1.WplacNaKarte(10000);
            karta2.WplacNaKarte(5000);
            karta4.WplacNaKarte(4000);
            karta6.WplacNaKarte(5000);
        }
    }
}
    
    
    

