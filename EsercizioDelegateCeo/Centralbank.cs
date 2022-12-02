using System;

namespace EsercizioDelegateCeo
{
    public abstract class Centralbank

    {
        public void CambiaCeo(Action action)
        {
            action();
        }
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
                    CambiaCeo(Stampa);
                    

                }
            }

        }
    }
    
}