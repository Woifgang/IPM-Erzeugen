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
            ParameterEnde = true;
            ParameterZaehlen = 0;
        }

        public string AnzahlMerkmale { get; set; }
        public string DBnummer { get; set; }
        public string Stationbezeichnung { get; set; }
        public string MerkmalsBlock { get; set; }
        public string MerkmalKennung { get; set; }
        public string MerkmalBeschreibung { get; set; }
        public string MerkmalTyp { get; set; }
        public string MerkmalEinheit { get; set; }
        public string Zeitstempel { get; set; }
        
        public string ParameterVorhanden { get; set; }
       // public string ParameterAnzahl { get; set; }

        private string parameterkennung;

        public string ParameterKennung
        {
            get { return parameterkennung; }
            set { parameterkennung = value; }
        }


        public bool  BenutzerWillBeenden { get; private set; }
        public bool ParameterEnde { get;  set; }

        public int ParameterZaehlen { get; set; }


        public void HoleBenutzereingabe()
        {
            Zeitstempel = AktuelleUhrzeit();
            
            DBnummer = BenutzerEingabe("DB Nummer eintragen: ");
            Stationbezeichnung = BenutzerEingabe("Stationsbezeichnung eintragen: ");
            MerkmalsBlock = BenutzerEingabe("Merkmalsblock siehe UDT eintragen: ");
            MerkmalKennung = BenutzerEingabe("Merkmalkennung eintragen: ");
            MerkmalBeschreibung = BenutzerEingabe("Merkmalbeschreibung eintragen: ");
            Console.WriteLine("Merkmaltyp eintragen.");
            Console.WriteLine("Für Text -> 10, 20, 50, 100 oder 255");
            MerkmalTyp = BenutzerEingabe("Für Merkmal Float -> F :   ");

            if (MerkmalTyp == "F")
            {
                MerkmalEinheit = BenutzerEingabe("Merkmal Einheit angeben: ");
                ParameterVorhanden = BenutzerEingabe("Sind Parameter vorhanden? J / N : ");
                ParameterVorhandenJaNein();
            }
           
        }

        public void NachFolgendeBenutzerEingabe()
        {
            string eingabe = BenutzerEingabe("Weiteren Merkmalsblock siehe UDT eintragen (FERTIG zum Beenden): ");

            if (eingabe == "FERTIG")
            {
                BenutzerWillBeenden = true;
            }
            else
            {
                MerkmalsBlock = eingabe;
                MerkmalKennung = BenutzerEingabe("Merkmalkennung eintragen: ");
                MerkmalBeschreibung = BenutzerEingabe("Merkmalbeschreibung eintragen: ");
                Console.WriteLine("Merkmaltyp eintragen.");
                Console.WriteLine("Für Text -> 10, 20, 50, 100 oder 255");
                MerkmalTyp = BenutzerEingabe("Für Merkmal Float -> F :   ");

                if (MerkmalTyp == "F")
                {
                    MerkmalEinheit = BenutzerEingabe("Merkmal Einheit angeben: ");
                    ParameterVorhanden = BenutzerEingabe("Sind Parameter vorhanden? J / N : ");
                    ParameterVorhandenJaNein();
                }
            }
        }

        private void ParameterVorhandenJaNein()
        {
            if (ParameterVorhanden == "J")
            {
                ParameterEnde = false;
            }
            else
            {
                ParameterEnde = true;
            }
        }

        public void ParameterEingabe()
        {
            if (ParameterVorhanden == "J")
            {
                string parameterEingabe = BenutzerEingabe("Parameterkennung eintragen (FERTIG zum Beenden): ");
                if (parameterEingabe == "FERTIG")
                {
                    ParameterEnde = true;
                    Console.Write("Parameter abgeschlossen...");
                }
                else
                {
                    parameterkennung = parameterEingabe;
                }
            }
        }

        public string BeendeProgramm()
        {
            Console.Write("Zum Beenden bitte Return drücken");
            return Console.ReadLine();
        }

        public void AWLQuelleGeneriert(string zeitstempel)
        {
            Console.WriteLine("AWL-Quelle mit dem Zeitspempel \"" + zeitstempel + "\" erfolgreich erstellt. ");
            Console.WriteLine("Die AWL-Quelle wurde unter  C:\"Users\"Public\"Merkmal_"+zeitstempel+".awl gespeichert. ");
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
