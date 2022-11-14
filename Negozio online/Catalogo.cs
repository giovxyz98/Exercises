public class Catalogo
{
    public int _codiceProdotto;
    public string _descrizione;
    public double _prezzo;
    public int _disponibilità;
    public string _tipologia;
    public Catalogo(int codiceProdotto, string descrizione, double prezzo, int disponibilità,string tipologia)
    {
        _codiceProdotto = codiceProdotto;
        _descrizione = descrizione;
        _prezzo = prezzo;
        _disponibilità = disponibilità;
        _tipologia = tipologia; 
    }
}