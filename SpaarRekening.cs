using System;

namespace CSharpPFOefenmap
{
    class SpaarRekening : Rekening
    {
        private static decimal intrestValue; // > Statisch gemaakt
        public static decimal Intrest //Property > Statisch gemaakt
        {
            get
            {
                return intrestValue;
            }
            set
            {
                if (value <= 0m)
                    throw new Exception("Intrest moet positief zijn!");
                intrestValue = value;
            }
        }
        public SpaarRekening(string nummer, decimal saldo, DateTime creatieDatum, Klant eigenaar)
            : base(nummer, saldo, creatieDatum, eigenaar) // Constructor gebaseerd op constructor base class Rekening
                                                          // De parameter Intrest is verwijderd (> statisch gemaakt)
        {
            // De parameter Intrest is verwijderd (> statisch gemaakt)
        }
        public override void Afbeelden() // van de base class Rekening overriden method
        {

            Console.WriteLine("Spaarrekening:");
            base.Afbeelden();
            Console.WriteLine("Intrest: {0}", Intrest);
        }
    }
}
