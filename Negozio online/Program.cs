using System;

namespace Negozio_online
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User("Mario", "Rossi", "mariorossi@gmail.com", "ciao1234", 3242424, "21/10/2022", "18/09/1998", 0, 123456, "via Roma 101");
            
            Carrello carrello1 = new Carrello(3242424, 0, 0);







            Libro Divinacommedia = new Libro("Divina Commedia", 627162, 1300, 15.50, 10, "Italia", "hf7834h87478", "Dante Alighieri", "Mondadori");
            Console.WriteLine(Divinacommedia._nome);
        }
    }
}
