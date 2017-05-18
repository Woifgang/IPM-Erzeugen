using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPM_Erzeugen.MerkmalTyp
{
    class MerkmalFloat
    {
        private AWLQuellcode awlQuellcode;
        private Consoleview view;


        public MerkmalFloat(AWLQuellcode awlQuellcode, Consoleview view)
        {
            this.awlQuellcode = awlQuellcode;
            this.view = view;
        }

        public string[] MerkmalFLOAT { get; set; }

        public void Float()
        {
            //awlQuellcode.AWLStruktur();

            string[] ladeStandartwert = awlQuellcode.StandartwerteLaden();
            string[] ladeKennung = awlQuellcode.MerkmalDetailsLaden(view.MerkmalKennung);
            string[] ladeEinheit = awlQuellcode.MerkmalDetailsLaden(view.MerkmalEinheit);
            //string[] ladeAnzahlParameter = awlQuellcode.AnzahlParameter(view.ParameterZaehlen);

            string[] transferiereKennung = awlQuellcode.AdresseDBZusammenbauen("kennung");
            string[] transferiereEinheit = awlQuellcode.AdresseDBZusammenbauen("einheit");
            string[] transferiereKurvenwertLaenge = awlQuellcode.AdresseDBZusammenbauen("kurvenwertLaenge");
            string[] transferiereNumWert = awlQuellcode.AdresseDBZusammenbauen("numWert");
            string[] transferiereStatus = awlQuellcode.AdresseDBZusammenbauen("status");
            string[] transferiereStufe = awlQuellcode.AdresseDBZusammenbauen("stufe");
            string[] transferiereStufentyp = awlQuellcode.AdresseDBZusammenbauen("stufentyp");
            string[] transferiereAnzahlParameter = awlQuellcode.AdresseDBZusammenbauen("anzahlParameter");


            string[] merkmalFloat = {
                
                // Netzwerk 1 Merkmal nur Netzwerktitel
                awlQuellcode.Network,
                //awlQuellcode.NetworkTitle,
                awlQuellcode.NetzwerkTitel("### " + view.Stationbezeichnung + ": Merkmal XXX / FLOAT " + view.MerkmalKennung + " ###"),
                awlQuellcode.NetzwerkKommentar(view.MerkmalBeschreibung),

                // Netzwerk 2 Merkmalskennung
                awlQuellcode.Network,
                awlQuellcode.NetzwerkTitel(view.Stationbezeichnung+ ": Merkmal XXX - Merkmalskennung"),
                ladeKennung[0], transferiereKennung[1],
                ladeKennung[1], transferiereKennung[2],
                ladeKennung[2], transferiereKennung[3],
                ladeKennung[3], transferiereKennung[4],
                ladeKennung[4], transferiereKennung[5],
                ladeKennung[5], transferiereKennung[6],
                ladeKennung[6], transferiereKennung[7],
                ladeKennung[7], transferiereKennung[8],
                ladeKennung[8], transferiereKennung[9],
                ladeKennung[9], transferiereKennung[10],
                ladeKennung[10], transferiereKennung[11],
                ladeKennung[11], transferiereKennung[12],
                ladeKennung[12], transferiereKennung[13],
                ladeKennung[13], transferiereKennung[14],
                ladeKennung[14], transferiereKennung[15],
                ladeKennung[15], transferiereKennung[16],
                ladeKennung[16], transferiereKennung[17],
                ladeKennung[17], transferiereKennung[18],
                
                // Netzwerk 3 Einheit
                awlQuellcode.Network,
                awlQuellcode.NetzwerkTitel(view.Stationbezeichnung+ ": Merkmal XXX - Merkmal - Einheit"),
                ladeEinheit[0], transferiereEinheit[1],
                ladeEinheit[1], transferiereEinheit[2],
                ladeEinheit[2], transferiereEinheit[3],
                ladeEinheit[3], transferiereEinheit[4],
                ladeEinheit[4], transferiereEinheit[5],
                ladeEinheit[5], transferiereEinheit[6],
                ladeEinheit[6], transferiereEinheit[7],
                ladeEinheit[7], transferiereEinheit[8],
                ladeEinheit[8], transferiereEinheit[9],
                ladeEinheit[9], transferiereEinheit[10],

                // Netzwerk 4 Kurfenwert Länge
                awlQuellcode.Network,
                awlQuellcode.NetzwerkTitel(view.Stationbezeichnung+ ": Merkmal XXX - Kurvenwert - Laenge"),
                ladeStandartwert[0],transferiereKurvenwertLaenge[1],
                ladeStandartwert[1],transferiereKurvenwertLaenge[2],

                 // Netzwerk 5 numWert
                awlQuellcode.Network,
                awlQuellcode.NetzwerkTitel(view.Stationbezeichnung+ ": Merkmal XXX - Wert"),
                ladeStandartwert[1], transferiereNumWert[1],
                ladeStandartwert[1], transferiereNumWert[2],
                ladeStandartwert[1], transferiereNumWert[3],
                ladeStandartwert[1], transferiereNumWert[4],
                ladeStandartwert[1], transferiereNumWert[5],
                ladeStandartwert[1], transferiereNumWert[6],
                ladeStandartwert[1], transferiereNumWert[7],
                ladeStandartwert[1], transferiereNumWert[8],


                 // Netzwerk 6 Status iO / niO
                awlQuellcode.Network,
                awlQuellcode.NetzwerkTitel(view.Stationbezeichnung+ ": Merkmal XXX - Status ('0 '= iO. '1 '= niO.)"),
                awlQuellcode.NetzwerkKommentar("Status '0 '= iO. '1 '= niO.  '4 '=NG  '5 '=WIO  '6 '=WNIO  '7 '=ABGW  '9 '=ZIO  '10'=RIO"),
                ladeStandartwert[1], transferiereStatus[1],
                ladeStandartwert[1], transferiereStatus[2],

                 // Netzwerk 7 Stufe / Stufentyp
                awlQuellcode.Network,
                awlQuellcode.NetzwerkTitel(view.Stationbezeichnung+ ": Merkmal XXX - Stufe / Stufentyp"),
                ladeStandartwert[0], transferiereStufe[1],
                ladeStandartwert[1], transferiereStufe[2],
                ladeStandartwert[0], transferiereStufentyp[1],
                ladeStandartwert[1], transferiereStufentyp[2],
                ladeStandartwert[1], transferiereStufentyp[3],
                ladeStandartwert[1], transferiereStufentyp[4],

                 // Netzwerk 8 Parameter
                awlQuellcode.Network,
                awlQuellcode.NetzwerkTitel(view.Stationbezeichnung+ ": Merkmal XXX - Parameter"),
                awlQuellcode.NetzwerkKommentar("Parameter Anzahl muss von Hand eingegeben werden!!!"),
                //ladeAnzahlParameter[0], transferiereAnzahlParameter[1],
                //ladeAnzahlParameter[1], transferiereAnzahlParameter[2],
                ladeStandartwert[0], transferiereAnzahlParameter[1],
                ladeStandartwert[1], transferiereAnzahlParameter[2],

                 // Netzwerk 9 Leernetzwerk
                awlQuellcode.Network,
                awlQuellcode.NetzwerkTitel("Leernetzwerk zur Orientierung"),
                
            };
            MerkmalFLOAT = merkmalFloat;
        }
    }
}
