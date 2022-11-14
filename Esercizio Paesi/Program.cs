using System;
using System.Security.Cryptography.X509Certificates;

namespace Esercizio_Paesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
         Europa PaesiEurozona = new Europa();
            Console.WriteLine($"I paesi dell'Eurozona sono:");
            PaesiEurozona.PaesiEuroZona();
            Console.WriteLine($"\n\nI paesi dell'UE sono:");
            Europa PaesiEuropei = new Europa();
            PaesiEuropei.PaesiUE();
            Console.WriteLine($"\n\nI Paesi facenti parte solo dell'ONU sono:");
            ONU paesionu = new ONU();
            paesionu.PaesiONU();
            Console.WriteLine($"\n\nI paesi facenti parte sia dell'ONU che dell UE sono:");
            paesionu.PaesiONU();
            PaesiEuropei.PaesiUE();

         
            PenaDiMorte check=new PenaDiMorte();
            check.pena();
            CorteDiCassazione corte=new CorteDiCassazione();
            corte.diritti();
        }
    }
}
