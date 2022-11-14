using System;

namespace esercizio_anagrafica
{
    public class Prestito
    {
        public int _ammontare { get; set; }
        public double _rata { get; set; }
        public DateTime _dataInizio { get; set; }
        public DateTime _dataFine { get; set; }
        public int _idPrestito { get; set; }
        public int _codiceCliente { get; set; }
        public string _emittente;
        public string _concessoA { get; set; }
        public void stampaDettagli()
        {
            Console.WriteLine($"\nDettagli prestito:\nL'ammontare del prestito è {_ammontare}, rata da pagare: {_rata}\nEmesso da: {_emittente}\nData di erogazione: {_dataInizio}\nData fine: {_dataFine}" +
                $"\nCodice id prestito: {_idPrestito}\nconcesso a: {_concessoA} n° {_codiceCliente}");
        }
        public Prestito(int ammontare, double rata, DateTime dataDiInizio, DateTime dataFine, int idPrestito, Cliente cliente, Banca emittente)
        {

            _ammontare = ammontare;
            _rata = rata;
            _dataInizio = dataDiInizio;
            _dataFine = dataFine;
            _idPrestito = idPrestito;
            _codiceCliente = cliente._codiceCliente;
            cliente._idPrestito = this._idPrestito;
            _emittente = emittente._nome;
            _concessoA = cliente._nome + " " + cliente._cognome;
            emittente.aggiungiPrestito(this);

        }

    }
}