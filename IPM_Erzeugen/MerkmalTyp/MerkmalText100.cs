using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPM_Erzeugen.MerkmalTyp
{
    class MerkmalText100
    {
        private AWLQuellcode awlQuellcode;
        private Consoleview view;


        public MerkmalText100(AWLQuellcode awlQuellcode, Consoleview view)
        {
            this.awlQuellcode = awlQuellcode;
            this.view = view;
        }

        public string[] MerkmalTEXT100 { get; set; }

        public void Text100()
        {
            //awlQuellcode.AWLStruktur();

            string[] ladeStandartwert = awlQuellcode.StandartwerteLaden();
            string[] ladeKennung = awlQuellcode.MerkmalDetailsLaden(view.MerkmalKennung);

            string[] transferiereKennung = awlQuellcode.AdresseDBZusammenbauen("kennung");
            string[] transferiereEinheit = awlQuellcode.AdresseDBZusammenbauen("einheit");
            string[] transferiereKurvenwertLaenge = awlQuellcode.AdresseDBZusammenbauen("kurvenwertLaenge");
            string[] transferiereWert = awlQuellcode.AdresseDBZusammenbauen("wert");
            string[] transferiereStatus = awlQuellcode.AdresseDBZusammenbauen("status");
            string[] transferiereStufe = awlQuellcode.AdresseDBZusammenbauen("stufe");
            string[] transferiereStufentyp = awlQuellcode.AdresseDBZusammenbauen("stufentyp");
            string[] transferiereAnzahlParameter = awlQuellcode.AdresseDBZusammenbauen("anzahlParameter");

            string[] merkmalText100 = {
                
                // Netzwerk 1 Merkmal nur Netzwerktitel
                awlQuellcode.Network,
                //awlQuellcode.NetworkTitle,
                awlQuellcode.NetzwerkTitel("### " + view.Stationbezeichnung + ": Merkmal XXX / Text100 " + view.MerkmalKennung + " ###"),
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
                ladeStandartwert[1], transferiereEinheit[1],
                ladeStandartwert[1], transferiereEinheit[2],
                ladeStandartwert[1], transferiereEinheit[3],
                ladeStandartwert[1], transferiereEinheit[4],
                ladeStandartwert[1], transferiereEinheit[5],
                ladeStandartwert[1], transferiereEinheit[6],
                ladeStandartwert[1], transferiereEinheit[7],
                ladeStandartwert[1], transferiereEinheit[8],
                ladeStandartwert[1], transferiereEinheit[9],
                ladeStandartwert[1], transferiereEinheit[10],

                // Netzwerk 4 Kurfenwert Länge
                awlQuellcode.Network,
                awlQuellcode.NetzwerkTitel(view.Stationbezeichnung+ ": Merkmal XXX - Kurvenwert - Länge"),
                ladeStandartwert[0], transferiereKurvenwertLaenge[1],
                ladeStandartwert[1], transferiereKurvenwertLaenge[2],

                 // Netzwerk 5 Wert
                awlQuellcode.Network,
                awlQuellcode.NetzwerkTitel(view.Stationbezeichnung+ ": Merkmal XXX - Wert"),
                ladeStandartwert[1], transferiereWert[1],
                ladeStandartwert[1], transferiereWert[2],
                ladeStandartwert[1], transferiereWert[3],
                ladeStandartwert[1], transferiereWert[4],
                ladeStandartwert[1], transferiereWert[5],
                ladeStandartwert[1], transferiereWert[6],
                ladeStandartwert[1], transferiereWert[7],
                ladeStandartwert[1], transferiereWert[8],
                ladeStandartwert[1], transferiereWert[9],
                ladeStandartwert[1], transferiereWert[10],
                ladeStandartwert[1], transferiereWert[11],
                ladeStandartwert[1], transferiereWert[12],
                ladeStandartwert[1], transferiereWert[13],
                ladeStandartwert[1], transferiereWert[14],
                ladeStandartwert[1], transferiereWert[15],
                ladeStandartwert[1], transferiereWert[16],
                ladeStandartwert[1], transferiereWert[17],
                ladeStandartwert[1], transferiereWert[18],
                ladeStandartwert[1], transferiereWert[19],
                ladeStandartwert[1], transferiereWert[20],
                ladeStandartwert[1], transferiereWert[21],
                ladeStandartwert[1], transferiereWert[22],
                ladeStandartwert[1], transferiereWert[23],
                ladeStandartwert[1], transferiereWert[24],
                ladeStandartwert[1], transferiereWert[25],
                ladeStandartwert[1], transferiereWert[26],
                ladeStandartwert[1], transferiereWert[27],
                ladeStandartwert[1], transferiereWert[28],
                ladeStandartwert[1], transferiereWert[29],
                ladeStandartwert[1], transferiereWert[30],
                ladeStandartwert[1], transferiereWert[31],
                ladeStandartwert[1], transferiereWert[32],
                ladeStandartwert[1], transferiereWert[33],
                ladeStandartwert[1], transferiereWert[34],
                ladeStandartwert[1], transferiereWert[35],
                ladeStandartwert[1], transferiereWert[36],
                ladeStandartwert[1], transferiereWert[37],
                ladeStandartwert[1], transferiereWert[38],
                ladeStandartwert[1], transferiereWert[39],
                ladeStandartwert[1], transferiereWert[40],
                ladeStandartwert[1], transferiereWert[41],
                ladeStandartwert[1], transferiereWert[42],
                ladeStandartwert[1], transferiereWert[43],
                ladeStandartwert[1], transferiereWert[44],
                ladeStandartwert[1], transferiereWert[45],
                ladeStandartwert[1], transferiereWert[46],
                ladeStandartwert[1], transferiereWert[47],
                ladeStandartwert[1], transferiereWert[48],
                ladeStandartwert[1], transferiereWert[49],
                ladeStandartwert[1], transferiereWert[50],
                ladeStandartwert[1], transferiereWert[51],
                ladeStandartwert[1], transferiereWert[52],
                ladeStandartwert[1], transferiereWert[53],
                ladeStandartwert[1], transferiereWert[54],
                ladeStandartwert[1], transferiereWert[55],
                ladeStandartwert[1], transferiereWert[56],
                ladeStandartwert[1], transferiereWert[57],
                ladeStandartwert[1], transferiereWert[58],
                ladeStandartwert[1], transferiereWert[59],
                ladeStandartwert[1], transferiereWert[60],
                ladeStandartwert[1], transferiereWert[61],
                ladeStandartwert[1], transferiereWert[62],
                ladeStandartwert[1], transferiereWert[63],
                ladeStandartwert[1], transferiereWert[64],
                ladeStandartwert[1], transferiereWert[65],
                ladeStandartwert[1], transferiereWert[66],
                ladeStandartwert[1], transferiereWert[67],
                ladeStandartwert[1], transferiereWert[68],
                ladeStandartwert[1], transferiereWert[69],
                ladeStandartwert[1], transferiereWert[70],
                ladeStandartwert[1], transferiereWert[71],
                ladeStandartwert[1], transferiereWert[72],
                ladeStandartwert[1], transferiereWert[73],
                ladeStandartwert[1], transferiereWert[74],
                ladeStandartwert[1], transferiereWert[75],
                ladeStandartwert[1], transferiereWert[76],
                ladeStandartwert[1], transferiereWert[77],
                ladeStandartwert[1], transferiereWert[78],
                ladeStandartwert[1], transferiereWert[79],
                ladeStandartwert[1], transferiereWert[80],
                ladeStandartwert[1], transferiereWert[81],
                ladeStandartwert[1], transferiereWert[82],
                ladeStandartwert[1], transferiereWert[83],
                ladeStandartwert[1], transferiereWert[84],
                ladeStandartwert[1], transferiereWert[85],
                ladeStandartwert[1], transferiereWert[86],
                ladeStandartwert[1], transferiereWert[87],
                ladeStandartwert[1], transferiereWert[88],
                ladeStandartwert[1], transferiereWert[89],
                ladeStandartwert[1], transferiereWert[90],
                ladeStandartwert[1], transferiereWert[91],
                ladeStandartwert[1], transferiereWert[92],
                ladeStandartwert[1], transferiereWert[93],
                ladeStandartwert[1], transferiereWert[94],
                ladeStandartwert[1], transferiereWert[95],
                ladeStandartwert[1], transferiereWert[96],
                ladeStandartwert[1], transferiereWert[97],
                ladeStandartwert[1], transferiereWert[98],
                ladeStandartwert[1], transferiereWert[99],
                ladeStandartwert[1], transferiereWert[100],


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
                ladeStandartwert[0], transferiereAnzahlParameter[1],
                ladeStandartwert[1], transferiereAnzahlParameter[2],

                 // Netzwerk 9 Leernetzwerk
                awlQuellcode.Network,
                awlQuellcode.NetzwerkTitel("Leernetzwerk zur Orientierung"),
                
            };

            MerkmalTEXT100 = merkmalText100;
        }
    }
}
