using System;

namespace EsercizioDelegateCeo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Centralbank._CEO = "Giovanni";   
            CommercialBank commercialBank = new CommercialBank();
            Console.WriteLine(commercialBank.CEO);
            commercialBank.CEO = "Roberto";
            CryptoBank cryptoBank = new CryptoBank();
            Console.WriteLine(cryptoBank.CEO);
            cryptoBank.CEO = "Rocco";
            Console.WriteLine(commercialBank.CEO);
            Console.WriteLine(cryptoBank.CEO);

        }
    }
    
}