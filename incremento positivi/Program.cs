using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace incremento_positivi
{
    public delegate void AumentoPositiviDel(object obj, AumentoCountry aumento);

    
    internal class Program
    {
        static void Main(string[] args)
        {
            Country Italia = new Country("Italia");
            Country Germania = new Country("Germania");
            Italia.Positivi = 150;
            Germania.Positivi = 270;
            Italia.Positivi = 230;
            Germania.Positivi = 230;
            Italia.Positivi = 350;
            Console.WriteLine("L'italia ha:        "+Italia.Positivi);
            Console.WriteLine("La Germania ha:     "+Germania.Positivi);
            Console.WriteLine();
            
        }

        public static void aggiornaPositivi(object obj,AumentoCountry aumento)
        {
            EU.NumeroPositivi += aumento.Pos;
            var a = obj.GetType().GetRuntimeProperty("Name").GetValue(obj);
            Console.WriteLine($"Hai aggiunto {aumento.Pos} positivi a: {a}\n");
            Console.WriteLine("L'EU adesso ha:" + EU.NumeroPositivi);
            Console.WriteLine(  );
        }
       
    }
}
