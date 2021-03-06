﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPM_Erzeugen.MerkmalTyp
{
    class MerkmalText255
    {
        private AWLQuellcode awlQuellcode;
        private Consoleview view;


        public MerkmalText255(AWLQuellcode awlQuellcode, Consoleview view)
        {
            this.awlQuellcode = awlQuellcode;
            this.view = view;
        }

        public string[] MerkmalTEXT255 { get; set; }

        public void Text255()
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

            string[] merkmalText255 = {
                
                // Netzwerk 1 Merkmal nur Netzwerktitel
                awlQuellcode.Network,
                //awlQuellcode.NetworkTitle,
                awlQuellcode.NetzwerkTitel("### " + view.Stationbezeichnung + ": Merkmal XXX / Text255 " + view.MerkmalKennung + " ###"),
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
                awlQuellcode.NetzwerkTitel(view.Stationbezeichnung+ ": Merkmal XXX - Kurvenwert - Laenge"),
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
                ladeStandartwert[1], transferiereWert[101],
                ladeStandartwert[1], transferiereWert[102],
                ladeStandartwert[1], transferiereWert[103],
                ladeStandartwert[1], transferiereWert[104],
                ladeStandartwert[1], transferiereWert[105],
                ladeStandartwert[1], transferiereWert[106],
                ladeStandartwert[1], transferiereWert[107],
                ladeStandartwert[1], transferiereWert[108],
                ladeStandartwert[1], transferiereWert[109],
                ladeStandartwert[1], transferiereWert[110],
                ladeStandartwert[1], transferiereWert[111],
                ladeStandartwert[1], transferiereWert[112],
                ladeStandartwert[1], transferiereWert[113],
                ladeStandartwert[1], transferiereWert[114],
                ladeStandartwert[1], transferiereWert[115],
                ladeStandartwert[1], transferiereWert[116],
                ladeStandartwert[1], transferiereWert[117],
                ladeStandartwert[1], transferiereWert[118],
                ladeStandartwert[1], transferiereWert[119],
                ladeStandartwert[1], transferiereWert[120],
                ladeStandartwert[1], transferiereWert[121],
                ladeStandartwert[1], transferiereWert[122],
                ladeStandartwert[1], transferiereWert[123],
                ladeStandartwert[1], transferiereWert[124],
                ladeStandartwert[1], transferiereWert[125],
                ladeStandartwert[1], transferiereWert[126],
                ladeStandartwert[1], transferiereWert[127],
                ladeStandartwert[1], transferiereWert[128],
                ladeStandartwert[1], transferiereWert[129],
                ladeStandartwert[1], transferiereWert[130],
                ladeStandartwert[1], transferiereWert[131],
                ladeStandartwert[1], transferiereWert[132],
                ladeStandartwert[1], transferiereWert[133],
                ladeStandartwert[1], transferiereWert[134],
                ladeStandartwert[1], transferiereWert[135],
                ladeStandartwert[1], transferiereWert[136],
                ladeStandartwert[1], transferiereWert[137],
                ladeStandartwert[1], transferiereWert[138],
                ladeStandartwert[1], transferiereWert[139],
                ladeStandartwert[1], transferiereWert[140],
                ladeStandartwert[1], transferiereWert[141],
                ladeStandartwert[1], transferiereWert[142],
                ladeStandartwert[1], transferiereWert[143],
                ladeStandartwert[1], transferiereWert[144],
                ladeStandartwert[1], transferiereWert[145],
                ladeStandartwert[1], transferiereWert[146],
                ladeStandartwert[1], transferiereWert[147],
                ladeStandartwert[1], transferiereWert[148],
                ladeStandartwert[1], transferiereWert[149],
                ladeStandartwert[1], transferiereWert[150],
                ladeStandartwert[1], transferiereWert[151],
                ladeStandartwert[1], transferiereWert[152],
                ladeStandartwert[1], transferiereWert[153],
                ladeStandartwert[1], transferiereWert[154],
                ladeStandartwert[1], transferiereWert[155],
                ladeStandartwert[1], transferiereWert[156],
                ladeStandartwert[1], transferiereWert[157],
                ladeStandartwert[1], transferiereWert[158],
                ladeStandartwert[1], transferiereWert[159],
                ladeStandartwert[1], transferiereWert[160],
                ladeStandartwert[1], transferiereWert[161],
                ladeStandartwert[1], transferiereWert[162],
                ladeStandartwert[1], transferiereWert[163],
                ladeStandartwert[1], transferiereWert[164],
                ladeStandartwert[1], transferiereWert[165],
                ladeStandartwert[1], transferiereWert[166],
                ladeStandartwert[1], transferiereWert[167],
                ladeStandartwert[1], transferiereWert[168],
                ladeStandartwert[1], transferiereWert[169],
                ladeStandartwert[1], transferiereWert[170],
                ladeStandartwert[1], transferiereWert[171],
                ladeStandartwert[1], transferiereWert[172],
                ladeStandartwert[1], transferiereWert[173],
                ladeStandartwert[1], transferiereWert[174],
                ladeStandartwert[1], transferiereWert[175],
                ladeStandartwert[1], transferiereWert[176],
                ladeStandartwert[1], transferiereWert[177],
                ladeStandartwert[1], transferiereWert[178],
                ladeStandartwert[1], transferiereWert[179],
                ladeStandartwert[1], transferiereWert[180],
                ladeStandartwert[1], transferiereWert[181],
                ladeStandartwert[1], transferiereWert[182],
                ladeStandartwert[1], transferiereWert[183],
                ladeStandartwert[1], transferiereWert[184],
                ladeStandartwert[1], transferiereWert[185],
                ladeStandartwert[1], transferiereWert[186],
                ladeStandartwert[1], transferiereWert[187],
                ladeStandartwert[1], transferiereWert[188],
                ladeStandartwert[1], transferiereWert[189],
                ladeStandartwert[1], transferiereWert[190],
                ladeStandartwert[1], transferiereWert[191],
                ladeStandartwert[1], transferiereWert[192],
                ladeStandartwert[1], transferiereWert[193],
                ladeStandartwert[1], transferiereWert[194],
                ladeStandartwert[1], transferiereWert[195],
                ladeStandartwert[1], transferiereWert[196],
                ladeStandartwert[1], transferiereWert[197],
                ladeStandartwert[1], transferiereWert[198],
                ladeStandartwert[1], transferiereWert[199],
                ladeStandartwert[1], transferiereWert[200],
                ladeStandartwert[1], transferiereWert[201],
                ladeStandartwert[1], transferiereWert[202],
                ladeStandartwert[1], transferiereWert[203],
                ladeStandartwert[1], transferiereWert[204],
                ladeStandartwert[1], transferiereWert[205],
                ladeStandartwert[1], transferiereWert[206],
                ladeStandartwert[1], transferiereWert[207],
                ladeStandartwert[1], transferiereWert[208],
                ladeStandartwert[1], transferiereWert[209],
                ladeStandartwert[1], transferiereWert[210],
                ladeStandartwert[1], transferiereWert[211],
                ladeStandartwert[1], transferiereWert[212],
                ladeStandartwert[1], transferiereWert[213],
                ladeStandartwert[1], transferiereWert[214],
                ladeStandartwert[1], transferiereWert[215],
                ladeStandartwert[1], transferiereWert[216],
                ladeStandartwert[1], transferiereWert[217],
                ladeStandartwert[1], transferiereWert[218],
                ladeStandartwert[1], transferiereWert[219],
                ladeStandartwert[1], transferiereWert[220],
                ladeStandartwert[1], transferiereWert[221],
                ladeStandartwert[1], transferiereWert[222],
                ladeStandartwert[1], transferiereWert[223],
                ladeStandartwert[1], transferiereWert[224],
                ladeStandartwert[1], transferiereWert[225],
                ladeStandartwert[1], transferiereWert[226],
                ladeStandartwert[1], transferiereWert[227],
                ladeStandartwert[1], transferiereWert[228],
                ladeStandartwert[1], transferiereWert[229],
                ladeStandartwert[1], transferiereWert[230],
                ladeStandartwert[1], transferiereWert[231],
                ladeStandartwert[1], transferiereWert[232],
                ladeStandartwert[1], transferiereWert[233],
                ladeStandartwert[1], transferiereWert[234],
                ladeStandartwert[1], transferiereWert[235],
                ladeStandartwert[1], transferiereWert[236],
                ladeStandartwert[1], transferiereWert[237],
                ladeStandartwert[1], transferiereWert[238],
                ladeStandartwert[1], transferiereWert[239],
                ladeStandartwert[1], transferiereWert[240],
                ladeStandartwert[1], transferiereWert[241],
                ladeStandartwert[1], transferiereWert[242],
                ladeStandartwert[1], transferiereWert[243],
                ladeStandartwert[1], transferiereWert[244],
                ladeStandartwert[1], transferiereWert[245],
                ladeStandartwert[1], transferiereWert[246],
                ladeStandartwert[1], transferiereWert[247],
                ladeStandartwert[1], transferiereWert[248],
                ladeStandartwert[1], transferiereWert[249],
                ladeStandartwert[1], transferiereWert[250],
                ladeStandartwert[1], transferiereWert[251],
                ladeStandartwert[1], transferiereWert[252],
                ladeStandartwert[1], transferiereWert[253],
                ladeStandartwert[1], transferiereWert[254],
                ladeStandartwert[1], transferiereWert[255],


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

            MerkmalTEXT255 = merkmalText255;
        }
    }
}
