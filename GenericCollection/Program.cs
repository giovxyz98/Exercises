using esercizio_scrivi_su_file;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace GenericCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Cliente cliente1 = new Cliente() { Name = "Giovanni", cognome = "Ardore", CF = "RDRGNN19AKSLA9", Id = 210122 };
            Prestito prestito1 = new Prestito() { codiceCliente = "210222", ammontare = "200", dataEmissione = "21/10/2022", dataTermine = "21/10/2032" };
            Es<Cliente>.stampaProperties(cliente1);
            Es<Prestito>.stampaProperties(prestito1);


        }

    }
    public static class Es<T> where T : class
    {
        public static void stampaProperties(T item)
            
        {
            var path =Funzione.FCheck();
            var a = item.GetType().GetProperties();
            List<string> elements = new List<string>();
            StringBuilder bd = new StringBuilder();
            
            
            foreach (var x in a)
            {
                bd.Append(x.Name);
                bd.Append(",");
            }

            elements.Add(bd.ToString().Substring(0, bd.Length - 1));
            foreach (var z in a)
            {

                bd = new StringBuilder();
                foreach (var y in a)
                {
                    bd.Append(y.GetValue(item));
                    bd.Append(",");
                }
            }


            elements.Add(bd.ToString().Substring(0, bd.Length - 1));
            File.AppendAllLines(path,elements);
        }
    }
}
