using System;

namespace Esercizio_Paesi
{
    public class PenaDiMorte
    {
        PaesiConPena ciao = new PaesiConPena();
           public void pena()
        {
            string []i=ciao.paesiConPena;
            Console.WriteLine($"Inserisci il paese di cui vuoi sapere se ce la pena di morte:\n");
            string paeseP = Console.ReadLine();
            foreach (string p in i) {
                if (paeseP ==p)
                {
                    Console.WriteLine($"Il paese ha la pena di morte");
                    break;
                }


               else
                {
                    Console.WriteLine($"Il paese inserito non ha la pena di morte");
                    break;
                }
             
            }

        }
    }
}
