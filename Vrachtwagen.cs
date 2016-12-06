using System;

namespace CSharpPFOefenmap
{
    public class Vrachtwagen : Voertuig, IVervuiler // "Voertuig" is base class, implementatie interface IVervuiler
    {
        private float maximumLadingValue;
        public float MaximumLading // Property
        {
            get
            {
                return maximumLadingValue;
            }
            set
            {
                if (value >= 0f)
                    maximumLadingValue = value;
            }
        }
        public Vrachtwagen(string polishouder, decimal kostprijs, int pk, float gemiddeldVerbruik, 
            string nummerplaat, float maximumLading) : base (polishouder, kostprijs, pk, gemiddeldVerbruik, 
            nummerplaat) // Constructor gebaseerd op constructor base class Voertuig
        {
            MaximumLading = maximumLading;
        }
        public Vrachtwagen() : base()
        {
            MaximumLading = 10000f;
        }
        public override double GetKyotoScore() // van de base class Voertuig overriden method
        {
            double kyotoScore = 0.0;
            if (MaximumLading != 0)
                kyotoScore = (GemiddeldVerbruik * Pk) / (MaximumLading / 1000.0);
            return kyotoScore;
        }
        public override void Afbeelden() // van de base class Voertuig overriden method
        {
            Console.WriteLine("Vrachtwagen:");
            base.Afbeelden();
            Console.WriteLine("Maximum lading: {0}", MaximumLading);
        }
        public double GeefVervuiling() // Implementatie interface IVervuiler
        {
            return GetKyotoScore() * 20;
        }
    }
}
