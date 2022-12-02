using System;

namespace EsercizioDelegateCeo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Centralbank._CEO = "Giovanni";   
            CommercialBank commercialBank = new CommercialBank();
            commercialBank.cambio += new Even(Stampa);
        

        }
        public static void Stampa(object obj,Even even)
        {
            Console.WriteLine($"Ciao {obj.GetType().Name} il nuovo ceo è {even.newCeo} ");
        }
    }
    
}