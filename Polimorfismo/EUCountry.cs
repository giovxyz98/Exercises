using Polimorfismo.Interfaces;
using System;
using System.Linq;

namespace Polimorfismo
{
    public class EUCountry : Country, IEuropeanUnion
    {   
        // UE Contracts
        public void HumanRights() { }
        public void ConstitutionIntegration() 
        {
            Constitution +=  " + EU Costitution"; 
            Console.WriteLine($"{Name} -  {Constitution}");
        }

        public EUCountry(string Name, string State, string Government, string Constitution) :
            base(Name)//, State, Government, Constitution) 
        { 
            ConstitutionIntegration();
        }
        



        // ONU Contracts
        public void PopulationControl() 
        {
            Console.WriteLine("Ministero dell'interno");
            Console.WriteLine("Polizia");
            Console.WriteLine("Polizia di Frontiera");
            Console.WriteLine("--------------------------------");

        }
        public void TerritoryControl() 
        {
            Console.WriteLine("Ministero della difesa");
            Console.WriteLine("Esercito");
            Console.WriteLine("--------------------------------");

        }
    }

}

    