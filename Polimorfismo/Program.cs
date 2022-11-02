using System;
using System.Security.Cryptography.X509Certificates;
using Polimorfismo.Interfaces;

namespace Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // upcasting
            /* IONU USA = new CapitalPunishmentCountry("USA", "democratico", "Federale", "1789");
             IONU italy = new EuroZoneCountry("Italy", "democratico", "Parlamentare", "1947"); 
             IONU Argentina = new ONUCountry("Argentina", "democratico", "Parlamentare", "1922");


             EuroZoneCountry EuroItaly = (EuroZoneCountry) italy; // Downcasting


             EuroCentralBank.CalcSpread(EuroItaly);
             StrasbourgCourt.HumanRightsInvestigation(USA); 
             StrasbourgCourt.HumanRightsInvestigation(italy);
             StrasbourgCourt.HumanRightsInvestigation(Argentina);*/
            Confronto.confronto();
            //Regione sicilia = new Regione("Sicilia","siciliano","Palermo","Nello Musumeci");
            //Regione lombardia = new Regione("Lombardia","lombardo","Milano","Attilio Fontana");
            //Country Italia = new Country("Italia");
            //Italia.addRegione(sicilia);
            //Italia.addRegione(lombardia);
            //Console.WriteLine(Italia._regione._Name);
            //Console.WriteLine(lombardia.country.Name);
            //Città Milano = new Città("Milano","sindaco",10);
            //Cittadino Mario = new Cittadino("Mario","Rossi","m",/*"19\\12\\1997",*/189);
            //Milano.addCittadino(Mario);
            //Console.WriteLine(Mario.città._nome);
            //Cittadino Luca = new Cittadino("Luca", "Bianchi", "m", /*"20\\06\\2001",*/212);
            //Milano.addCittadino(Luca);
            //Milano.stampaCittadino();
            //Console.WriteLine(Mario.dataDiNascita);
           
            

        }


    } 
}
