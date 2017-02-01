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

        }

        public void HoleBenutzereingabe()
        {
            string merkmalKennung = BenutzerEingabe("Merkmalkennung eintragen: ");
            string merkmalBeschreibung = BenutzerEingabe("Merkmalbeschreibung eintragen: ");
            string merkmalTyp = BenutzerEingabe("Merkmal Typ (z.B.: 10, 20, F) eintragen: ");
        }

        private string BenutzerEingabe(string eingabe)
        {
            Console.Write(eingabe);
            return Console.ReadLine();
        }


    }
}
