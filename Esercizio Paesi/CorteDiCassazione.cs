using Esercizio_Paesi;
using System;

public class CorteDiCassazione
{ PaesiViolanti viola = new PaesiViolanti();
   
        public void diritti()
    {
        string[] i = viola.paesiDiritti;
            Console.WriteLine($"Inserisci il paese per sapere se viola i diritti umani:\n");
            string paeseP = Console.ReadLine();
            foreach (string p in i)
            {
                if (paeseP == p)
                {
                    Console.WriteLine($"Il paese viola i diritti");
                    break;
                }


                else
                {
                    Console.WriteLine($"Il paese non viola i diritti");
                    break;
                }

            }

        }
    }


