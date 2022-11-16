using System;
using System.Collections.Generic;
using System.IO;

namespace esercizio_scrivi_su_file
{
    public static class Funzione
    {
        public static void Menu()
        {
            Console.WriteLine("Cosa vuoi scrivere su file:\n1- Per aggiungere cliente\n2- Per aggiungere prestito");
            var x = Console.ReadLine();
            try
            {
                int y = int.Parse(x);
                if (y == 1 || y == 2)
                {
                    if (y == 1) creaCliente();
                    else if (y==2)AggiungiPrestito();

                }
                else Console.WriteLine("Devi scegliere tra 1 e 2");
                Menu();
            }
            catch {  Console.WriteLine("Devi scegliere tra 1 e 2");
                Menu();
            }
        }
        static  string FCheck()
        {
            string _path = @"C:\Users\Giovanni\Desktop";
            string _dir = Check.CheckDir(_path);
            string _file = Check.CheckFile(_dir);
            return _file;
        }
        public static void creaCliente()
        {
            Cliente cliente = new Cliente();
            Random random = new Random();
            int a = random.Next(000000, 999999);
            cliente.Id = a;
            Console.WriteLine("Inserisci qui il nome del cliente: ");
            cliente.Name = Console.ReadLine();
            Console.WriteLine("Inserisci qui il cognome del cliente: ");
            cliente.cognome = Console.ReadLine();
            Console.WriteLine("Inserisci qui il Codice Fiscale del cliente: ");
            cliente.CF = Console.ReadLine();
     
            List<string> dettagli = new List<string>();
            dettagli.Add("\nCliente:");
            dettagli.Add($"Codice cliente: {cliente.Id}");
            dettagli.Add($"Nome cliente: {cliente.Name}");
            dettagli.Add($"Cognome cliente: {cliente.cognome}");
            dettagli.Add($"CF cliente: {cliente.CF}\n");

            File.AppendAllLines(FCheck(), dettagli);



        }
        public static void AggiungiPrestito()
        {
            Prestito prestito = new Prestito();
            Console.WriteLine("Inserisci qui il codice del cliente: ");
            prestito.codiceCliente =Console.ReadLine();
            DateTime dateTime = DateTime.Now;                    
            prestito.dataEmissione = dateTime.ToString();
            TimeSpan time = new TimeSpan(3650,0,0,0);               //Un prestito termina dopo 10 anni
            var date = dateTime.Add(time);
            prestito.dataTermine = date.ToString();
            Console.WriteLine("Inserisci qui l'ammontare del prestito: ");
            prestito.ammontare=Console.ReadLine();
            string FCheck()
            {
                string _path = @"C:\Users\Giovanni\Desktop";
                string _dir = Check.CheckDir(_path);
                string _file = Check.CheckFile(_dir);
                return _file;
            }
            List<string> dettagli = new List<string>();
            dettagli.Add("\nPrestito:");
            dettagli.Add($"Codice cliente: {prestito.codiceCliente}");
            dettagli.Add($"Ammontare {prestito.ammontare}");
            dettagli.Add($"Data emissione: {prestito.dataEmissione}");
            dettagli.Add($"Data termine: {prestito.dataTermine}\n");
            File.AppendAllLines(FCheck(), dettagli);




        }
    }
}
