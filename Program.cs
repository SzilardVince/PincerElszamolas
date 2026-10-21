using PincerElszamolas;
using System.Runtime.InteropServices;
Console.ForegroundColor = ConsoleColor.Green;
string[] F = File.ReadAllLines("pincerek.txt");
List<pincer> Z = new List<pincer>();
foreach(string a in F)
{
    pincer X = new pincer();
    string[] H = a.Split(";");
    X.Nev = H[0];
    X.FelszolgaltAsztalok = int.Parse(H[1]);
    X.NapiBevetelFt= int.Parse(H[2]);
    X.ReklamaciokSzama= int.Parse(H[3]);
    Z.Add(X);
}




Console.ForegroundColor = ConsoleColor.Black;