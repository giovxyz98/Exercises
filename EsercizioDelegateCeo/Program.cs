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
    public abstract class Centralbank

    {
        public void CambiaCeo(Action action)
        {
            action();
        }
        public void Stampa()
        {
            Console.WriteLine($"Ciao {this} il nuovo CEO è {_CEO}");
        }
        public static string _CEO ;
        public string newCEO;
        public string CEO
        {
            get { return _CEO; }
            set
            {
                newCEO = value;
                if (_CEO != newCEO)
                {   
                    _CEO = newCEO;
                    CambiaCeo(Stampa);
                    

                }
            }

        }
    }
        public class CommercialBank : Centralbank 
        {
       

        }
        public class CryptoBank : CommercialBank
        {

        }
    
}