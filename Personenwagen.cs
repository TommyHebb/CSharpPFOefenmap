using System;

namespace CSharpPFOefenmap
{
    public class Personenwagen : Voertuig, IVervuiler // "Voertuig" is base class, implementatie interface IVervuiler
    {
        private int aantalDeurenValue;
        private int aantalPassagiersValue;
        public int AantalDeuren // Property
        {
            get
            {
                return aantalDeurenValue;
            }
            set
            {
                if (value > 0)
                    aantalDeurenValue = value;
            }
        }
        public int AantalPassagiers // Property
        {
            get
            {
                return aantalPassagiersValue;
            }
            set
            {
                if (value >= 0)
                    aantalPassagiersValue = value;
            }
        }
        public Personenwagen(string polishouder, decimal kostprijs, int pk, float gemiddeldVerbruik,
            string nummerplaat, int aantalDeuren, int aantalPassagiers)
            : base(polishouder, kostprijs, pk, gemiddeldVerbruik, nummerplaat)
        // Constructor gebaseerd op constructor base class Voertuig
        {
            AantalDeuren = aantalDeuren;
            AantalPassagiers = aantalPassagiers;
        }
        public Personenwagen() : base()
        {
            AantalDeuren = 4;
            AantalPassagiers = 5;
        }
        public override double GetKyotoScore() // van de base class Voertuig overriden method
        {
            double kyotoScore = 0.0;
            if (AantalPassagiers != 0)
                kyotoScore = (GemiddeldVerbruik * Pk) / AantalPassagiers;
            return kyotoScore;
        }
        public override void Afbeelden() // van de base class Voertuig overriden method
        {
            Console.WriteLine("Personenwagen:");
            base.Afbeelden();
            Console.WriteLine("Aantal deuren: {0}", AantalDeuren);
            Console.WriteLine("Aantal passagiers: {0}", AantalPassagiers);
        }
        public double GeefVervuiling() // Implementatie interface IVervuiler
        {
            return GetKyotoScore() * 5;
        }
    }
}
