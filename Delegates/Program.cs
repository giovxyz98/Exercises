using System;
using System.IO;

namespace Delegates
{
    internal class Program
    {
        public delegate void ciao();
        static void Main(string[] args)
        {
            Prova1.Esempio(WriteWhitDelegates.Scrivi);
            Prova1.Esempio(WriteWhitDelegates.Scrivi);

        }
        public static class WriteWhitDelegates
        {
            static int NumeroFunzione=0;
           
           
            public static void Scrivi(int i)
            {
                NumeroFunzione++;
                Console.WriteLine("Sono alla {0}° chiamata della funzione\n",NumeroFunzione);
                Console.WriteLine("Sono dentro il delegates n°{0}\n",i);
   

            }
            static string CheckFile()
            {
                var dir = Directory.GetCurrentDirectory();
                string filePath = dir + "File  n°";
                return filePath;
            }
        }
     
        public static class Prova1
       
        {
            static int i = 0;
            public static void Esempio(Action<int> action)
            {
                i = 0;
               
                action(++i);
                action(++i);

            }

        }
    }
}
