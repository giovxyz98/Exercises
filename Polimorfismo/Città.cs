using System;
using System.Collections.Generic;
using System.Linq;

public class Città
{
    public string _nome { get; set; }
    public string _sindaco { get; set; }
    int capacitàMassima { get; set; }
    public int[] _cittadino = new int[10];
    int i = 0;

    public Regione regione;

    


    public void addCittadino(Cittadino cittadino)
    {
        if (i <= capacitàMassima )

        {
            _cittadino[i] = cittadino._id;
            cittadino.città = this;
            i += 1;
        }
        else { Console.WriteLine("La città non ammette più cittadini"); }
    }
    public void stampaCittadino()
    {

        foreach (int iesistenti in _cittadino)
        {
            if (i <= iesistenti)
                Console.WriteLine(iesistenti);
         
        }
    }
        
        
        

        public Città(string nome,string sindaco,int capacità)
    {    
        _nome = nome;
        _sindaco = sindaco;
        capacitàMassima = capacità;
        
    }

      
}
    