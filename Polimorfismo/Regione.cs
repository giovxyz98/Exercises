using Polimorfismo;
using System;
using System.Security.Cryptography.X509Certificates;

public class Regione:IPolitica
{

    public string _Name { get; set; }
    public string _dialetto { get; set; }
    public string _capoluogo { get; set; }
    public string[] città { get; set; }
    public Country country;
    public Città _città;
    public void addCittà(Città città)
    {
        _città = città;

    }   
   
    public string _presidente { get; set; }
    public Regione(string Name,string dialetto, string capoluogo, string presidente)
        
    {
        _Name = Name;
        _capoluogo=capoluogo;
        _dialetto=dialetto;  
        _presidente=presidente;
        
    }
    
}

    