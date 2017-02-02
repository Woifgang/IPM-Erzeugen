using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPM_Erzeugen.MerkmalTyp
{
    class MerkmalText10
    {
        private AWLQuellcode awlQuellcode;
        private Consoleview view;
 

        public MerkmalText10(AWLQuellcode awlQuellcode, Consoleview view)
        {
            this.awlQuellcode = awlQuellcode;
            this.view = view;
        }

        public void Text10()
        {
            awlQuellcode.AWLStruktur();

            string[] ladeKennung = awlQuellcode.MerkmalKennungLaden(view.MerkmalKennung);
            string[] transferiereZiel = awlQuellcode.AdresseDBZusammenbauen("kennung");

            string[] merkmalText10 = {
                // Header
                awlQuellcode.FunktionStart,
                awlQuellcode.Titel,
                awlQuellcode.Version,
                awlQuellcode.Begin,
                // Netzwerk 1 Merkmal nur Netzwerktitel
                awlQuellcode.Network,
                //awlQuellcode.NetworkTitle,
                awlQuellcode.NetzwerkTitel("### " + view.Stationbezeichnung + ": Merkmal XXX / Text10 " + view.MerkmalKennung + " ###"),
                awlQuellcode.NetzwerkKommentar("hier kann ein Kommentar stehen"),

                // Netzwerk 2 Merkmalskennung
                awlQuellcode.Network,
                awlQuellcode.NetzwerkTitel(view.Stationbezeichnung+ ": Merkmal XXX - Merkmalskennung"),
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
                awlQuellcode.NetzwerkTitel(view.Stationbezeichnung+ ": Merkmal XXX - Merkmal - Einheit"),

                // Netzwerk 4 Kurfenwert Länge
                awlQuellcode.Network,
                awlQuellcode.NetzwerkTitel(view.Stationbezeichnung+ ": Merkmal XXX - Kurvenwert - Länge"),

                 // Netzwerk 5 Wert
                awlQuellcode.Network,
                awlQuellcode.NetzwerkTitel(view.Stationbezeichnung+ ": Merkmal XXX - Wert"),

                 // Netzwerk 6 Status iO / niO
                awlQuellcode.Network,
                awlQuellcode.NetzwerkTitel(view.Stationbezeichnung+ ": Merkmal XXX - Status ('0 '= iO. '1 '= niO.)"),

                 // Netzwerk 7 Stufe / Stufentyp
                awlQuellcode.Network,
                awlQuellcode.NetzwerkTitel(view.Stationbezeichnung+ ": Merkmal XXX - Stufe / Stufentyp"),

                 // Netzwerk 8 Parameter
                awlQuellcode.Network,
                awlQuellcode.NetzwerkTitel(view.Stationbezeichnung+ ": Merkmal XXX - Parameter"),

                 // Netzwerk 9 Leernetzwerk
                awlQuellcode.Network,
                awlQuellcode.NetzwerkTitel("Leernetzwerk zur Orientierung"),

                // Ende
                awlQuellcode.EndFunction
            };

            System.IO.File.WriteAllLines(@"C:\Users\Public\MerkmalText10.awl", merkmalText10);
        }

    }
}
