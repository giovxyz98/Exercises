namespace Polimorfismo.Interfaces
{
    class CapitalPunishmentCountry :Country, IONU, ICapitalPunishment
    {
        public CapitalPunishmentCountry(string Name, string State, string Government, string Constitution) : 
            base(Name, State, Government, Constitution)
        {
            
        }
        public void Death()
        { 

        }

        public void PopulationControl()
        {
            
        }

        public void TerritoryControl()
        {
            
        }
    }
}

