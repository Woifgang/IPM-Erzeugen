using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPM_Erzeugen.Parameter
{
    class ParameterFloat
    {
        private AWLQuellcode awlQuellcode;
        private Consoleview view;

        public ParameterFloat(AWLQuellcode awlQuellcode, Consoleview view)
        {
            this.awlQuellcode = awlQuellcode;
            this.view = view;
        }

        public string[] ParameterFLOAT { get; set; }

        public void Float()
        {
            string[] ladeStandartwert = awlQuellcode.StandartwerteLaden();

            // ParameterKennung 
           
            string[] ladeKennung = awlQuellcode.MerkmalDetailsLaden(view.ParameterKennung);
           
            string[] transferiereKennung = awlQuellcode.AdresseDBZusammenbauen("kennung");
            string[] transferiereDatentyp = awlQuellcode.AdresseDBZusammenbauen("datentyp");
            string[] transferiereNumWert = awlQuellcode.AdresseDBZusammenbauen("numWert");
            
            string[] parameterFloat = {

                awlQuellcode.Network,
                awlQuellcode.NetzwerkTitel("### " + view.Stationbezeichnung + ": Parameter XXX / FLOAT " + view.ParameterKennung + " ###"),
                
                // Netzwerk  Parameter Kennung
                awlQuellcode.Network,
                awlQuellcode.NetzwerkTitel(view.Stationbezeichnung+ ": Parameter XXX - Parameterkennung"),
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
                ladeKennung[18], transferiereKennung[19],
                ladeKennung[19], transferiereKennung[20],

                // Netzwerk Parameter Datentyp
                 awlQuellcode.Network,
                awlQuellcode.NetzwerkTitel(view.Stationbezeichnung+ ": Parameter XXX - Parameter Datentyp"),
                ladeStandartwert[0], transferiereDatentyp[1],
                ladeStandartwert[1], transferiereDatentyp[2],

                // Netzwerk Numwert
                // Todo: 
                //FC       CALL  "FC_KONV_REAL_CHAR"
                //  Wert         :=#t_HW_R
                // Anz_Nachkomma:= 2
                // Zeiger:= "DB_IPM_SEND_BA03".daten.ST350_1.M4_Parameter[1].numWert
                //Leerzeichen:= "VKE1"

                //ladeStandartwert[1], transferiereNumWert[1],

            };

            ParameterFLOAT = parameterFloat;

        }
    }
}
