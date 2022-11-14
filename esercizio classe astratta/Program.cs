using System;
using System.Security.Cryptography.X509Certificates;

namespace esercizio_classe_astratta
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
public abstract class Territorio
{
    public long _superficie;
    public long _popolazione;
    public int _densitàAbitanti;
    public Territorio (long superficie, long popolazione, int densitàAbitanti)
    {
        _superficie = superficie; 
        _popolazione = popolazione;
        _densitàAbitanti = densitàAbitanti;
    }
}
public class Continente : Territorio
{

    public Continente(long superficie, long popolazione, int densitàAbitanti) : base(superficie, popolazione, densitàAbitanti)
    { }

}
public interface UnioneEuropea
{
    public string Moneta { get; set; }
    public string Leggi { get; set; }
    public int Fondazione { get; set; }
    public int PIL { get; set; }
    public int PILProCapite { get; set; }
    public string politica { get; set; }
    public string Cultura { get; set; }
    public string Presidente { get; set; }

}
public class Nazione : Territorio, UnioneEuropea
{
    public string _lingua;
    public string _tradizioni;
    public string _capitale;

    public Nazione(long superficie, long popolazione, int densitàAbitanti, string lingua, string tradizioni, string capitale) : base(superficie, popolazione, densitàAbitanti)
    {
        _lingua = lingua;
        _tradizioni = tradizioni;
        _capitale = capitale;
    }
    
    public string Moneta { get; set; }
    public string Leggi { get; set; }
    public int Fondazione { get; set; }
    public int PIL { get; set; }
    public int PILProCapite { get; set; }
    public string politica { get; set; }
    public string Cultura { get; set; }
    public string Presidente { get; set; }
}

public class Regione: Territorio
{
    public string _presidente;
    public string _capoluogo;
    public string _dialetto;
    public Regione(long superficie, long popolazione, int densitàAbitanti, string presidente, string capoluogo, string dialetto) : base(superficie, popolazione, densitàAbitanti)
    {
        _presidente = presidente;
        _capoluogo = capoluogo;
        _dialetto = dialetto;
    }

}
public class Città : Territorio
{
    public string _sindaco;
    public string _provincia;
    public Città(long superficie, long popolazione, int densitàAbitanti, string sindaco, string provincia) : base(superficie, popolazione, densitàAbitanti)
    {
        _sindaco = sindaco;
        _provincia = provincia;
    }

}
public class Cittadino
{
    public string _nome;
    public string _cognome;
    public string _CF;
    public string _indirizzo;
    public Cittadino (string nome,string cognome,string cf,string indirizzo)
    {
        _nome = nome;
        _cognome = cognome;
        _CF = cf;
        _indirizzo = indirizzo;
    }
}
