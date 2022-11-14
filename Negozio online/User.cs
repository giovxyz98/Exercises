public class User
{
    internal string _nome;
    internal string _cognome;
    internal string _email; 
    private string _password;
    public int _userID;
    internal string _dataRegistrazione;
    internal string _dataDiNascita;
    private int _ordini;
    private int _carrello;
    internal string _indirizzo;

    public User(string nome, string cognome, string email, string password, int userID, string dataRegistrazione, string dataDiNascita, int ordini, int carrello, string indirizzo)
    {
        _nome = nome;
        _cognome = cognome;
        _email = email;
        _password = password;
        _userID = userID;
        _dataRegistrazione = dataRegistrazione;
        _dataDiNascita = dataDiNascita;
        _ordini = ordini;
        _carrello = carrello;
        _indirizzo = indirizzo;
    }   
}
