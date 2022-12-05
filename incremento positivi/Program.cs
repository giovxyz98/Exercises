using System;
using System.Runtime.CompilerServices;

namespace incremento_positivi
{
    public delegate void AumentoPositivi(object obj,AumentoCountry aumento);
    internal class Program
    {
        static void Main(string[] args)
        {
            Country Italia = new Country("Italia");
            Italia.AumentoPositivi += new AumentoPositivi(aggiornaPositivi);
            Italia.Positivi = 230;
            Console.WriteLine(Italia.Positivi);
            Italia.Positivi = 500;
            Console.WriteLine(Italia.Positivi);
            Console.WriteLine(EU.NumeroPositivi);
            
        }

        public static void aggiornaPositivi(object obj,AumentoCountry aumento)
        {
            var num = obj.GetType().GetProperty("Positivi").GetValue(obj).ToString();
            int x=int.Parse(num);
            EU.NumeroPositivi += x;

        }
    }
    public static class EU
    {
        public static int NumeroPositivi { get; set; }
    }
    public class Country
    {
        public string Name { get; set; }
        public int _positivi=0;
        public event AumentoPositivi AumentoPositivi;

        public int Positivi { get { return _positivi; }
            set {
                if (_positivi != value)
                {
                    AumentoCountry AumentoCountry = new AumentoCountry(value);
                    AumentoPositivi(this,AumentoCountry);
                    _positivi=value;
                }
                    } }
        

        public Country(string name)
        {
            Name = name;
        }

    }
}
