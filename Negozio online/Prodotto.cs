public class Prodotto
{
    public string _nome;
    public int _codice;
    public int _annoPubblicazione;
    public double _prezzo;
    public int _disponibilità;
    public string _paese;

    public Prodotto(string nome, int codice, int anno, double prezzo, int disponibilità, string paese)
    {
        _nome = nome;
        _codice = codice;
        _annoPubblicazione = anno;
        _prezzo = prezzo;
        _disponibilità = disponibilità;
        _paese = paese;
    }
}