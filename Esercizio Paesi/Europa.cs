using System;
using System.Collections;

public class Europa
{
    public string NomePaese { get; set; }
    public void PaesiEuroZona()
    {
        
        Console.WriteLine($"Austria");
        Console.WriteLine($"Belgio");
        Console.WriteLine($"Cipro");
        Console.WriteLine($"Estonia");
        Console.WriteLine($"Finlandia");
        Console.WriteLine($"Francia");
        Console.WriteLine($"Germania");
        Console.WriteLine($"Grecia");
        Console.WriteLine($"Irlanda");
        Console.WriteLine($"Italia");
        Console.WriteLine($"Lettonia");
        Console.WriteLine($"Lituania");
        Console.WriteLine($"Lussemburgo");
        Console.WriteLine($"Malta");
        Console.WriteLine($"Paesi Bassi");
        Console.WriteLine($"Portogallo");
        Console.WriteLine($"Slovacchia");
        Console.WriteLine($"Slovenia");
        Console.WriteLine($"Spagna");
    }
    public void PaesiUE()
    {
        PaesiEuroZona();
        Console.WriteLine($"Bulgaria");
        Console.WriteLine($"Croazia");
        Console.WriteLine($"Danimarca");
        Console.WriteLine($"Polonia");
        Console.WriteLine($"Repubblica Ceca");
        Console.WriteLine($"Romania");
        Console.WriteLine($"Svezia");
        Console.WriteLine($"Ungheria");
    }
}