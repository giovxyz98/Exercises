using System;
using System.Runtime.CompilerServices;

namespace EsercizioDelegateCeo
{
    public delegate void Cambio(object obj,EventArgs e);
    public class Even : EventArgs
    {
        public string newCeo;
        public Even(string ceo)
        {
            this.newCeo = ceo;
        }
       

    }
    
    public abstract class Centralbank
    {
        public event Cambio cambio;
        public void Stampa()
        {
            Console.WriteLine($"Ciao {this} il nuovo CEO è {_CEO}");
        }
        public static string _CEO ;
        public string newCEO;
        public string CEO
        {
            get { return _CEO; }
            set
            {
                newCEO = value;
                if (_CEO != newCEO)
                {   
                    _CEO = newCEO;
                    Even even = new Even(newCEO);
                   cambio(this, even);
        
                    

                }
            }

        }
    }
    
}