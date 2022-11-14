public class Cd:Prodotto
{
    public string _artista;
    public string _produttore;
    public int _brani;
    public float _durata;
   
    public Cd(string nome, int codice, int anno, double prezzo, int disponibilità, string paese,string artista, string produttore, int brani, float durata) : base(nome, codice, anno, prezzo, disponibilità, paese)
    {
        _artista = artista;
        _produttore = produttore;
        _brani = brani;
        _durata = durata;
    }   
}