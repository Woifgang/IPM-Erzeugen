using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPM_Erzeugen
{
    class Consoleview
    {

        public Consoleview()
        {
            BenutzerWillBeenden = false;
        }

        public string AnzahlMerkmale { get; set; }
        public string DBnummer { get; set; }
        public string Stationbezeichnung { get; set; }
        public string Merkmalsblock { get; set; }
        public string MerkmalKennung { get; set; }
        public string MerkmalBeschreibung { get; set; }
        public string MerkmalTyp { get; set; }
        public string MerkmalEinheit { get; set; }
        public string Zeitstempel { get; set; }
        public string ParameterKennung { get; set; }


        public bool  BenutzerWillBeenden { get; private set; }


        public void HoleBenutzereingabe()
        {
            Zeitstempel = AktuelleUhrzeit();
            MerkmalKennung = BenutzerEingabe("Merkmalkennung eintragen: ");
            DBnummer = BenutzerEingabe("DB Nummer eintragen: ");
            Stationbezeichnung = BenutzerEingabe("Stationsbezeichnung eintragen: ");
            Merkmalsblock = BenutzerEingabe("Merkmalsblock siehe UDT eintragen: ");
            Console.WriteLine("Merkmaltyp eintragen.");
            Console.WriteLine("Für Text -> 10, 20, 50, 100 oder 255");
            MerkmalTyp = BenutzerEingabe("Für Merkmal Float -> F :   ");

            if (MerkmalTyp == "F")
                {
                    MerkmalEinheit = BenutzerEingabe("Merkmal Einheit angeben: ");
                }

            MerkmalBeschreibung = BenutzerEingabe("Merkmalbeschreibung eintragen: ");    
        }

        public void NachFolgendeBenutzerEingabe()
        {
            string eingabe = BenutzerEingabe("Weiteres Merkmal eintragen (FERTIG zum Beenden) :   ");

            if (eingabe == "FERTIG")
            {
                BenutzerWillBeenden = true;
            }
            else
            {

                MerkmalKennung = eingabe;
                Merkmalsblock = BenutzerEingabe("Merkmalsblock siehe UDT eintragen: ");
                Console.WriteLine("Merkmaltyp eintragen.");
                Console.WriteLine("Für Text -> 10, 20, 50, 100 oder 255");
                MerkmalTyp = BenutzerEingabe("Für Merkmal Float -> F :   ");

                if (MerkmalTyp == "F")
                {
                    MerkmalEinheit = BenutzerEingabe("Merkmal Einheit angeben: ");
                }

                MerkmalBeschreibung = BenutzerEingabe("Merkmalbeschreibung eintragen: ");
            }
            
        }

        public string BeendeProgramm()
        {
            Console.Write("Zum Beenden bitte Return drücken");
            return Console.ReadLine();
        }

        public void AWLQuelleGeneriert(string merkmaltyp)
        {
            Console.WriteLine("AWL-Quelle des Merkmalstyp \"" + merkmaltyp + "\" erfolgreich erstellt. ");
        }

        private string BenutzerEingabe(string eingabe)
        {
            Console.Write(eingabe);
            return Console.ReadLine();
        }

       private string AktuelleUhrzeit()
        {
            string zeitstempel = DateTime.Now.ToString("yyyyMMdd_HHmmss");
            return zeitstempel;
        }

    }
}
