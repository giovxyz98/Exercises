using System;
using System.ComponentModel;

using System.Collections.Generic;
using System.Net.Http.Json;

namespace esercizio_anagrafica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Banca IntesaSanPaolo = new Banca("Intesa San Paolo");
            Cliente cliente1 = new Cliente("Giovanni","Rossi","GAGSTD546DG276DG",2400,12345,IntesaSanPaolo);
            Cliente cliente2 = new Cliente("Luca", "Bianchi", "BNCLCL65SL718DSD", 1800, 54321, IntesaSanPaolo);
            Prestito prestito1 = new Prestito(10000, 240,new DateTime(2012,12,12),new DateTime(2032,12,12), 354227, cliente1,IntesaSanPaolo);
            cliente1.stampaDettagli();
            prestito1.stampaDettagli();
            IntesaSanPaolo.stampaClienti();


        }
    }
} public class Banca
{
    public string _nome { get; set; }   
    List<int> _cliente=new List<int>();
    public int contaClienti = 0;
    public int prestitiConcessi = 0;
    List<int>_presiti=new List<int>();  
    
    public Banca (string nome)
    {
        _nome = nome;
    }
    public void stampaClienti()
    {
        Console.WriteLine($"\nI clienti della banca sono: {contaClienti}\n");
        for(int i=0;i<contaClienti;i++)			
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
    
    public Cliente(string nome,string cognome,string CF,int stipendio,int codiceCliente,Banca banca)
    {
        
        _nome=nome;
        _cognome=cognome;
        _cf = CF;
        _stipendio = stipendio; 
        _codiceCliente = codiceCliente;
        banca.aggiungiCliente(this);
    }
}
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
    public Prestito(int ammontare,double rata,DateTime dataDiInizio,DateTime dataFine,int idPrestito,Cliente cliente,Banca emittente)
    {
        
        _ammontare = ammontare;
        _rata = rata;
        _dataInizio=dataDiInizio;
        _dataFine = dataFine;
        _idPrestito=idPrestito;
        _codiceCliente = cliente._codiceCliente;
        cliente._idPrestito = this._idPrestito;       
        _emittente = emittente._nome;
        _concessoA = cliente._nome +" "+ cliente._cognome;
        emittente.aggiungiPrestito(this);

    }

}
