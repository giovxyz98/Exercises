using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Utility;                    //classe della libreria di spotify

namespace Esercizio_async
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Task task= RichiestaBrani();
            Console.WriteLine("Effettuo varie operazioni");
            Console.WriteLine("Programma terminato");
            Console.ReadLine();
        }


        static async Task<List<Song>> RichiestaBrani()
        {
            Console.WriteLine("Effettuo chiamata API dopo la fine del programma devi aspettare 5 secondi");
            return await Task.Factory.StartNew<List<Song>>(Task202.LeggiDaFile);
        }
        
    }
}
