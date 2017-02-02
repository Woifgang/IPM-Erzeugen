using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPM_Erzeugen
{
    class Consoleview
    {

        private AWLQuellcode awlQuellcode;

        public Consoleview(AWLQuellcode awlQuellcode)
        {
            this.awlQuellcode = awlQuellcode;
        }

        public void HoleBenutzereingabe()
        {
            awlQuellcode.DBnummer = BenutzerEingabe("DB Nummer eintragen: ");
            awlQuellcode.Stationbezeichnung = BenutzerEingabe("Stationsbezeichnung eintragen: ");
            awlQuellcode.Merkmalsblock = BenutzerEingabe("Merkmalsblock siehe UDT eintragen: ");
            awlQuellcode.MerkmalKennung = BenutzerEingabe("Merkmalkennung eintragen: ");
            awlQuellcode.MerkmalBeschreibung = BenutzerEingabe("Merkmalbeschreibung eintragen: ");
            awlQuellcode.MerkmalTyp = BenutzerEingabe("Merkmal Typ (z.B.: 10, 20, F) eintragen: ");
        }

        public string BeendeProgramm()
        {
            Console.Write("Zum Beenden bitte Return drücken");
            return Console.ReadLine();
        }

        private string BenutzerEingabe(string eingabe)
        {
            Console.Write(eingabe);
            return Console.ReadLine();
        }

       

    }
}
