using System;

namespace Delegates
{
    internal class Program
    {
        public delegate void ciao();
        static void Main(string[] args)
        {
            
        }
        public static void Prova()
        {
            Console.WriteLine("ok vai");
        }
        public static class Prova1
        {
            public static void Esempio(Action action)
            {
                action();

            }

        }
    }
}
