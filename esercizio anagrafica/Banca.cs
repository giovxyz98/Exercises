using System;

using System.Collections.Generic;

namespace esercizio_anagrafica
{
    public class Banca
    {
        public string _nome { get; set; }
        List<int> _cliente = new List<int>();
        public int contaClienti = 0;
        public int prestitiConcessi = 0;
        List<int> _presiti = new List<int>();

        public Banca(string nome)
        {
            _nome = nome;
        }
        public void stampaClienti()
        {
            Console.WriteLine($"\nI clienti della banca sono: {contaClienti}\n");
            for (int i = 0; i < contaClienti; i++)
                Console.WriteLine($"Cliente n° {_cliente[i]}");

        }
        public void aggiungiCliente(Cliente cliente)
        {
            _cliente.Add(cliente._codiceCliente);
            /* _cliente[contaClienti] =*/
            contaClienti++;
            Console.WriteLine($"\nIl cliente {cliente._nome} {cliente._cognome} è stato aggiunto correttamente");


            //else Console.WriteLine("Il cliente non può essere aggiunto");

        }
        public void stampaPresiti()
        {
            Console.WriteLine("I prestiti concessi dalla banca sono:");
        }
        public void aggiungiPrestito(Prestito prestito)
        {
            _presiti.Add(prestito._idPrestito);
            prestitiConcessi++;
        }

    }
}