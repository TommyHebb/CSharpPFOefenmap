using System;

namespace CSharpPFOefenmap
{
    public class Kasbon : ISpaarmiddel // Implementatie interface ISpaarmiddel
    {
        private readonly DateTime EersteAankoop = new DateTime(1900, 1, 1);
        private DateTime aankoopDatumValue;
        private decimal bedragValue;
        private int looptijdValue;
        private decimal intrestValue;
        private Klant eigenaarValue;
        public DateTime AankoopDatum // Property
        {
            get
            {
                return aankoopDatumValue;
            }
            set
            {
                if (value < EersteAankoop)
                    throw new Exception(string.Format("De aankoopdatum mag niet voor {0} zijn!",
                        EersteAankoop.ToLongDateString()));
                aankoopDatumValue = value;
            }
        }
        public decimal Bedrag // Property
        {
            get
            {
                return bedragValue;
            }
            set
            {
                if (value <= 0m)
                    throw new Exception("Het bedrag moet positief zijn!");
                bedragValue = value;
            }
        }
        public int Looptijd // Property
        {
            get
            {
                return looptijdValue;
            }
            set
            {
                if (value <= 0)
                    throw new Exception("De looptijd moet positief zijn!");
                looptijdValue = value;
            }
        }
        public decimal Intrest // Property
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
        public Klant Eigenaar // Property, type class Klant
        {
            get
            {
                return eigenaarValue;
            }
            set
            {
                eigenaarValue = value;
            }
        }
        public Kasbon(DateTime aankoopDatum, decimal bedrag, int looptijd, decimal intrest, Klant eigenaar)
        //Constructor met parameters
        {
            AankoopDatum = aankoopDatum;
            Bedrag = bedrag;
            Looptijd = looptijd;
            Intrest = intrest;
            Eigenaar = eigenaar;
        }
        public void Afbeelden() // Method, met implementatie interface ISpaarmiddel
        {
            if (Eigenaar != null)
            {
                Console.Write("Eigenaar: ");
                Eigenaar.Afbeelden(); // Method via class Klant
            }
            Console.WriteLine("Aankoopdatum: {0:dd-MM-yyyy}", AankoopDatum);
            Console.WriteLine("Bedrag: {0}", Bedrag);
            Console.WriteLine("Looptijd: {0}", Looptijd);
            Console.WriteLine("Intrest: {0}", Intrest);
        }
    }
}
