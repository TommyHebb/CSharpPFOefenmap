using System;
using System.Collections.Generic;
using System.Linq;
namespace CSharpPFOefenmap
{
    class Program
    {
        const float GemLichTempCelsius = 37.0F; //Oefening 1.1: Conversie Celsius > Fahrenheit
        const int SecInEenMin = 60; //Oefening 1.2: Omrekening seconden
        const int SecInEenUur = 3600; //Oefening 1.2: Omrekening seconden
        const int Invoermunt = 2; //Oefening 1.3: Snoepautomaat
        const string OpeningsurenWerkdag = "9u00 tot 12u00 en 13u00 tot 18u00"; //Oefening 2.3: Lichtkrant
        const string OpeningsurenZaterdag = "10u00 tot 12u00"; //Oefening 2.3: Lichtkrant
        const string OpeningsurenZondag = "Gesloten"; //Oefening 2.3: Lichtkrant
        const string Openingsuren = "Gesloten"; //Oefening 2.3: Lichtkrant
        const string BoodschapWeekdag = "We wensen u een prettige werkdag!"; //Oefening 2.3: Lichtkrant
        const string BoodschapWeekend = "We wensen u een fijn weekend!"; //Oefening 2.3: Lichtkrant
        const string ALFABET = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"; //Oefening 3.3 en 3.4 (controle) IBAN rekeningnummer (generator)
        /*
delegate bool Filter(int getal); //Voor oefening 13: Lambda expresssies (A)
private static bool Even(int getal) //Oefening 13: Method (A)
{
return (getal % 2 == 0);
}
private static bool Oneven(int getal) //Oefening 13: Method (A)
{
return (getal % 2 == 1);
}
private static bool Pos(int getal) //Oefening 13: Method (A)
{
return (getal >= 0);
}
private static bool Neg(int getal) //Oefening 13: Method (A)
{
return (getal < 0);
}
*/
        /*
        delegate ConsoleColor KleurGetal(int getal); //Voor oefening 13: Functie (B)
        */
        /*
        delegate void KleurGetal(int getal); //Voor oefening 13: Functie (C)
        */
        static void Main(string[] args)
        {
            /*
            int height = 100;
            int width = 80;
            //Console.SetWindowSize (width, height); //Lukt vooralsnog niet (permissions?)
            Console.WriteLine("The current buffer height is {0}, and the current buffer width is {1}.", Console.BufferHeight, Console.BufferWidth);
            int origWidth, origHeight;
            string m1 = "The current window height is {0}, and the current window width is {1}.";
            string m4 = "     (Press any key to continue...)";
            origWidth = Console.WindowWidth;
            origHeight = Console.WindowHeight;
            Console.WriteLine(m1, Console.WindowHeight, Console.WindowWidth);
            Console.WriteLine(m4);
            Console.ReadKey(true);
            */
            /*
            Console.WriteLine("==================================================");
            Console.WriteLine("Oefening 1.1: Conversie Celsius > Fahrenheit:");
                    //Opgelet: gebruik van const
            Console.WriteLine("------------");
            float gemLichTempFahrenheit = GemLichTempCelsius * 9.0F / 5.0F + 32.0F;
            Console.WriteLine("Gem. lichaamstemperatuur in graden " + "Celsius: {0}", GemLichTempCelsius);
            Console.WriteLine("Gem. lichaamstemperatuur in graden " + "Fahrenheit: {0}", gemLichTempFahrenheit);
            Console.WriteLine("==================================================");
            */
            /*
            Console.WriteLine("==================================================");
            Console.WriteLine("Oefening 1.2: Omrekening seconden:");
                    //Opgelet: gebruik van const
            Console.WriteLine("------------");
            int totaalAantalSec = 3736;
            int uren, minuten, seconden, restseconden;
            uren = totaalAantalSec / SecInEenUur;
            restseconden = totaalAantalSec % SecInEenUur;
            minuten = restseconden / SecInEenMin;
            seconden = restseconden % SecInEenMin;
            Console.WriteLine("Aantal om te zetten seconden:{0}", totaalAantalSec);
            Console.WriteLine("Uitgedrukt in uren/minuten/seconden: U:{0} M:{1} S:{2}", uren, minuten, seconden);
            Console.WriteLine("==================================================");
            */
            /*
            Console.WriteLine("==================================================");
            Console.WriteLine("Oefening 1.3: Snoepautomaat:");
                    //Opgelet: gebruik van const
            Console.WriteLine("------------");
            decimal teBetalen = 1.04M;
            decimal restBedrag;
            int aantal1EuroStukken, aantal50CentStukken, aantal20CentStukken, aantal10CentStukken;
            int aantal5CentStukken, aantal2CentStukken, aantal1CentStukken;
            restBedrag = Invoermunt;
            Console.WriteLine("Te betalen bedrag: {0}", teBetalen + " Euro");
            Console.WriteLine("Terug te krijgen bedrag: {0}", Invoermunt - teBetalen + " Euro");
            Console.WriteLine("Restbedrag = {0}", restBedrag);
            aantal1EuroStukken = (int)(Invoermunt - teBetalen);
            restBedrag = Invoermunt - teBetalen - aantal1EuroStukken;
            Console.WriteLine("Aantal stukken van " + "1 Euro: {0}", aantal1EuroStukken);
            Console.WriteLine("Restbedrag = {0}", restBedrag);
            aantal50CentStukken = (int)(restBedrag / 0.50M);
            restBedrag = restBedrag - aantal50CentStukken * 0.5M;
            Console.WriteLine("Aantal stukken van " + "50 Eurocent: {0}", aantal50CentStukken);
            Console.WriteLine("Restbedrag = {0}", restBedrag);
            aantal20CentStukken = (int)(restBedrag / 0.20M);
            restBedrag = restBedrag - aantal20CentStukken * 0.2M;
            Console.WriteLine("Aantal stukken van " + "20 Eurocent: {0}", aantal20CentStukken);
            Console.WriteLine("Restbedrag = {0}", restBedrag);
            aantal10CentStukken = (int)(restBedrag / 0.10M);
            restBedrag = restBedrag - aantal10CentStukken * 0.1M;
            Console.WriteLine("Aantal stukken van " + "10 Eurocent: {0}", aantal10CentStukken);
            Console.WriteLine("Restbedrag = {0}", restBedrag);
            aantal5CentStukken = (int)(restBedrag / 0.05M);
            restBedrag = restBedrag - aantal5CentStukken * 0.05M;
            Console.WriteLine("Aantal stukken van " + "5 Eurocent: {0}", aantal5CentStukken);
            Console.WriteLine("Restbedrag = {0}", restBedrag);
            aantal2CentStukken = (int)(restBedrag / 0.02M);
            restBedrag = restBedrag - aantal2CentStukken * 0.02M;
            Console.WriteLine("Aantal stukken van " + "2 Eurocent: {0}", aantal2CentStukken);
            Console.WriteLine("Restbedrag = {0}", restBedrag);
            aantal1CentStukken = (int)(restBedrag / 0.01M);
            restBedrag = restBedrag - aantal1CentStukken * 0.01M;
            Console.WriteLine("Aantal stukken van " + "1 Eurocent: {0}", aantal1CentStukken);
            Console.WriteLine("Restbedrag = {0}", restBedrag);
            Console.WriteLine("==================================================");
            */
            /*
            Console.WriteLine("==================================================");
            Console.WriteLine("Oefening 2.1: Kortingsbon:");
            Console.WriteLine("------------");
            decimal kortingsPercentage;
            Console.WriteLine("Voer een aankoopbedrag in");
            decimal aankoopbedrag = decimal.Parse(Console.ReadLine());
            if (aankoopbedrag > 100M)
            {
                kortingsPercentage = 0.05M;
            }
            else if (aankoopbedrag <= 100 && aankoopbedrag > 50)
            {
                kortingsPercentage = 0.03M;
            }
            else if (aankoopbedrag <= 50 && aankoopbedrag > 25)
            {
                kortingsPercentage = 0.02M;
            }
            else
            {
                kortingsPercentage = 0.01M;
            }
            Console.WriteLine($"De korting is: {aankoopbedrag * kortingsPercentage} euro");
            Console.WriteLine("==================================================");
            */
            /*
            Console.WriteLine("==================================================");
            Console.WriteLine("Oefening 2.2: Schrikkeljaar:");
            Console.WriteLine("------------");
            Console.Write("Voer jaartal in: ");
            int jaar = int.Parse(Console.ReadLine());
                    //oplossing 1
            string schrikkel;
            if (jaar % 4 == 0)
                if (jaar % 100 == 0 && jaar % 400 != 0)
                    schrikkel = "geen";
                else schrikkel = "een";
            else
                schrikkel = "geen";
            Console.WriteLine("Het jaar {0} is {1} schrikkeljaar", jaar, schrikkel);
                    //oplossing 2 
            Console.WriteLine($"Het jaar {jaar} is " + 
                $"{((jaar % 4 == 0 && jaar % 100 != 0) || jaar % 400 == 0 ? "een" : "geen")}" + 
                $" schrikkeljaar");
                    //Merk hierbij op dat de volledige expressie tussen ronde haakjes vermeld wordt 
                    //om te vermijden dat de dubbele punt als scheidingsteken 
                    //voor een opmaakcode geïnterpreteerd wordt.
            Console.WriteLine("==================================================");
            */
            /*
            Console.WriteLine("==================================================");
            Console.WriteLine("Oefening 2.3: Lichtkrant:");
                    //Opgelet: gebruik van const
            Console.WriteLine("------------");
            Console.Write("Geef een datum in: ");
            DateTime dag = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Ingegeven datum {0} is een {1}.", dag, dag.DayOfWeek);
            StringBuilder boodschap = new StringBuilder("Openingsuren: ");
            switch (dag.DayOfWeek)
            {
                case DayOfWeek.Tuesday:
                case DayOfWeek.Wednesday:
                case DayOfWeek.Thursday:
                case DayOfWeek.Friday:
                    boodschap.Append(OpeningsurenWerkdag);
                    boodschap.AppendLine();
                    boodschap.Append(BoodschapWeekdag);
                    break;
                case DayOfWeek.Saturday:
                    boodschap.Append(OpeningsurenZaterdag);
                    boodschap.AppendLine();
                    boodschap.Append(BoodschapWeekend);
                    break;
                case DayOfWeek.Sunday:
                    boodschap.Append(OpeningsurenZondag);
                    boodschap.AppendLine();
                    boodschap.Append(BoodschapWeekend);
                    break;
                default:
                    boodschap.Append(Openingsuren);
                    boodschap.AppendLine();
                    boodschap.Append(BoodschapWeekdag);
                    break;
            }
            Console.WriteLine(boodschap.ToString());
            Console.WriteLine("==================================================");
            */
            /*
            Console.WriteLine("==================================================");
            Console.WriteLine("Oefening 3.1: Kleinste, grootste en gemiddelde:");
            Console.WriteLine("------------");
            int getal;
            do
            {
                Console.WriteLine("Voer een eerste positief getal in of stop door -1 in te voeren: ");
                getal = int.Parse(Console.ReadLine());
            }
            while (getal != -1 && getal < 0);
            int kleinste = getal, grootste = getal, totaal = 0, aantal = 0;
            while (getal != -1)
            {
                if (getal >= 0)
                {
                    if (getal < kleinste)
                        kleinste = getal;
                    if (getal > grootste)
                        grootste = getal;
                    totaal += getal;
                    aantal++;
                }
                else
                {
                    Console.WriteLine("Enkel positieve getallen zijn toegestaan.");
                    Console.WriteLine("Stop door -1 in te voeren: ");
                }
                Console.WriteLine("Geef een volgend positief getal in of stop door -1 in te voeren: ");
                getal = int.Parse(Console.ReadLine());
            }
            if (aantal > 0)
            {
                Console.WriteLine("Het kleinste getal: {0}", kleinste);
                Console.WriteLine("Het grootste getal: {0}", grootste);
                Console.WriteLine("Het gemiddelde: {0}", (double) totaal / aantal);
            }
            else
                Console.WriteLine("Er werden geen getallen ingevoerd.");
            Console.WriteLine("==================================================");
            */
            /*
            Console.WriteLine("==================================================");
            Console.WriteLine("Oefening 3.2: Priemgetal:");
            //OPGELET: Deze oplossing (uit de cursus!!!) is FOUT, want geeft 1 aan als priemgetal en dat klopt niet!!
            Console.WriteLine("------------");
            int delers = 0;
            Console.Write("Voer een positief geheel getal > 0 in: ");
            int getal = int.Parse(Console.ReadLine());
            if (getal > 0)
            {
                for (int teller = 2; teller <= getal - 1; teller++)
                    if (getal % teller == 0)
                    {
                        Console.WriteLine("Getal is deelbaar door {0}", teller);
                        delers++;
                    }
                if (delers > 0)
                    Console.WriteLine("Het getal is geen priemgetal.");
                else
                    Console.WriteLine("Het getal is een priemgetal.");
            }
            else
                Console.WriteLine("Verkeerde invoer.");
            Console.WriteLine("==================================================");
            */
            /*
            Console.WriteLine("==================================================");
            Console.WriteLine("Oefening 3.3: IBAN rekeningnummer generator:");
                    //Opgelet: gebruik van const èn private static method VervangLetters(nummer)
            Console.WriteLine("------------");
            string belgischRekeningNr, ibanRekeningNr, ibanRekeningNrControle, controlegetal, controleNr;
            ulong rest97;
            Console.WriteLine("Geef een Belgisch rekeningnummer in (format xxx-xxxxxxx-xx)"); //Voorbeeld: "739-0102134-91"
            belgischRekeningNr = Console.ReadLine();
            ibanRekeningNrControle = belgischRekeningNr.Replace("-", "") + "BE00";
            //vervanging letters door cijfers: A=10, B=11, ... 
            controleNr = VervangLetters(ibanRekeningNrControle);
            //IBAN rekeningnummer samenstellen 
            rest97 = ulong.Parse(controleNr) % 97ul;
            controlegetal = (98 - rest97).ToString();
            ibanRekeningNr = "BE" + (controlegetal.Length == 2 ? controlegetal : "0" + controlegetal) + 
                ibanRekeningNrControle.Substring(0, ibanRekeningNrControle.Length - 4);
                    //of
            //ibanRekeningNr = string.Format($"BE" + 
            // $"{(controlegetal.Length == 2 ? controlegetal : "0" + controlegetal)}" + 
            // $"{ibanRekeningNrControle.Substring(0, ibanRekeningNrControle.Length - 4)}");
            ibanRekeningNr = ibanRekeningNr.Insert(12, " ").Insert(8, " ").Insert(4, " ");
            Console.WriteLine("rekeningnummer: {0} als IBAN rekeningnummer: {1}", belgischRekeningNr, ibanRekeningNr);
            Console.WriteLine("==================================================");
            */
            /*
            Console.WriteLine("==================================================");
            Console.WriteLine("Oefening 3.4: Controle IBAN rekeningnummer:");
            //Opgelet: gebruik van const èn private static method VervangLetters(nummer)
            Console.WriteLine("------------");
            string ibanRekeningNr, controleNr;
            Console.WriteLine("Geef een IBAN rekeningnummer in (format BExx xxxx xxxx xxxx)"); //Voorbeeld: "BE23 7390 1021 3491"
            ibanRekeningNr = Console.ReadLine();
            controleNr = ibanRekeningNr.Replace(" ", "");
            controleNr = controleNr.Substring(4) + controleNr.Substring(0, 4);
            controleNr = VervangLetters(controleNr); 
            Console.WriteLine(ulong.Parse(controleNr) % 97ul == 1 ? 
                "geldig rekeningnummer" : "geen geldig rekeningnummer");
            Console.WriteLine("==================================================");
            */
            /*
            Console.WriteLine("==================================================");
            Console.WriteLine("Oefening 4.1: Codeerprogramma:"); //Mijn oplossing, met mogelijkheid eigen sleutel.
            Console.WriteLine("------------");
            char[] arraySleutel = new char[26];
            string standaardSleutel = "QSPATVXBCRJYEDUOHZGIFLNWKM";
            string tekst;
            string gecodeerdeTekst = string.Empty;
            Console.Write("Geef de sleutel in (26 VERSCHILLENDE LETTERS of \"0\" voor de standaard sleutel): ");
            string invoerCode = Console.ReadLine();
            int lengteInvoerCode = invoerCode.Length;
            if (invoerCode == "0")
                for (int teller = 0; teller < standaardSleutel.Length; teller++)
                    arraySleutel[teller] = standaardSleutel[teller];
            else
            {
                while (lengteInvoerCode < 26)
                {
                    Console.WriteLine("Dat zijn slechts {0} letters. De sleutel moet exact 26 letters bevatten!", lengteInvoerCode);
                    Console.Write("Geef de sleutel in (26 VERSCHILLENDE LETTERS of \"0\" voor de standaard sleutel): ");
                    invoerCode = Console.ReadLine();
                    lengteInvoerCode = invoerCode.Length;
                }
                for (int teller = 0; teller < invoerCode.Length; teller++)
                    arraySleutel[teller] = invoerCode.ToUpper()[teller];
            }
            //Console.WriteLine("De invoer was: {0}", invoerCode.ToUpper()); //ter controle
            //Console.Write("De sleutel is: "); //ter controle
            //foreach (char letter in arraySleutel) //ter controle
            //    Console.Write(letter); //ter controle
            //Console.WriteLine(""); //ter controle
            Console.Write("Geef de te coderen tekst in: ");
            tekst = Console.ReadLine().ToUpper();
            //Console.WriteLine("De te coderen tekst is: {0}", tekst); //ter controle
            for (int teller = 0; teller < tekst.Length; teller++)
                if (tekst[teller] >= 'A' && tekst[teller] <= 'Z')
                    gecodeerdeTekst += arraySleutel[(int)tekst[teller] - (int)'A'];
                else
                    gecodeerdeTekst += tekst[teller];
            Console.WriteLine("De tekst is in code omgezet: {0}", gecodeerdeTekst);
            Console.WriteLine("==================================================");
            */
            /*
            Console.WriteLine("==================================================");
            Console.WriteLine("Oefening 4.1: Codeerprogramma:"); //Oplossing cursus.
            Console.WriteLine("------------");
            char[] sleutel ={'Q','S','P','A','T','V','X','B','C','R','J','Y','E','D','U','O',
                'H','Z','G','I','F','L','N','W','K','M'};
            Console.Write("Voer je tekst in:");
            string tekst = Console.ReadLine().ToUpper();
            string gecodeerd = string.Empty;
            for (int teller = 0; teller < tekst.Length; teller++)
                if (tekst[teller] >= 'A' && tekst[teller] <= 'Z')
                    gecodeerd += sleutel[(int)tekst[teller] - (int)'A'];
                else
                    gecodeerd += tekst[teller];
            Console.WriteLine("In code: {0}", gecodeerd);
            Console.WriteLine("==================================================");
            */
            /*
            Console.WriteLine("==================================================");
            Console.WriteLine("Oefening 5.1.1: Bank:"); 
            Console.WriteLine("------------");
            Console.WriteLine("Zie de class \"Rekening\""); 
            Console.WriteLine("==================================================");
            Console.WriteLine("Oefening 5.1.2: Het hoofdprogramma:");
            Console.WriteLine("------------");
            Rekening mijnRekening = new Rekening("BE56001900200088", 0, DateTime.Today);
            decimal bedrag = 100.00M;
            mijnRekening.Afbeelden();
            Console.WriteLine("------------");
            mijnRekening.Storten(bedrag);
            Console.WriteLine("Bedrag gestort op rekening {0}: {1}", mijnRekening.Nummer, bedrag);
            Console.WriteLine("------------");
            mijnRekening.Afbeelden();
            Console.WriteLine("==================================================");
            */
            /*
            Console.WriteLine("==================================================");
            Console.WriteLine("Oefening 5.2.1: Voertuigen:");
            Console.WriteLine("------------");
            Console.WriteLine("Zie de class \"Voertuig\"");
            Console.WriteLine("==================================================");
            Console.WriteLine("Oefening 5.2.2: Het hoofdprogramma:");
            Console.WriteLine("------------");
            Voertuig voertuig1 = new Voertuig();
            Voertuig voertuig2 = new Voertuig("Jan", 10000m, 75, 6.0f, "1-ABC-123");
            Voertuig voertuig3 = new Voertuig("Piet", 15000m, 80, -7.5f, "1-DEF-456");
            voertuig1.Afbeelden();
            Console.WriteLine("------------");
            voertuig2.Afbeelden();
            Console.WriteLine("------------");
            voertuig3.Afbeelden();
            Console.WriteLine("==================================================");
            */
            /*
            Console.WriteLine("==================================================");
            Console.WriteLine("Oefening 6.1.1: ZichtRekening:");
            Console.WriteLine("------------");
            Console.WriteLine("Zie de class \"Rekening\" (virtual) en \"ZichtRekening\"");
            Console.WriteLine("==================================================");
            Console.WriteLine("Oefening 6.1.2: SpaarRekening:");
            Console.WriteLine("------------");
            Console.WriteLine("Zie de class \"Rekening\" (virtual) en \"SpaarRekening\"");
            Console.WriteLine("==================================================");
            Console.WriteLine("Oefening 6.1.3: Het hoofdprogramma:");
            Console.WriteLine("------------");
            SpaarRekening spaarRekening1 = new SpaarRekening("BE56001900200088", 0m, DateTime.Today, 1.20m);
            ZichtRekening zichtRekening1 = new ZichtRekening("BE73063154756360", 0m, DateTime.Today, -2500m);
            spaarRekening1.Storten(1000m);
            spaarRekening1.Afbeelden();
            Console.WriteLine("------------");
            zichtRekening1.Storten(125m);
            zichtRekening1.Afbeelden();
            Console.WriteLine("==================================================");
            */
            /*
            Console.WriteLine("==================================================");
            Console.WriteLine("Oefening 6.2.1: Vrachtwagen:");
            Console.WriteLine("------------");
            Console.WriteLine("Zie de class \"Voertuig\" (public en virtual) en \"Vrachtwagen\"");
            Console.WriteLine("==================================================");
            Console.WriteLine("Oefening 6.2.2: Personenwagen:");
            Console.WriteLine("------------");
            Console.WriteLine("Zie de class \"Voertuig\" (public en virtual) en \"Personenwagen\"");
            Console.WriteLine("==================================================");
            Console.WriteLine("Oefening 6.2.3: Het hoofdprogramma:");
            Console.WriteLine("------------");
            Vrachtwagen vrachtwagen1 = new Vrachtwagen("Asterix", 30000m, 400, 30f, "ABC-123", 15000f);
            Vrachtwagen vrachtwagen2 = new Vrachtwagen();
            Personenwagen personenwagen1 = new Personenwagen("Obelix", 14500m, 14, 8f, "DEF-456", 3, 4);
            Personenwagen personenwagen2 = new Personenwagen();
            vrachtwagen1.Afbeelden();
            Console.WriteLine("------------");
            vrachtwagen2.Afbeelden();
            Console.WriteLine("------------");
            personenwagen1.Afbeelden();
            Console.WriteLine("------------");
            personenwagen2.Afbeelden();
            Console.WriteLine("==================================================");
            */
            /*
            Console.WriteLine("==================================================");
            Console.WriteLine("Oefening 7.1.1: De abstracte class Rekening:");
            Console.WriteLine("------------");
            Console.WriteLine("Zie de class \"Rekening\" (abstract gemaakt)");
            Console.WriteLine("==================================================");
            Console.WriteLine("Oefening 7.1.2: Static member intrest:");
            Console.WriteLine("------------");
            Console.WriteLine("Zie de class \"SpaarRekening\" (Intrest statisch gemaakt)");
            Console.WriteLine("==================================================");
            Console.WriteLine("Oefening 7.2.1: De abstracte class Voertuig:");
            Console.WriteLine("------------");
            Console.WriteLine("Zie de class \"Voertuig\" (abstract gemaakt)");
            Console.WriteLine("==================================================");
            Console.WriteLine("Oefening 7.2.2: De method GetKyotoScore():");
            Console.WriteLine("------------");
            Console.WriteLine("Zie de class \"Voertuig\" (abstracte method toegevoegd), \"Vrachtwagen\" en \"Personenwagen\" (override method");
            Console.WriteLine("==================================================");
            */
            /*
            Console.WriteLine("==================================================");
            Console.WriteLine("Oefening 8.1.1: Rekeningen afbeelden:");
            Console.WriteLine("------------");
            SpaarRekening.Intrest = 3m;
            Rekening[] rekeningen = new Rekening[2];
            rekeningen[0] = new ZichtRekening("BE40747524091936", 14.51m, DateTime.Today, -500m);
            rekeningen[1] = new SpaarRekening("BE40645100000163", 1000m, DateTime.Today);
            foreach (Rekening rekening in rekeningen)
            {
                rekening.Afbeelden();
                Console.WriteLine("------------");
            }
            Console.WriteLine("==================================================");
            Console.WriteLine("Oefening 8.2.1: Voertuigen afbeelden");
            Console.WriteLine("------------");
            Vrachtwagen vw = new Vrachtwagen("Jan", 40000m, 500, 30, "1-ABC-123", 10000);
            Personenwagen pw = new Personenwagen("Piet", 15000m, 8, 6.5f, "1-DEF-456", 5, 5);
            Voertuig[] voertuigen = new Voertuig[2];
            voertuigen[0] = vw;
            voertuigen[1] = pw;
            foreach (Voertuig voertuig in voertuigen)
            {
                voertuig.Afbeelden();
                Console.WriteLine(voertuig.GetKyotoScore());
                Console.WriteLine("------------");
            }
            Console.WriteLine("==================================================");
            */
            /*
            Console.WriteLine("==================================================");
            Console.WriteLine("Oefening 9.1.1: De class Klant:");
            Console.WriteLine("------------");
            Console.WriteLine("Zie de class \"Klant\"");
            Console.WriteLine("==================================================");
            Console.WriteLine("Oefening 9.1.2: De class Rekening:");
            Console.WriteLine("------------");
            Console.WriteLine("Zie de class \"Rekening\" (property Eigenaar + constructor + Afbeelden)");
            Console.WriteLine("==================================================");
            Console.WriteLine("Oefening 9.1.3: De class SpaarRekening:");
            Console.WriteLine("------------");
            Console.WriteLine("Zie de class \"SpaarRekening\" (Constructor)");
            Console.WriteLine("==================================================");
            Console.WriteLine("Oefening 9.1.4: De class ZichtRekening:");
            Console.WriteLine("------------");
            Console.WriteLine("Zie de class \"ZichtRekening\" (Constructor)");
            Console.WriteLine("==================================================");
            Console.WriteLine("Oefening 9.1.5: Het hoofdprogramma:");
            Console.WriteLine("------------");
            Klant klant = new Klant("Jan", "Jansen");
            SpaarRekening.Intrest = 3m;
            Rekening[] rekeningen = new Rekening[2];
            rekeningen[0] = new SpaarRekening("BE40747524091936", 25.81m, DateTime.Today, klant);
            rekeningen[1] = new ZichtRekening("BE40645100000163", 1500, DateTime.Today, -500, klant);
            foreach (Rekening rekening in rekeningen)
            {
                rekening.Afbeelden();
                Console.WriteLine("------------");
            }
            Console.WriteLine("==================================================");
            */
            /*
            Console.WriteLine("==================================================");
            Console.WriteLine("Oefening 10.1.1: De interface ISpaarmiddel:");
            Console.WriteLine("------------");
            Console.WriteLine("Zie de interface \"ISpaarmiddel\"");
            Console.WriteLine("==================================================");
            Console.WriteLine("Oefening 10.1.2: De class Rekening:");
            Console.WriteLine("------------");
            Console.WriteLine("Zie de class \"Rekening\" (: ISpaarmiddel)");
            Console.WriteLine("==================================================");
            Console.WriteLine("Oefening 10.1.3: De class Kasbon:");
            Console.WriteLine("------------");
            Console.WriteLine("Zie de class \"Kasbon\"");
            Console.WriteLine("==================================================");
            Console.WriteLine("Oefening 10.1.4: Het hoofdprogramma:");
            Console.WriteLine("------------");
            Klant klant = new Klant("Jan", "Jansen");
            SpaarRekening.Intrest = 3m;
            ISpaarmiddel[] middelen = new ISpaarmiddel[3];
            middelen[0] = new ZichtRekening("BE40645100000163", 1500, DateTime.Today, -500, klant);
            middelen[1] = new SpaarRekening("BE40747524091936", 25.81m, DateTime.Today, klant);
            middelen[2] = new Kasbon(DateTime.Today, 500m, 5, 3.4m, klant);
            foreach (ISpaarmiddel middel in middelen)
            {
                middel.Afbeelden();
                Console.WriteLine("------------");
            }
            Console.WriteLine("==================================================");
            */
            /*
            Console.WriteLine("==================================================");
            Console.WriteLine("Oefening 10.2.1: De interface IVervuiler:");
            Console.WriteLine("------------");
            Console.WriteLine("Zie de interface \"IVervuiler\" en classes \"Personenwagen\" en \"Vrachtwagen\"");
            Console.WriteLine("==================================================");
            Console.WriteLine("Oefening 10.2.2: De class Stookketel:");
            Console.WriteLine("------------");
            Console.WriteLine("Zie de class \"Stookketel\"");
            Console.WriteLine("==================================================");
            Console.WriteLine("Oefening 10.2.3: Het hoofdprogramma:");
            Console.WriteLine("------------");
            IVervuiler[] vervuilers = new IVervuiler[3];
            vervuilers[0] = new Vrachtwagen("Jan Jansen", 40000m, 500, 11.3f, "1-ABC-123", 12000f);
            vervuilers[1] = new Personenwagen("Piet Pieters", 29000m, 18, 7.1f, "1-DEF-456", 4, 5);
            vervuilers[2] = new Stookketel(7.5f);
            foreach (IVervuiler vervuiler in vervuilers)
            {
                Console.WriteLine("Vervuiling: {0}", vervuiler.GeefVervuiling());
                Console.WriteLine("------------");
            }
            Console.WriteLine("==================================================");
            */
            /*
            Console.WriteLine("==================================================");
            Console.WriteLine("Oefening 10.2.4: De interface IVervuiler:");
            Console.WriteLine("------------");
            Console.WriteLine("Zie de interfaces \"IPrivaat\" en \"IMilieu\" en class \"Voertuig\"");
            Console.WriteLine("------------");
            Console.WriteLine("Het hoofdprogramma:");
            Console.WriteLine("------------");
            Vrachtwagen vw1 = new Vrachtwagen("Jan Jansen", 40000m, 500, 11.3f, "1-ABC-123", 12000f);
            Personenwagen pw1 = new Personenwagen("Piet Pieters", 29000m, 18, 7.1f, "1-DEF-456", 4, 5);
            Personenwagen pw2 = new Personenwagen("Jos Jorissen", 14700m, 11, 6.3f, "1-GHI-789", 5, 5);
            IPrivaat[] privaten = new IPrivaat[3];
            privaten[0] = vw1;
            privaten[1] = pw1;
            privaten[2] = pw2;
            foreach (IPrivaat privaat in privaten)
            {
                Console.WriteLine(privaat.GeefPrivateData());
                Console.WriteLine("------------");
            }
            Console.WriteLine("==================================================");
            IMilieu[] vervuilers = new IMilieu[3];
            vervuilers[0] = vw1;
            vervuilers[1] = pw1;
            vervuilers[2] = pw2;
            foreach (IMilieu vervuiler in vervuilers)
            {
                Console.WriteLine(vervuiler.GeefMilieuData());
                Console.WriteLine("------------");
            }
            */
            /*
            Console.WriteLine("==================================================");
            Console.WriteLine("Oefening 11.1.1: De class Rekening:");
            Console.WriteLine("------------");
            Console.WriteLine("Zie de class \"Rekening\"");
            Console.WriteLine("==================================================");
            Console.WriteLine("Oefening 11.1.2: De class BankBediende:");
            Console.WriteLine("------------");
            Console.WriteLine("Zie de class \"BankBediende\"");
            Console.WriteLine("==================================================");
            Console.WriteLine("Oefening 11.1.3: Het hoofdprogramma:");
            Console.WriteLine("------------");
            Klant klant = new Klant("Jan", "Jansen");
            SpaarRekening.Intrest = 3m;
            ZichtRekening zr = new ZichtRekening("BE40645100000163", 100m, DateTime.Today, 0m, klant);
            SpaarRekening sr = new SpaarRekening("BE40747524091936", 1000m, DateTime.Today, klant);
            BankBediende bankbediende = new BankBediende("Piet", "Pieters");
            zr.Afbeelden();
            Console.WriteLine("------------");
            zr.RekeningUittreksel += bankbediende.RekeningUittrekselTonen;
            zr.SaldoInHetRood += bankbediende.RekeningInHetRoodMelden;
            zr.Storten(100m);
            Console.WriteLine("------------");
            zr.Afhalen(150m);
            Console.WriteLine("------------");
            zr.Afhalen(100m);
            Console.WriteLine("==================================================");
            sr.Afbeelden();
            Console.WriteLine("------------");
            sr.RekeningUittreksel += bankbediende.RekeningUittrekselTonen;
            sr.SaldoInHetRood += bankbediende.RekeningInHetRoodMelden;
            sr.Storten(2000m);
            Console.WriteLine("------------");
            sr.Afhalen(1000m);
            Console.WriteLine("------------");
            sr.Afhalen(4000m);
            Console.WriteLine("==================================================");
            */
            /*
            Console.WriteLine("==================================================");
            Console.WriteLine("Oefening 12.1.1: De class Rekening:");
            Console.WriteLine("------------");
            Console.WriteLine("Zie de class \"Rekening\"");
            Console.WriteLine("==================================================");
            Console.WriteLine("Oefening 12.1.2: De class ZichtRekening:");
            Console.WriteLine("------------");
            Console.WriteLine("Zie de class \"ZichtRekening\"");
            Console.WriteLine("==================================================");
            Console.WriteLine("Oefening 12.1.3: De class SpaarRekening:");
            Console.WriteLine("------------");
            Console.WriteLine("Zie de class \"SpaarRekening\"");
            Console.WriteLine("==================================================");
            Console.WriteLine("Oefening 12.1.4: De class Kasbon:");
            Console.WriteLine("------------");
            Console.WriteLine("Zie de class \"Kasbon\"");
            Console.WriteLine("==================================================");
            Console.WriteLine("Oefening 12.1.5: Het hoofdprogramma:");
            // Test niet echt of de exceptions werken, maar ga er maar van uit (volgens de cursus :-/)
            Console.WriteLine("------------");
            try
            {
                SpaarRekening.Intrest = 3m;
                Klant ik = new Klant("Eddy", "Wally");
                ISpaarmiddel[] spaarmiddelen = new ISpaarmiddel[3];
                spaarmiddelen[0] = new ZichtRekening("BE40747524091936", 14.51m, DateTime.Today, -500m, ik);
                spaarmiddelen[1] = new SpaarRekening("BE40645100000163", 1000m, DateTime.Today, ik);
                spaarmiddelen[2] = new Kasbon(DateTime.Today, 1000m, 5, 3.5m, ik);
                foreach (ISpaarmiddel spaarmiddel in spaarmiddelen)
                    spaarmiddel.Afbeelden();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("==================================================");
            */
            /*
            Console.WriteLine("==================================================");
            Console.WriteLine("Oefening 13: Lambda expresssies:");
            Console.WriteLine("==================================================");
            */
            /*
            Console.WriteLine("A: Zonder lambda:");
            Console.WriteLine("Zie: delegate Filter en methods Even/Oneven en Pos/Neg bovenaan");
            Console.WriteLine("En method ToonGetallen onderaan");
            Console.WriteLine("------------");
            Filter evenGetal = Even;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Even getallen: ");
            ToonGetallen(evenGetal);
            Filter onevenGetal = Oneven;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Oneven getallen: ");
            ToonGetallen(onevenGetal);
            Filter positiefGetal = Pos;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Positieve getallen: ");
            ToonGetallen(positiefGetal);
            Filter negatiefGetal = Neg;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Negatieve getallen: ");
            ToonGetallen(negatiefGetal);
            Console.ResetColor();
            */
            /*
            Console.WriteLine("B: Met expression lambda:");
            Console.WriteLine("Zie: Functie KleurGetal (B) bovenaan");
            Console.WriteLine("En method ToonGetallen (B) onderaan");
            Console.WriteLine("------------");
            KleurGetal kleurEvenOneven = getal =>
                getal % 2 == 0 ? ConsoleColor.Green : ConsoleColor.Red;
            KleurGetal kleurNegatiefPositief = getal =>
                getal < 0 ? ConsoleColor.Yellow : ConsoleColor.White;
            ToonGetallen(kleurEvenOneven);
            ToonGetallen(kleurNegatiefPositief);
            */
            /*
            Console.WriteLine("C: Met statement lambda:");
            Console.WriteLine("Zie: Functie KleurGetal (C) bovenaan");
            Console.WriteLine("En method ToonGetallen (C) onderaan");
            Console.WriteLine("------------");
            KleurGetal kleurEvenOneven = 
                getal =>
                {
                    Console.ForegroundColor =
                        getal % 2 == 0 ? ConsoleColor.Green : ConsoleColor.Red;
                    Console.WriteLine(getal);
                };
            KleurGetal kleurNegatiefPositief =
                getal =>
                {
                    Console.ForegroundColor =
                        getal < 0 ? ConsoleColor.Yellow : ConsoleColor.White;
                    Console.WriteLine(getal);
                };
            ToonGetallen(kleurEvenOneven);
            ToonGetallen(kleurNegatiefPositief);
            */
            /*
            Console.WriteLine("D: Met een Func<>:");
            Console.WriteLine("En method ToonGetallen (D) onderaan");
            Console.WriteLine("------------");
            Func<int, ConsoleColor> kleurEvenOneven = getal =>
                getal % 2 == 0 ? ConsoleColor.Green : ConsoleColor.Red;
            Func<int, ConsoleColor> kleurPositiefNegatief = getal =>
                getal < 0 ? ConsoleColor.Yellow : ConsoleColor.White;
            ToonGetallen(kleurEvenOneven);
            ToonGetallen(kleurPositiefNegatief);
            */
            /*
            Console.WriteLine("E: Met Action<>:");
            Console.WriteLine("En method ToonGetallen (E) onderaan");
            Console.WriteLine("------------");
            Action<int> kleurEvenOneven =
                getal =>
                {
                    Console.ForegroundColor =
                        getal % 2 == 0 ? ConsoleColor.Green : ConsoleColor.Red;
                    Console.WriteLine(getal);
                };
            Action<int> kleurPositiefNegatief =
                getal =>
                {
                    Console.ForegroundColor =
                        getal < 0 ? ConsoleColor.Yellow : ConsoleColor.White;
                    Console.WriteLine(getal);
                };
            ToonGetallen(kleurEvenOneven);
            ToonGetallen(kleurPositiefNegatief);
            Console.WriteLine("==================================================");
            */
            /*
            Console.WriteLine("==================================================");
            Console.WriteLine("Oefening 14: LINQ:");
            Console.WriteLine("==================================================");
            Console.WriteLine("Oefening 14.1: De class Plant:");
            Console.WriteLine("------------");
            Console.WriteLine("Zie de class \"Plant\"");
            Console.WriteLine("==================================================");
            Console.WriteLine("Oefening 14.2: Het hoofdprogramma:");
            Console.WriteLine("------------");
            List<Plant> plantenlijst = new List<Plant>();
            plantenlijst.Add(new Plant(1, "Tulp", "rood", 0.50m, "bol"));
            plantenlijst.Add(new Plant(2, "Krokus", "wit", 0.20m, "bol"));
            plantenlijst.Add(new Plant(3, "Narcis", "geel", 0.30m, "bol"));
            plantenlijst.Add(new Plant(4, "Blauw druifje", "blauw", 0.20m, "bol"));
            plantenlijst.Add(new Plant(5, "Azalea", "rood", 3.00m, "heester"));
            plantenlijst.Add(new Plant(6, "Forsythia", "geel", 2.00m, "heester"));
            plantenlijst.Add(new Plant(7, "Magnolia", "wit", 4.00m, "heester"));
            plantenlijst.Add(new Plant(8, "Waterlelie", "wit", 2.00m, "water"));
            plantenlijst.Add(new Plant(9, "Lisdodde", "geel", 3.00m, "water"));
            plantenlijst.Add(new Plant(10, "Kalmoes", "geel", 2.50m, "water"));
            plantenlijst.Add(new Plant(11, "Bieslook", "paars", 1.50m, "kruid"));
            plantenlijst.Add(new Plant(12, "Rozemarijn", "blauw", 1.25m, "kruid"));
            plantenlijst.Add(new Plant(13, "Munt", "wit", 1.10m, "kruid"));
            plantenlijst.Add(new Plant(14, "Dragon", "wit", 1.30m, "kruid"));
            plantenlijst.Add(new Plant(15, "Basilicum", "wit", 1.50m, "kruid"));
            // OF: OPGELET!!! Deze manier werkt enkel als er een default constructor in die class aanwezig is 
            // (of bij gebrek aan een constructor, omdat de compiler er dan zelf één gebruikt op de achtergrond)
            var planten = new List<Plant> {
                new Plant {PlantId=1, Plantennaam="Tulp", Kleur="rood", Prijs=0.5m, Soort="bol"},
                new Plant {PlantId=2, Plantennaam="Krokus", Kleur="wit", Prijs=0.2m, Soort="bol"},
                new Plant {PlantId=3, Plantennaam="Narcis", Kleur="geel", Prijs=0.3m, Soort="bol"},
                new Plant {PlantId=4, Plantennaam="Blauw druifje", Kleur="blauw", Prijs=0.2m, Soort="bol"},
                new Plant {PlantId=5, Plantennaam="Azalea", Kleur="rood", Prijs=3m, Soort="heester"},
                new Plant {PlantId=6, Plantennaam="Forsythia", Kleur="geel", Prijs=2m, Soort="heester"},
                new Plant {PlantId=7, Plantennaam="Magnolia", Kleur="wit", Prijs=4m, Soort="heester"},
                new Plant {PlantId=8, Plantennaam="Waterlelie", Kleur="wit", Prijs=2m,Soort="water"},
                new Plant {PlantId=9, Plantennaam="Lisdodde", Kleur="geel", Prijs=3m,Soort="water"},
                new Plant {PlantId=10,Plantennaam="Kalmoes", Kleur="geel", Prijs=2.5m, Soort="water"},
                new Plant {PlantId=11,Plantennaam="Bieslook", Kleur="paars", Prijs=1.5m,Soort="kruid"},
                new Plant {PlantId=12,Plantennaam="Rozemarijn", Kleur="blauw", Prijs=1.25m, Soort="kruid"},
                new Plant {PlantId=13,Plantennaam="Munt", Kleur="wit", Prijs=1.1m, Soort="kruid"},
                new Plant {PlantId=14,Plantennaam="Dragon", Kleur="wit", Prijs=1.3m, Soort="kruid"},
                new Plant {PlantId=15,Plantennaam="Basilicum", Kleur="wit", Prijs=1.5m, Soort="kruid"}};
            // Toon plantennaam, kleur en prijs van de witte planten, gesorteerd op prijs:
            Console.WriteLine("Toon plantennaam, kleur en prijs van de witte planten, gesorteerd op prijs:");
            var lijstA = from plant in plantenlijst
                         where plant.Kleur == "wit"
                         orderby plant.Prijs
                         select plant;
            foreach (Plant plant in lijstA)
                Console.WriteLine(plant.Plantennaam + ' ' + plant.Kleur + ' ' + plant.Prijs);
            Console.WriteLine("------------");
            Console.WriteLine("OF: Oplossing uit de cursus:");
            var wittePlanten = from plant in planten
                               where plant.Kleur == "wit"
                               orderby plant.Prijs
                               select new { plant.Plantennaam, plant.Kleur, plant.Prijs }; // Enkel wat 
            // nodig is wordt weerhouden en in een anoniem object gestopt. Dit is best practise.
            foreach (var plant in wittePlanten)
                Console.WriteLine("{0} ({1}): {2} euro", plant.Plantennaam, plant.Kleur, plant.Prijs);
            Console.WriteLine("------------");
            // Toon het aantal witte planten:
            Console.WriteLine("Toon het aantal witte planten:");
            var lijstB = from plant in plantenlijst
                         where plant.Kleur == "wit"
                         select plant;
            Console.WriteLine("Het aantal witte planten: {0}", lijstB.Count());
            Console.WriteLine("------------");
            Console.WriteLine("OF: Oplossing uit de cursus:"); // Idem reden
            var aantalWittePlanten = (from plant in planten
                                      where plant.Kleur == "wit"
                                      select plant).Count();
            Console.WriteLine($"Aantal witte planten: {aantalWittePlanten}");
            Console.WriteLine("------------");
            Console.WriteLine("OF: Oplossing uit de cursus:"); // Eleganter en korter
            Console.WriteLine("Aantal witte planten: {0}", 
                planten.Where(plant => plant.Kleur == "wit").Count());
            Console.WriteLine("------------");
            // Bereken de gemiddelde prijs van de heesters en toon deze op het scherm:
            Console.WriteLine("Bereken de gemiddelde prijs van de heesters en toon deze op het scherm:");
            var lijstC = from plant in plantenlijst
                         where plant.Soort == "heester"
                         select plant;
            var gemiddeldePrijsHeesters = lijstC.Average(plant => plant.Prijs);
            Console.WriteLine("De gemiddelde prijs van heesters is: {0}", gemiddeldePrijsHeesters);
            Console.WriteLine("------------");
            Console.WriteLine("OF: Oplossing uit de cursus:"); // Eleganter en korter
            var gemiddeldePrijsHeesters2 = (from plant in planten
                                            where plant.Soort == "heester"
                                            select plant).Average(plant => plant.Prijs);
            Console.WriteLine($"Gemiddelde prijs van de heesters: " + $"{gemiddeldePrijsHeesters2} euro");
            Console.WriteLine("------------");
            Console.WriteLine("OF: Oplossing uit de cursus:"); // Eleganter en korter
            var gemiddeldePrijsHeesters3 = (from plant in planten
                                           where plant.Soort == "heester"
                                           select plant.Prijs).Average();
            Console.WriteLine("Gemiddelde prijs van de heesters: {0} euro", gemiddeldePrijsHeesters3);
            Console.WriteLine("------------");
            // Toon de gemiddelde prijs en de maximumprijs van de kruiden:
            Console.WriteLine("Toon de gemiddelde prijs en de maximumprijs van de kruiden:");
            var lijstD = from plant in plantenlijst
                         where plant.Soort == "kruid"
                         select plant;
            var gemiddeldePrijsKruiden = lijstD.Average(plant => plant.Prijs);
            var maximumPrijsKruiden = lijstD.Max(plant => plant.Prijs);
            Console.WriteLine("De gemiddelde prijs van kruiden is: {0}", gemiddeldePrijsKruiden);
            Console.WriteLine("De maximumprijs van kruiden is: {0}", maximumPrijsKruiden);
            Console.WriteLine("------------");
            Console.WriteLine("OF: Oplossing uit de cursus:"); // Eleganter en korter
            var prijzenKruiden = from plant in planten
                                 where plant.Soort == "kruid"
                                 select plant.Prijs;
            Console.WriteLine("Gemiddelde prijs kruiden: {0} euro" + Environment.NewLine +
                "Maximumprijs kruiden: {1} euro", prijzenKruiden.Average(), prijzenKruiden.Max());
            Console.WriteLine("------------");
            // Toon de plantennamen die met de letter “B” beginnen:
            Console.WriteLine("Toon de plantennamen die met de letter “B” beginnen:");
            var lijstE = from plant in plantenlijst
                         where plant.Plantennaam.StartsWith("B")
                         select plant;
            foreach (var plant in lijstE)
                Console.WriteLine(plant.Plantennaam);
            Console.WriteLine("------------");
            Console.WriteLine("OF: Oplossing uit de cursus:"); // ToUpper, just in case:
            var plantenB = from plant in planten
                           where plant.Plantennaam.ToUpper().StartsWith("B")
                           select plant;
            foreach (var plant in plantenB)
                Console.WriteLine(plant.Plantennaam);
            Console.WriteLine("------------");
            // Toon een lijst van de verschillende plantenkleuren op het scherm: (idem cursus :-))
            Console.WriteLine("Toon een lijst van de verschillende plantenkleuren op het scherm:");
            var lijstF = (from plant in plantenlijst
                          select plant.Kleur).Distinct();
            Console.WriteLine("De verschillende plantenkleuren zijn: ");
            foreach (var kleur in lijstF)
                Console.WriteLine(kleur);
            Console.WriteLine("------------");
            // Toon de plantennamen per kleur op het scherm: (idem cursus :-))
            Console.WriteLine("Toon de plantennamen per kleur op het scherm:");
            var lijstG = from plant in plantenlijst
                         group plant by plant.Kleur
                         into mijnGroepA
                         select mijnGroepA;
            foreach (var kleur in lijstG)
            {
                Console.WriteLine(kleur.Key);
                foreach (var plant in kleur)
                    Console.WriteLine("\t" + plant.Plantennaam);
            }
            Console.WriteLine("------------");
            // Toon per soort de maximum plantenprijs van die soort:
            Console.WriteLine("Toon per soort de maximum plantenprijs van die soort:");
            var lijstH = from plant in plantenlijst
                         group plant by plant.Soort
                         into mijnGroepB
                         select new
                         {
                             Soort = mijnGroepB.Key,
                             MaxPrijs = mijnGroepB.Max(plant => plant.Prijs)
                         };
            foreach (var soort in lijstH)
            {
                Console.WriteLine($"{soort.Soort}: " + $"max. prijs = {soort.MaxPrijs} euro");
            }
            Console.WriteLine("------------");
            // Toon de soorten alfabetisch met per soort:
            // o het aantal planten van deze soort
            // o de namen van de planten van deze soort
            Console.WriteLine("Toon de soorten alfabetisch met per soort het aantal planten van deze soort");
            Console.WriteLine("en de namen van de planten van deze soort:");
            var lijstI = from plant in plantenlijst
                         group plant by plant.Soort
                         into soortgroep
                         orderby soortgroep.Key
                         select new
                         {
                             Soort = soortgroep.Key,
                             AantalPlanten = soortgroep.Count(),
                             Planten = soortgroep
                         };
            foreach (var groep in lijstI)
            {
                Console.WriteLine($"Soort: {groep.Soort}: " + $"{groep.AantalPlanten} planten");
                foreach (var plant in groep.Planten)
                    Console.WriteLine($"\t{plant.Plantennaam}"); 
            }
            Console.WriteLine("------------");
            Console.WriteLine("OF: Oplossing uit de cursus:"); // Eleganter en korter
            var soortenMetPlanten2 = planten.OrderBy(plant => plant.Soort).GroupBy(plant => plant.Soort);
            foreach (var groep in soortenMetPlanten2)
            {
                Console.WriteLine("Soort {0}: {1} planten", groep.Key, groep.Count());
                foreach (var plant in groep)
                    Console.WriteLine("\t{0}", plant.Plantennaam);
            }
            Console.WriteLine("------------");
            // Toon de namen van de planten gegroepeerd per soort en binnen de soort per kleur:
            Console.WriteLine("Toon de namen van de planten gegroepeerd per soort en binnen de soort per kleur:");
            var lijstJ = from plant in plantenlijst
                         group plant by plant.Soort
                         into soortgroep
                         select new
                         {
                             Soort = soortgroep.Key,
                             Groepkleur = from plant in soortgroep
                                          group plant by plant.Kleur
                                          into kleurgroep
                                          select new
                                          {
                                              Kleur = kleurgroep.Key,
                                              Planten = kleurgroep
                                          }
                         };
            foreach (var soort in lijstJ)
            {
                Console.WriteLine($"Soort: {soort.Soort}:");
                foreach (var kleur in soort.Groepkleur)
                {
                    Console.WriteLine($"\tKleur: {kleur.Kleur}:");
                    foreach (var plant in kleur.Planten)
                        Console.WriteLine("\t\t" + plant.Plantennaam);
                }
            }
            Console.WriteLine("==================================================");
            */

        }

        /*
        private static string VervangLetters(string nummer)
        {
            char teken;
            string nr = string.Empty;
            for (int teller = 0; teller < nummer.Length; teller++)
            {
                teken = nummer[teller];
                if (teken >= 'A' && teken <= 'Z')
                {
                    nr += ALFABET.IndexOf(teken) + 10;
                }
                else
                {
                    nr += teken;
                }
            }
            return nr;
        }
        */
        /*
        private static void ToonGetallen(Filter filter) //Voor oefening 13: Method (A)
        {
            var getallen = new[] { 5, -8, -4, 6, 9, -1, 3 };
            foreach (var getal in getallen)
                if (filter(getal))
                    Console.WriteLine(getal);
        }
        */
        /*
        private static void ToonGetallen(KleurGetal kleurGetal) //Voor oefening 13: Method (B)
        {
            var getallen = new[] { 5, -8, -4, 6, 9, -1, 3 };
            foreach (var getal in getallen)
            {
                Console.ForegroundColor = kleurGetal(getal);
                Console.WriteLine(getal);
            }
            Console.WriteLine();
        }
        */
        /*
        private static void ToonGetallen(KleurGetal kleurGetal) //Voor oefening 13: Method (C)
        {
            var getallen = new[] { 5, -8, -4, 6, 9, -1, 3 };
            foreach (var getal in getallen)
            {
                kleurGetal(getal);
            }
            Console.WriteLine();
        }
        */
        /*
        private static void ToonGetallen(Func<int, ConsoleColor> kleurGetal) //Voor oefening 13: Method (D)
        {
            var getallen = new[] { 5, -8, -4, 6, 9, -1, 3 };
            foreach (var getal in getallen)
            {
                Console.ForegroundColor = kleurGetal(getal);
                Console.WriteLine(getal);
            }
            Console.WriteLine();
        }
        */
        /*
        private static void ToonGetallen(Action<int> kleurGetal) //Voor oefening 13: Method (E)
        {
            var getallen = new[] { 5, -8, -4, 6, 9, -1, 3 };
            foreach (var getal in getallen)
                kleurGetal(getal);
            Console.WriteLine();
        }
        */
    }
}
