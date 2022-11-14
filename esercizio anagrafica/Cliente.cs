using System;

namespace esercizio_anagrafica
{
    public class Cliente
    {
        public string _nome { get; set; }
        public string _cognome { get; set; }
        public string _cf { get; set; }
        public double _stipendio { get; set; }
        public int _codiceCliente { get; set; }
        public int _idPrestito { get; set; }
        public void stampaDettagli()
        {
            Console.WriteLine($"\nDettagli cliente:\nNome cliente: {_nome} {_cognome}\nCF: {_cf}\nstipendio= {_stipendio}\ncodice cliente: {_codiceCliente}");
        }

        public Cliente(string nome, string cognome, string CF, int stipendio, int codiceCliente, Banca banca)
        {

            _nome = nome;
            _cognome = cognome;
            _cf = CF;
            _stipendio = stipendio;
            _codiceCliente = codiceCliente;
            banca.aggiungiCliente(this);
        }
    }
}