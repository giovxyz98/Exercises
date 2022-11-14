public class Dvd:Prodotto
{
    public string _durata;
    public string _regista;
    public string _tipologia;
    public string _formato;

    public Dvd(string nome, int codice, int anno, double prezzo, int disponibilità, string paese,string durata, string regista, string tipologia, string formato) : base(nome, codice, anno, prezzo, disponibilità, paese)
    {
        _durata = durata;
        _regista = regista;
        _tipologia = tipologia;
        _formato = formato;
    }   
}