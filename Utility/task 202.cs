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
        public static void LeggiDaFile<T>() where T :class, new()
        {
            var righe=File.ReadAllLines("C:\\Users\\Giovanni\\Desktop\\File\\file.csv").ToList();
            List<T> list=new List<T>();
            T obj;
            var header = righe[0].Split(',');
            righe.RemoveAt(0);
           
            foreach (var riga in righe)
            {
                obj=new T();
                var objProperties= obj.GetType().GetProperties();
                var valori = riga.Split(",");
   
                int i =0;
                    foreach (var prop in objProperties)
                    {
                        if (prop.Name == header[i])
                        {
                            var valore=valori[i];
                            prop.SetValue(obj,Convert.ChangeType(valore,prop.PropertyType));
                        
                        i++;
                        }
                    }
                
                list.Add(obj);
               
            }stampaObj(list); // --> Stampa fuori dal ciclo
            
        }
        public static void stampaObj<T>(List<T> objS)
        {
            foreach(var obj in objS) 
            {
                foreach(var prop in obj.GetType().GetProperties()) { 
                 Console.WriteLine(prop.GetValue(obj));
                      Thread.Sleep(500);
                    }
            }

        }
        public static string CheckDir()
        {
            Console.WriteLine("Inserire percorso cartella:\n");
            var path=Console.ReadLine();
            if (!Directory.Exists(path))
            {
                Console.WriteLine("La cartella non esiste");
                CheckDir();
            }
               Console.WriteLine("Inserire il nome del file");
                var nomeFile=Console.ReadLine();
                var pathFile=path+"\\"+nomeFile+".csv";
            Console.WriteLine(pathFile);
            if (!File.Exists(pathFile))
            {
                Console.WriteLine("Il file non esiste oppure non è in formato csv");
                CheckDir();
            }
          return pathFile;
            }
        }
    }

