﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPM_Erzeugen
{
    class Consoleview
    {

        private QuelleErstellen quelleErstellen;

        public Consoleview(QuelleErstellen quelleErstellen)
        {
            this.quelleErstellen = quelleErstellen;
        }

        public void HoleBenutzereingabe()
        {
            quelleErstellen.DBnummer = BenutzerEingabe("DB Nummer eintragen: ");
            quelleErstellen.Stationbezeichnung = BenutzerEingabe("Stationsbezeichnung eintragen: ");
            quelleErstellen.Merkmalsblock = BenutzerEingabe("Merkmalsblock siehe UDT eintragen: ");
            quelleErstellen.MerkmalKennung = BenutzerEingabe("Merkmalkennung eintragen: ");
            quelleErstellen.MerkmalBeschreibung = BenutzerEingabe("Merkmalbeschreibung eintragen: ");
            quelleErstellen.MerkmalTyp = BenutzerEingabe("Merkmal Typ (z.B.: 10, 20, F) eintragen: ");
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