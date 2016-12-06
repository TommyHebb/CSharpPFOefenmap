using System;

namespace CSharpPFOefenmap
{
    public abstract class Rekening : ISpaarmiddel // > Abstract gemaakt, interface ISpaarmiddel geïmplementeerd
    {
        public delegate void Transactie(Rekening rekening);
        // Zie events RekeningUittreksel en SaldoInHetRood + methods Storten() en Afhalen()
        private readonly DateTime EersteCreatie = new DateTime(1900, 1, 1);
        private string nummerValue;
        private decimal saldoValue;
        private DateTime creatieDatumValue;
        private Klant eigenaarValue;
        private decimal vorigSaldoValue;
        public string Nummer // Property
        {
            get
            {
                return nummerValue;
            }
            set
            {
                if (!IsGeldigRekeningNummer(value))
                {
                    throw new Exception("Ongeldig rekeningnummer!");
                }
                nummerValue = value;
            }
        }
        public decimal Saldo // Property
        {
            get
            {
                return saldoValue;
            }
            set
            {
                saldoValue = value;
            }
        }
        public DateTime CreatieDatum // Property
        {
            get
            {
                return creatieDatumValue;
            }
            set
            {
                if (value < EersteCreatie)
                    throw new Exception(string.Format("De creatiedatum mag niet voor {0} zijn!",
                        EersteCreatie.ToLongDateString()));
                creatieDatumValue = value;
            }
        }
        public Klant Eigenaar // Property type Klant (zie class Klant)
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
        public decimal VorigSaldo // Property
        {
            get
            {
                return vorigSaldoValue;
            }
            set
            {
                vorigSaldoValue = value;
            }
        }
        public Rekening(string nummer, decimal saldo, DateTime creatieDatum, Klant eigenaar)
        //Constructor met parameters
        {
            Nummer = nummer;
            Saldo = saldo;
            CreatieDatum = creatieDatum;
            Eigenaar = eigenaar;
        }
        public event Transactie RekeningUittreksel; // Event voor Afhalen() en Storten()
        public event Transactie SaldoInHetRood; // Event voor Afhalen()
        public virtual void Afbeelden() // Method, overriding toegelaten
        {
            if (Eigenaar != null)
            {
                Console.Write("Eigenaar: ");
                Eigenaar.Afbeelden();
            }
            Console.WriteLine("Rekeningnummer: {0}", Nummer);
            Console.WriteLine("Saldo: {0}", Saldo);
            Console.WriteLine("Creatiedatum: {0:dd-MM-yyyy}", CreatieDatum); // Met format
        }
        public void Storten(decimal bedrag) // Method
        {
            VorigSaldo = Saldo;
            Saldo += bedrag;
            if (RekeningUittreksel != null)
                RekeningUittreksel(this); // Zie event Transactie RekeningUittreksel
        }
        public void Afhalen(decimal bedrag) // Method
        {
            VorigSaldo = Saldo;
            if (bedrag <= Saldo)
            {
                Saldo -= bedrag;
                if (RekeningUittreksel != null)
                    RekeningUittreksel(this); // Zie event Transactie RekeningUittreksel
            }
            else
            {
                if (SaldoInHetRood != null)
                    SaldoInHetRood(this); // Zie event Transactie SaldoInHetRood
            }
        }
        private bool IsGeldigRekeningNummer(string rekeningNummer)
        {
            if (string.IsNullOrWhiteSpace(rekeningNummer))
                return false; //als rekeningNummer null is of enkel (een) spatie(s) 
            if (rekeningNummer.Length != 16)
                return false; //als lengte gehele rekeningNummer niet gelijk is aan 16 (geen spaties!)
            if (rekeningNummer.Substring(0, 2) != "BE")
                return false; //als substring niet gelijk is aan "BE" (2 eerste karakters)
            int derdevierdeteken;
            if (!int.TryParse(rekeningNummer.Substring(2, 2), out derdevierdeteken))
                return false; //als substring geen (!) int is (2 cijfers nà BE)
            ulong belgischRekeningNummer; //alles vanaf 5e karakter, dus 12 cijfers)
            if (!ulong.TryParse(rekeningNummer.Substring(4, 12), out belgischRekeningNummer))
                return false; //als substring geen (!) ulong is
            ulong eerste10 = belgischRekeningNummer / 100ul;
            int laatste2 = (int)(belgischRekeningNummer % 100ul); //(casting gebruikt om ulong om te zetten naar int)
            return (int)(eerste10 % 97ul) == laatste2; //default return, indien geldig nummer (casting gebruikt)
            /* Uitleg: De method probeert eerst alle if-statements en geeft, zo nodig, als return "false".
            De if-statements controleren enkel de samenstelling van het IBAN-nummer.
            Indien alle if-statements doorlopen zijn (nergens problemen, dus geen return "false"), volgt de 
            eigenlijke test of het nummer een geldig nummer is. Deze test volgt rechtstreeks op de default return.
            Zo nee > false, Zo ja > true.
            */
        }
    }
}
