using System;

public class Dipendente : Persona
{
    public string tipoLavoro { get; set; }
    public long codiceUfficio { get; set; }
    public string reparto { get; set; }
    public string divisione { get; set; }
    public void InfoDipendente(Dipendente dipendente)
    {
        Console.WriteLine($"ID: {dipendente.IDpersona}");
        Console.WriteLine($"Nome: {dipendente.nome} {dipendente.cognome}");
        Console.WriteLine($"Data di nascita: {dipendente.dataDiNascita}");    
        Console.WriteLine($"Indirizzo: {dipendente.indirizzo}");
        Console.WriteLine($"Città: {dipendente.Città}");
        Console.WriteLine($"Cap: {dipendente.cap}");
        Console.WriteLine($"Email: {dipendente.postaElettronica}");
        Console.WriteLine($"Numero di telefono: {dipendente.numero}");
        Console.WriteLine($"Tipo lavoro: {dipendente.tipoLavoro}");
        Console.WriteLine($"Codice Ufficio: {dipendente.codiceUfficio}");
        Console.WriteLine($"Reparto: {dipendente.reparto}");
        Console.WriteLine($"Divisione: {dipendente.divisione}");
    }
    

}