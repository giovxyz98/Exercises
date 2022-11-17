using esercizio_scrivi_su_file;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace estrai_da_file
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.LeggiDaFile<Cliente>();
        }
    }
    public class Utility
    {
        public static void LeggiDaFile<T>() where T : class, new()
        
        {

            var lines = File.ReadAllLines(Funzione.FCheck()).ToList();
            List<string[]> lista = new List<string[]>();
            List<T> output = new List<T>();
            T obj =new T();
            var objProperties = obj.GetType().GetProperties();
            var header = lines[0].Split(',').ToList();
            lines.RemoveAt(0);
            foreach(var line in lines)
            {
                obj = new T();
                var valori = line.Split(',');
                for (int i=0; i <header.Count(); i++)
                {
                    foreach (var prop in objProperties)
                    {
                        if (prop.Name == header[i])
                        {
                            var valore=valori[i];
                            prop.SetValue(obj,Convert.ChangeType(valore,prop.PropertyType));
                        }


                    }

                }
                output.Add(obj);
            }


        }

    }
}
