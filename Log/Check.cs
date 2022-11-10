using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace Log
{
    internal partial class Program
    {
            public static class Check
            {
                public static string CheckDir(string path)  //Controlla l'esistenza della cartella e se non ce la crea
                {
                    if (!Directory.Exists(Path.Combine(path, "log")))
                    {
                        Directory.CreateDirectory(Path.Combine(path, "log"));

                    }
                    string a = Path.Combine(path, "log");
                    return a;

                }
            public static string CheckFile(string pathD) //Controlla l'esistenza del file e se non ce lo crea
            {
                if (!File.Exists(Path.Combine(pathD, "log.txt")))
                {
                    File.AppendAllText(Path.Combine(pathD, "log.txt"), "ID---Username:                     Password:              Data e Ora:\n\n");
                }

                string x = Path.Combine(pathD, "log.txt");
                return x;
            }
                    
            
        

        }
    }
}
