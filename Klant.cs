using System;

namespace CSharpPFOefenmap
{
    public class Klant
    {
        private string voornaamValue;
        private string familienaamValue;
        public string Voornaam // Property
        {
            get
            {
                return voornaamValue;
            }
            set
            {
                voornaamValue = value;
            }
        }
        public string Familienaam // Property
        {
            get
            {
                return familienaamValue;
            }
            set
            {
                familienaamValue = value;
            }
        }
        public Klant(string voornaam, string familienaam) // Constructor met parameters
        {
            Voornaam = voornaam;
            Familienaam = familienaam;
        }
        public void Afbeelden() // Method
        {
            Console.Write("Voornaam: {0} - ", Voornaam);
            Console.WriteLine("Familienaam: {0}", Familienaam);
        }
    }
}
