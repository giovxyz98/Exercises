public class Libro:Prodotto
{
    public string _codiceISBN;
    public string _autore;
    public string _casaEditrice;
    public Libro(string nome, int codice, int anno, double prezzo, int disponibilità, string paese, string codiceISBN, string autore, string casaEditrice): base(nome,codice,anno,prezzo,disponibilità,paese)
    {
        _codiceISBN = codiceISBN;
        _autore = autore;
        _casaEditrice = casaEditrice;
    }   
}