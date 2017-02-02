using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPM_Erzeugen
{
    class QuelleErstellen
    {
        private AWLQuellcode awlQuellcode;

        public QuelleErstellen(AWLQuellcode awlQuellcode)
        {
            this.awlQuellcode = awlQuellcode;
        }

        public string DBnummer{ get; set; }
        public string Stationbezeichnung { get; set; }
        public string Merkmalsblock { get; set; }
        public string MerkmalKennung { get; set; }
        public string MerkmalBeschreibung { get; set; }
        public string MerkmalTyp { get; set; }

        public void ErzeugeAWLQuellcode()
        {
            awlQuellcode.AWLStruktur();

            switch (MerkmalTyp)
            {
                case "10":
                    Text10();
                    break;   
                
                default:
                    Console.WriteLine("Merkmal Typ ist ungültig");
                    break;
            }

        }

        private void Text10()
        {
            string[] ladeKennung = MerkmalKennungLaden(MerkmalKennung);
            string[] transferiereZiel = AdresseDBZusammenbauen("kennung");

            string[] merkmalText10 = {
                // Header
                awlQuellcode.FunktionStart,
                awlQuellcode.Titel,
                awlQuellcode.Version,
                awlQuellcode.Begin,
                // Netzwerk 1 Merkmal nur Netzwerktitel
                awlQuellcode.Network,
                //awlQuellcode.NetworkTitle,
                awlQuellcode.NetzwerkTitel("### " + Stationbezeichnung + ": Merkmal XXX / Text10 " + MerkmalKennung + " ###"),
                awlQuellcode.NetzwerkKommentar("hier kann ein Kommentar stehen"),

                // Netzwerk 2 Merkmalskennung
                awlQuellcode.Network,
                awlQuellcode.NetzwerkTitel(Stationbezeichnung+ ": Merkmal XXX - Merkmalskennung"),
                ladeKennung[0], transferiereZiel[1],
                ladeKennung[1], transferiereZiel[2],
                ladeKennung[2],transferiereZiel[3],
                ladeKennung[3],transferiereZiel[4],
                ladeKennung[4],transferiereZiel[5],
                ladeKennung[5],transferiereZiel[6],
                ladeKennung[6],transferiereZiel[7],
                ladeKennung[7],transferiereZiel[8],
                ladeKennung[8],transferiereZiel[9],
                ladeKennung[9],transferiereZiel[10],
                ladeKennung[10], transferiereZiel[11],
                ladeKennung[11],transferiereZiel[12],
                ladeKennung[12],transferiereZiel[13],
                ladeKennung[13], transferiereZiel[14],
                ladeKennung[14], transferiereZiel[15],
                ladeKennung[15], transferiereZiel[16],
                ladeKennung[16], transferiereZiel[17],
                ladeKennung[17], transferiereZiel[18],
                
                // Netzwerk 3 Einheit
                awlQuellcode.Network,
                awlQuellcode.NetzwerkTitel(Stationbezeichnung+ ": Merkmal XXX - Merkmal - Einheit"),

                // Netzwerk 4 Kurfenwert Länge
                awlQuellcode.Network,
                awlQuellcode.NetzwerkTitel(Stationbezeichnung+ ": Merkmal XXX - Kurvenwert - Länge"),

                 // Netzwerk 5 Wert
                awlQuellcode.Network,
                awlQuellcode.NetzwerkTitel(Stationbezeichnung+ ": Merkmal XXX - Wert"),

                 // Netzwerk 6 Status iO / niO
                awlQuellcode.Network,
                awlQuellcode.NetzwerkTitel(Stationbezeichnung+ ": Merkmal XXX - Status ('0 '= iO. '1 '= niO.)"),

                 // Netzwerk 7 Stufe / Stufentyp
                awlQuellcode.Network,
                awlQuellcode.NetzwerkTitel(Stationbezeichnung+ ": Merkmal XXX - Stufe / Stufentyp"),

                 // Netzwerk 8 Parameter
                awlQuellcode.Network,
                awlQuellcode.NetzwerkTitel(Stationbezeichnung+ ": Merkmal XXX - Parameter"),

                 // Netzwerk 9 Leernetzwerk
                awlQuellcode.Network,
                awlQuellcode.NetzwerkTitel("Leernetzwerk zur Orientierung"),

                // Ende
                awlQuellcode.EndFunction
            };

            System.IO.File.WriteAllLines(@"C:\Users\Public\WriteLines.awl", merkmalText10);
        }
    
        private string[] MerkmalKennungLaden(string wert)
        {
            string kennung = wert;
            string[] zerlegen = new string[18];

            for (int i = 0; i < 18; i++)
            {
                if (i < kennung.Length)
                {
                    zerlegen[i] = "L '" + kennung[i].ToString() + "';";
                }
                else
                {
                    zerlegen[i] = "L ' ';" ;
                }
                
            }
            return zerlegen;
        }

        private string[] AdresseDBZusammenbauen(string wert)
        {
            string[] tmp = new string[19];
            //string wert = ".kennung[";
            
            
            for (int i = 1; i < 19; i++)
            {
                //"T \"DB_IPM_SEND_BA03\".daten.ST350_1.M1_Daten.kennung[1];";
                //         DBnummer + Stationbezeichnung + Merkmalsblock +
                string kennung = Convert.ToString(i);

                tmp[i] = "T DB"+DBnummer +".daten." + Stationbezeichnung + "." + Merkmalsblock + "." + wert + "[" + kennung + "];";
            }
            return tmp;
        }

    }
}
