using System;

namespace CSharpPFOefenmap
{
    public class BankBediende
    {
        private string voornaamValue;
        private string naamValue;
        public string Voornaam // Property
        {
            get
            {
                return voornaamValue;
            }
            set
            {
                if (value != string.Empty)
                    voornaamValue = value;
            }
        }
        public string Naam // Property
        {
            get
            {
                return naamValue;
            }
            set
            {
                if (value != string.Empty)
                    naamValue = value;
            }
        }
        public BankBediende(string voornaam, string naam) // Constructor
        {
            Voornaam = voornaam;
            Naam = naam;
        }
        public override string ToString() // override van de method ToString() in de class Object
        {
            return "Bankbediende " + Voornaam + ' ' + Naam;
        }
        public void RekeningUittrekselTonen(Rekening rekening)
        // Method met signatuur van delegate Transactie om te reageren op event RekeningUittreksel 
        {
            Console.WriteLine("Datum: {0:dd-MM-yyyy}", DateTime.Today);
            Console.WriteLine("Rekeninguittreksel van rekening {0}", rekening.Nummer);
            Console.WriteLine("Vorig saldo: {0} euro", rekening.VorigSaldo);
            if (rekening.Saldo > rekening.VorigSaldo)
            {
                Console.WriteLine("Storting van {0} euro.", rekening.Saldo - rekening.VorigSaldo);
            }
            else
            {
                Console.WriteLine("Afhaling van {0} euro.", rekening.VorigSaldo - rekening.Saldo);
            }
            Console.WriteLine("Nieuw saldo: {0} euro.", rekening.Saldo);
        }
        public void RekeningInHetRoodMelden(Rekening rekening)
        // Method met signatuur van delegate Transactie om te reageren op event SaldoInHetRood
        {
            Console.WriteLine("Afhaling niet mogelijk, saldo ontoereikend!");
            Console.WriteLine("Maximum af te halen bedrag: {0} euro",
            rekening.Saldo);
        }
    }
}
