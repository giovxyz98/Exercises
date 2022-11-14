public class Ordini
{
    internal int _idOrdine;
    internal string _utente;
    internal string _dataOrdine;
    internal double _totaleOrdine;
    internal string _prodotti;
    public Ordini(double totale,string data,int id) { _idOrdine = id; _dataOrdine = data; _totaleOrdine = totale; }
}