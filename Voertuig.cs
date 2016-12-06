using System;

namespace CSharpPFOefenmap
{
    public abstract class Voertuig : IPrivaat, IMilieu 
        // > Abstract gemaakt, implementatie interfaces IPrivaat en IMilieu
    {
        private string polishouderValue;
        private decimal kostprijsValue;
        private int pkValue;
        private float gemiddeldVerbruikValue;
        private string nummerplaatValue;
        public string Polishouder // Property
        {
            get
            {
                return polishouderValue;
            }
            set
            {
                polishouderValue = value;
            }
        }
        public decimal Kostprijs // Property
        {
            get
            {
                return kostprijsValue;
            }
            set
            {

                if (value >= 0m)
                    kostprijsValue = value;
            }
        }
        public int Pk // Property
        {
            get
            {
                return pkValue;
            }
            set
            {
                if (value >= 0)
                    pkValue = value;
            }
        }
        public float GemiddeldVerbruik // Property
        {
            get
            {
                return gemiddeldVerbruikValue;
            }
            set
            {
                if (value >= 0f)
                    gemiddeldVerbruikValue = value;
            }
        }
        public string Nummerplaat // Property
        {
            get
            {
                return nummerplaatValue;
            }
            set
            {
                nummerplaatValue = value;
            }
        }
        public Voertuig() : this("Onbepaald", 0m, 0, 0f, "Onbepaald") // Default constructor met constructor chaining
        {
        }
        public Voertuig(string polishouder, decimal kostprijs, int pk, float gemiddeldVerbruik, string nummerplaat)
        { // Constructor met parameters
            this.Polishouder = polishouder;
            this.Kostprijs = kostprijs;
            this.Pk = pk;
            this.GemiddeldVerbruik = gemiddeldVerbruik;
            this.Nummerplaat = nummerplaat;
        }
        public abstract double GetKyotoScore(); // Abstracte method > uitwerking in derived classes
        public virtual void Afbeelden() // Method, overriding in derived class toegelaten (virtual)
        {
            Console.WriteLine("Polishouder: {0}", Polishouder);
            Console.WriteLine("Kostprijs: {0}", Kostprijs);
            Console.WriteLine("Pk: {0}", Pk);
            Console.WriteLine("Gemiddeld verbruik: {0}", GemiddeldVerbruik);
            Console.WriteLine("Nummerplaat: {0}", Nummerplaat);
        }
        public string GeefPrivateData()
        {
            return string.Format("Polishouder: {0} - Nummerplaat: {1}", Polishouder, Nummerplaat);

        }
        public string GeefMilieuData()
        {
            return string.Format("PK: {0} - Kostprijs: {1} - Gemiddeld verbruik: {2}", Pk, Kostprijs, 
                GemiddeldVerbruik);
        }
    }
}
