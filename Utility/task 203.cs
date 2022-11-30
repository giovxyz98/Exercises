using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace Utility
{
    public  static class Task203
    {
         
        static bool user = true;
        public static void CreaPlaylist()
        {
            if (CheckAccesso())
            {
                List<string> listBrani = new List<string>();
                string file = CheckFile();
                Console.WriteLine("Inserisci il nome della playlist");
                var name = Console.ReadLine();
                Playlist playlist = new Playlist() { Name =name};
                File.AppendAllText(file, "---------------------------------------------\n-" +
                                         "Nome playlist:  " + name +
                                         "\n---------------------------------------------");
                                         
                var brani = aggiungiBrani(listBrani);
                int i = 0;
                foreach(var brano in brani)
                {
                    i++;
                    File.AppendAllText(file, $"\n-Nome brano {i}: {brano}\n");
                    
                }
                 File.AppendAllText(file, "---------------------------------------------\n\n\n\n\n");
            }
            
            else
            {
                Console.WriteLine("Devi effettuare l'accesso per poter creare una playlist");
            }
        }
        
        static string CheckFile() 
        {   
            var dir=Directory.GetCurrentDirectory();
                string filePath = dir + "\\Playlist.txt";
            return filePath;
      }
        public static bool CheckAccesso()
        {
            if (user)
            {
                return true;
            }
            else return false;
        }
        static List<string> aggiungiBrani(List<string> list)
        {
            Console.WriteLine("Scrivi il titolo del brano e premi invio(scrivi stop per fermare l'aggiunta dei brani)");
            var brano = Console.ReadLine();
           if(brano.ToUpper() != "STOP")
            {
                list.Add(brano);
                aggiungiBrani(list);
            }
            return list;
        }
        


    }
    internal class Playlist
    {
        internal string Name { get; set; }
        internal List<string> songs { get; set; }

    }
}
