using System;

public class Persona
{
    public long IDpersona { get; set; }
    public string nome { get; set; }
    public string cognome { get; set; }
    public string dataDiNascita { get; set; }
    public string indirizzo { get; set; }
    public int cap { get; set; }
    public string Città { get; set;}
    public string postaElettronica { get; set; }
    public string numero { get; set; } 

    public void infoPersona(Persona persona)
    {
        Console.WriteLine($"ID: {persona.IDpersona}");
        Console.WriteLine($"Nome: {persona.nome} {persona.cognome}");
        Console.WriteLine($"Data di nascita {persona.dataDiNascita}");
        Console.WriteLine($"Indirizzo: {persona.indirizzo}");
        Console.WriteLine($"Città: {persona.Città}");
        Console.WriteLine($"Cap: {persona.cap}");
        Console.WriteLine($"Email: {persona.postaElettronica}");
        Console.WriteLine($"Numero di telefono: {persona.numero}"); 

    }

}
