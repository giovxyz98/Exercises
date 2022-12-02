using System;

namespace EsercizioDelegateCeo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
             
            CommercialBank commercialBank = new CommercialBank();
            commercialBank.cambio += Stampa;
           Centralbank._CEO = "Giovanni";  




        }
        public static void Stampa(object obj, Even even)
        {
            Console.WriteLine($"Ciao {obj.GetType().Name} il nuovo ceo è {even.newCeo} ");
        }




    }
    
}