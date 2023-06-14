using CardsCenter;
using Serilog;

Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Debug()
    .WriteTo.File($"log.txt")
    .CreateLogger();

Karta kb1= new Bankomatowa("123456");
Karta kb2= new Debetowa("123456");
Console.WriteLine(kb1.GetNrKarty());
Konto konto1 = new Konto("123");
konto1.Wplac(200);
konto1.Wyplac(150);
Console.WriteLine(konto1.GetSaldo());

konto1.DodajKarte(kb1);
konto1.DodajKarte(kb2);
Console.WriteLine(kb1.GetSaldoKarty());
konto1.Wplac(25);
Console.WriteLine("----");
Console.WriteLine(kb1.GetSaldoKarty());
Console.WriteLine(kb2.GetSaldoKarty());
kb2.WyplacZKarty(15);
Console.WriteLine(kb1.GetSaldoKarty());
Console.WriteLine(kb2.GetSaldoKarty());

KlientBanku klient = new Osoba("ala", "kot", "42512461");
klient.DodajKonto(konto1);
Bank b1 = new Bank();
b1.DodajKlienta(klient);
Console.WriteLine(b1.GetKlienci());
Console.WriteLine(konto1.GetKarty());
Console.WriteLine(klient.GetKonta());


    
