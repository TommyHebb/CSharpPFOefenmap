namespace CSharpPFOefenmap
{
    public class Plant
    {
        private int plantIdValue;
        private string plantennaamValue;
        private string kleurValue;
        private decimal prijsValue;
        private string soortValue;

        public int PlantId
        {
            get { return plantIdValue; }
            set { plantIdValue = value; }
        }
        public string Plantennaam
        {
            get { return plantennaamValue; }
            set { plantennaamValue = value; }
        }
        public string Kleur
        {
            get { return kleurValue; }
            set { kleurValue = value; }
        }
        public decimal Prijs
        {
            get { return prijsValue; }
            set { prijsValue = value; }
        }
        public string Soort
        {
            get { return soortValue; }
            set { soortValue = value; }
        }

        public Plant() // Nodig voor rechtstreekse initialisatie in hoofdprogramma
        {

        }
        public Plant(int plantId, string plantennaam, string kleur, decimal prijs, string soort)
        {
            PlantId = plantId;
            Plantennaam = plantennaam;
            Kleur = kleur;
            Prijs = prijs;
            Soort = soort;
        }
    }
}
