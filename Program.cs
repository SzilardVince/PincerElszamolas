using PincerElszamolas;
using System.Runtime.InteropServices;
Console.ForegroundColor = ConsoleColor.Cyan;
string[] F = File.ReadAllLines("pincerek.txt");
List<pincer> Z = new List<pincer>();
double y = 0;
double ps = 0;
double asz=0;
double lf = 0;
string lfn = "";
int tp = 0;
Console.WriteLine("Pincérek napi elszámolása:");
foreach(string a in F)
{
    double pincerkereslet = 15000;
    pincer X = new pincer();
    string[] H = a.Split(";");
    X.Nev = H[0];
    X.FelszolgaltAsztalok = int.Parse(H[1]);
    X.NapiBevetelFt= int.Parse(H[2]);
    X.ReklamaciokSzama= int.Parse(H[3]);
    Z.Add(X);
    pincerkereslet += X.NapiBevetelFt * 0.05;
    if (X.FelszolgaltAsztalok >=12 && X.ReklamaciokSzama == 0)
    {
        pincerkereslet += 10000;
    }
    else if (X.ReklamaciokSzama >= 2)
    {
        pincerkereslet -= 8000;
    }
    Console.WriteLine($"{X.Nev}: {X.FelszolgaltAsztalok} asztal, {X.NapiBevetelFt} Ft bevétel (Reklamáció: {X.ReklamaciokSzama}) - Fizetés: {pincerkereslet} Ft");
    ps += 1;
    asz += X.FelszolgaltAsztalok;
    if (pincerkereslet > lf)
    {
        lf = pincerkereslet;
        lfn = X.Nev;
    }
    if (X.ReklamaciokSzama == 0)
    {
        tp += 1;
    }
    y += pincerkereslet;
}
Console.WriteLine("\nÖsszesített statisztika:");
Console.WriteLine($"Étterem által kifizetett teljes összeg: {y} Ft");
Console.WriteLine($"Átlagos felszolgált asztalszám pincérenként: {asz/ps:F0} asztal");
Console.WriteLine($"Legmagasabb napi fizetés: {lfn} ({lf} Ft)");
Console.WriteLine($"Reklamáció nélkül dolgozó pincérek száma: {tp} fő");



Console.ForegroundColor = ConsoleColor.Black;