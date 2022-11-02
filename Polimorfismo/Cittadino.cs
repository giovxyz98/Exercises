public class Cittadino
{
    public string nome { get; set; }
    public string cognome { get; set; }
    public string sesso { get; set; }
    public string dataDiNascita { get; set; }
    public int _id { get; set; }
    public Città città;
    public Cittadino(string nome, string cognome, string sesso, string dataDiNascita,int id)
    {
        this.nome = nome;
        this.cognome = cognome;
        this.sesso = sesso;
        this.dataDiNascita = dataDiNascita;
        this._id = id;  
       
    }   
}