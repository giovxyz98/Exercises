using System;
using System.Collections.Generic;

namespace Esercizio_Dizionari
{
    internal partial class Program
    {
        public static class Utility
        {
            static Dictionary<string, Dictionary<string, string>> StatoItaliano = new Dictionary<string, Dictionary<string, string>>();
            public static void cercaCodice(Dictionary<string, Dictionary<string, string>> StatoItaliano)
            {
                Console.WriteLine("\nInserisci qui il codice da cercare: ");
                var codice=Console.ReadLine().ToUpper();
                

                foreach(var i in StatoItaliano)
                {
                    if (codice == i.Key)
                    {
                        foreach (var x in i.Value)
                        {
                            Console.WriteLine(x.Key + x.Value);

                        }

                    }

                    else Console.WriteLine("Il codice non è presente all'interno del nostro datatbase, immettere 2 per aggiungerlo");
                }


            }
            public static void aggiungiCodice(Dictionary<string, Dictionary<string, string>> StatoItaliano)
            {
                Console.WriteLine("\nScrivere qui il codice fiscale da inserire: ");
                string Codice_Fiscale = Console.ReadLine().ToUpper();
                StatoItaliano.Add(Codice_Fiscale, new());
                Console.WriteLine("Per aggiungere un codice fiscale è necessario aggiungere alcuni dati:\nAggiungi la residenza: ");
                string residenza = Console.ReadLine();
                StatoItaliano[Codice_Fiscale].Add("\nResidenza: ", residenza);
                Console.WriteLine("Aggiungi lo stato occupazionale :");
                string stato = Console.ReadLine();
                StatoItaliano[Codice_Fiscale].Add("\nStato occupazionale:", stato);
                Console.WriteLine("Aggiungi lo stato della fedina penale: ");
                string fedina = Console.ReadLine();
                StatoItaliano[Codice_Fiscale].Add("\nFedina Penale:  ",fedina);
                Console.WriteLine("Aggiungi il titolo di studio: ");
                string titolo = Console.ReadLine();
                StatoItaliano[Codice_Fiscale].Add("\nTitolo di studio:  ", titolo);
            }
            public static void Menu()
            {
                Console.WriteLine("Quale operazione vuoi eseguire:\n\n1 -Aggiungere una persona\n2 -Cercare una persona");
                try
                {
                    int a = int.Parse(Console.ReadLine());
                    if (a ==1 || a == 2)
                    {
                        if (a == 1) aggiungiCodice(StatoItaliano);
                        else if (a==2) cercaCodice(StatoItaliano);
                    }
                    else {
                        Console.WriteLine("Devi inserire 1 o 2\n");
                        Menu();
                    }
                }
                catch
                {
                    Console.WriteLine("Devi inserire 1 o 2\n");
                    Menu();
                }
            }
            public static void start()
            {
                Console.WriteLine("State eseguendo il primo accesso, inserire almeno un codice:  ");
                aggiungiCodice(StatoItaliano);
            }
        }
    }
   
    

        


        

    
}
