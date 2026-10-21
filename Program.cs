using PincerElszamolas;
using System.Runtime.InteropServices;
Console.ForegroundColor = ConsoleColor.Green;
string[] F = File.ReadAllLines("pincerek.txt");
List<pincer> Z = new List<pincer>();
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
    pincerkereslet += pincerkereslet * 0.05;
    if (X.FelszolgaltAsztalok >=12 && X.ReklamaciokSzama == 0)
    {
        pincerkereslet += 10000;
    }
    else if (X.ReklamaciokSzama >= 2)
    {
        pincerkereslet -= 8000;
    }
}




Console.ForegroundColor = ConsoleColor.Black;