using CardsCenter;
using Serilog;

Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Debug()
    .WriteTo.File("log.txt")
    .CreateLogger();

Karta kb1= new Bankomatowa("123456");
Karta kb2= new Debetowa("123456");
Console.WriteLine(kb1.GetNrKarty());
Konto konto1 = new Konto("123");
kb1.WplacNaKarte(200);
kb2.WyplacZKarty(150);
//Console.WriteLine(konto1.GetSaldo());

konto1.DodajKarte(kb1);
konto1.DodajKarte(kb2);
Console.WriteLine(kb1.GetSaldoKarty());
//konto1.Wplac(25);
Console.WriteLine("----");
Console.WriteLine(kb1.GetSaldoKarty());
Console.WriteLine(kb2.GetSaldoKarty());
kb2.WyplacZKarty(15);

KlientBanku klient = new Osoba("ala", "kot", "42512461");
klient.DodajKonto(konto1);
KlientCentrum kc1 = new Bank("ABC");
Bank b1 = new Bank("ABC");
b1.DodajKlienta(new Osoba("ala", "abc", "123456"));
kc1.DodajBank(b1);
Centrum c1 = new Centrum();
c1.DodajKlientaCentrum(kc1);
c1.PrzeszukajArchiwum("Karta");


//File.WriteAllText("log.txt", string.Empty);


    
