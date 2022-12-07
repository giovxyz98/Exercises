using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace Utility

{
    public static class Task202
    {
        public static List<Song> LeggiDaFile() //where Song : class, new()
        {
            Console.WriteLine("Carico Playlist");
            var righe = File.ReadAllLines(Directory.GetCurrentDirectory()+"//File.csv").ToList();
            List<Song> list = new List<Song>();
            Song obj;
            var header = righe[0].Split(',');
            righe.RemoveAt(0);

            foreach (var riga in righe)
            {
                obj = new Song();
                var objProperties = obj.GetType().GetProperties();
                var valori = riga.Split(",");

                int i = 0;
                foreach (var prop in objProperties)
                {
                    if (prop.Name == header[i])
                    {
                        var valore = valori[i];
                        prop.SetValue(obj, Convert.ChangeType(valore, prop.PropertyType));

                        i++;
                    }
                }

                list.Add(obj);
            }
            Thread.Sleep(5000);
            Console.WriteLine("Fine lettura");
            return list;

        }
        public static void stampaObj<T>(List<T> objS)
        {
            foreach (var obj in objS)
            {
                foreach (var prop in obj.GetType().GetProperties())
                {
                    Console.WriteLine(prop.GetValue(obj));
                    Thread.Sleep(500);
                }
            }
        }
    }
   
}

