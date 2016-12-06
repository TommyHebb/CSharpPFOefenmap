using System;

namespace CSharpPFOefenmap
{
    public class ZichtRekening : Rekening
    {
        private decimal maxKredietValue;
        public decimal MaxKrediet //Property
        {
            get
            {
                return maxKredietValue;
            }
            set
            {
                if (value > 0m)
                    throw new Exception("De waarde van MaxKrediet mag niet positief zijn!");
                maxKredietValue = value;
            }
        }
        public ZichtRekening(string nummer, decimal saldo, DateTime creatieDatum, decimal maxKrediet, Klant eigenaar)
            : base(nummer, saldo, creatieDatum, eigenaar) // Constructor gebaseerd op constructor base class Rekening
        {
            MaxKrediet = maxKrediet;
        }
        public override void Afbeelden() // van de base class Rekening overriden method
        {
            Console.WriteLine("Zichtrekening:");
            base.Afbeelden();
            Console.WriteLine("Maximum krediet: {0}", MaxKrediet);
        }
    }
}
