using System;
using System.Security.Cryptography.X509Certificates;

public class Confronto
{
    public static void confronto()
    {
        Console.WriteLine("Vuoi sapere quanto è passato dalla tua nascita:si o no");
        string risp = Console.ReadLine();
        if (risp == "si")
        {
            Console.WriteLine("Scrivi qui la tua data di nascita:");
            string imm = Console.ReadLine();
            DateTime datatua = new DateTime();
            DateTime.TryParse(imm, out datatua);
            var result = DateTime.Today.Subtract(datatua);
            int month=datatua.Month;
            int yearR=DateTime.Now.Year-datatua.Year;
            int mesi = yearR * 12;
            Console.WriteLine($"Sono passasti: {yearR} anni");
            Console.WriteLine($"Sono passasti: {mesi} mesi");
            Console.WriteLine($"Sono passasti: {result.TotalDays.ToString()} giorni");
            Console.WriteLine($"Sono passasti: {result.TotalHours.ToString()} ore");
            Console.WriteLine($"Sono passasti: {result.TotalMinutes.ToString()} minuti");
            Console.WriteLine($"Sono passasti: {result.TotalSeconds.ToString()} secondi");
        }
        else if (risp == "no")
        {
            Console.WriteLine("Niente non lo vuoi sapere,chiudi l'applicazione");
        }
        else
        {
            Console.WriteLine("Devi inserire o si o no,riprova\n");
            confronto();
        }
        
    }
}