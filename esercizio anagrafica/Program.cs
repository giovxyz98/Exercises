using System;
using System.ComponentModel;
using System.Net.Http.Json;

namespace esercizio_anagrafica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Banca IntesaSanPaolo = new Banca("Intesa San Paolo");
            Cliente cliente1 = new Cliente("Giovanni", "Rossi", "GAGSTD546DG276DG", 2400, 12345, IntesaSanPaolo);
            Cliente cliente2 = new Cliente("Luca", "Bianchi", "BNCLCL65SL718DSD", 1800, 54321, IntesaSanPaolo);
            Prestito prestito1 = new Prestito(10000, 240, new DateTime(2012, 12, 12), new DateTime(2032, 12, 12), 354227, cliente1, IntesaSanPaolo);
            cliente1.stampaDettagli();
            prestito1.stampaDettagli();
            IntesaSanPaolo.stampaClienti();


        }
    }
}