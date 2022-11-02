using System;

namespace Polimorfismo
{
    public class Country : GeographicalArea, IPolitica

    {
        public string _presidente {get; set;}
        public Regione _regione;
        public string[] _regionea;
        public void addRegione(Regione regione)
        {
            _regione = regione;
            _regione.country = this;
        }
        private string name;
        private string _state;
        private string _government;
        private string _constitution;

        public string Name { get => name; set => name = value; }
        public string State { get => _state; set => _state = value; }
        public string Government { get => _government; set => _government = value; }
        public string Constitution { get => _constitution; set => _constitution = value; }

        public Country()
        {

        }
        public Country (string Name)
        {
            name= Name; 
        }
        public Country(string Name, string State, string Government, string Constitution)

        {
             name = Name;
            _state = State; 
            _government = Government;   
            _constitution = Constitution;
            ShowState();
        }
        void ShowState()
        {          
            Console.WriteLine($"{Name} -  {Constitution}");
        }

    }
}
