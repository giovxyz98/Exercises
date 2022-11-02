using System;

public class Cittadino
{
    public string nome { get; set; }
    public string cognome { get; set; }
    public string sesso { get; set; }
    public string dataDiNascita { get; set; }
    public int _id { get; set; }
    public Città città;
    public void dataDiNas() 
    {
        Console.WriteLine("Inserire la data di nascita");
        dataDiNascita=Console.ReadLine();
    }
    
    public Cittadino(string nome, string cognome, string sesso,int id)// ,string dataDiNascita)
    {
        this.nome = nome;
        this.cognome = cognome;
        this.sesso = sesso;
        this._id = id;  
       
    }   
}