using System;
using System.Collections.Generic;

namespace Home_Giovanni
{
    public static class Home
    {
        static string user { get; set; } = "Giovanni";
        static Dictionary<string, string> artist;
        public static void Start()
        {
            Console.WriteLine($"Benvenuto {user},cosa vuoi fare(seleziona i tasti per andare avanti nel menu)\nM - Apri menù musica\nI - Apri impostazioni profilo");
            var input = Menù();

            if (input == "M")
            {
                MenùMusica();
            }
            else if (input == "I")
            {
                MenùP();
            }
            else if (input == "E")
            {

            }
            else
            {
                Console.WriteLine("Richiesta non valida\n");
                Start();
            }
        }
        public static void MenùMusica()
        {
            Console.WriteLine("Menù musica:\nN - Per le novità\nR - per la radio\nL - Per la tua libreria\nS - Per ricercare un brano");

            var scelta = Menù();
            switch (scelta)
            {
                case "N": Novità(); break;
                case "A": break;
                case "R": Radio(); break;
                case "L": Libreria(); break;
                case "S": Ricerca(); break;
                case "E": break;
                default: Console.WriteLine("Devi inserire le lettere richiesti\n"); Start(); break;
            }

        }
        public static void MenùP()
        {


        }

        static string Menù()
        {
            var input = Console.ReadLine().ToUpper();

            return input;

        }
        static void Ricerca()
        {
            Console.WriteLine("Inserisci qui il brano da ricercare: \n");
            var canzone = Console.ReadLine();
            Console.WriteLine($"Hai selezionato la canzone {canzone}\n");
            Start();
        }
        static void Novità()
        {
            Console.WriteLine("Ecco le novità suggerite per te:\n");
            Start();

        }
        static void Radio()
        {
            Console.WriteLine("Stai ascoltando la radio\n");
            Start();
        }
        static void Libreria()
        {
            Console.WriteLine("Ecco qua la tua libreria con i tuoi brani preferiti:\n");
            Start();
        }




    }
}

