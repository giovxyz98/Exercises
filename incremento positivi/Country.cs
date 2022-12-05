namespace incremento_positivi
{
    public class Country
    {
        public string Name { get; set; }
        public int _positivi=0;
        public event AumentoPositiviDel AumentoPositivi;

        public int Positivi { get { return _positivi; }
            set {
                if (_positivi != value)
                {
                    AumentoCountry AumentoCountry = new AumentoCountry(value);
                    this.AumentoPositivi=new AumentoPositiviDel(Program.aggiornaPositivi);
                    AumentoPositivi(this,AumentoCountry);
                    _positivi+=value;
                    
                }
                    } }
        

        public Country(string name)
        {
            Name = name;
         
            
        }

    }
}
