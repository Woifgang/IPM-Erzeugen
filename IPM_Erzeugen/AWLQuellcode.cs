using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPM_Erzeugen
{
    class AWLQuellcode
    {
        private Consoleview view;

        public AWLQuellcode(Consoleview view)
        {
            this.view = view;
        }

        public string FunktionStart { get; private  set; }
        public string Titel { get; private set; }
        public string Version { get; private set; }
        public string Begin { get; private set; }
        public string Network { get; private set; }
        public string NetworkTitle { get; private set; }
        public string EndFunction { get; private set; }


        
        public void AWLStruktur()
        {
            FunktionStart = "FUNCTION" + BenutzerdefinierterTitel( "\"TEST__QUELLE\"" ) + ": VOID";
            Titel = "TITLE ="+ BenutzerdefinierterTitel(" I bin die Quelle aus Visual Studio ");
            Version = "VERSION : 0.1";
            Begin = "BEGIN";
            Network = "NETWORK";
            EndFunction = "END_FUNCTION";
                       
        }

        private string BenutzerdefinierterTitel(string text)
        {
            return text;
        }

        public string NetzwerkTitel(string beschreiben)
        {
            return "TITLE =" + beschreiben;
        }

        public string NetzwerkKommentar(string kommentar)
        {
            return "// " + kommentar;
        }


        public string[] MerkmalKennungLaden(string wert)
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
                    zerlegen[i] = "L ' ';";
                }

            }
            return zerlegen;
        }

        public string[] AdresseDBZusammenbauen(string wert)
        {
            string[] tmp = new string[255];

            for (int i = 1; i < 255; i++)
            {
                string kennung = Convert.ToString(i);
                tmp[i] = "T DB" + view.DBnummer + ".daten." + view.Stationbezeichnung + "." + view.Merkmalsblock + "." + wert + "[" + kennung + "];";
            }
            return tmp;
        }

        /// <summary>
        /// tmp[0] gibt " L '0'; " zurück!!! 
        /// tmp[1] gibt " L ' '; " zurück!!! 
        /// </summary>
        /// <returns></returns>
        public string[] StandartwerteLaden()
        {
            // tmp[0] gibt " L '0'; " zurück
            // 


            string[] tmp = new string[2];

            for (int i = 0; i < tmp.Length; i++)
            {
                if (i < 1)
                {
                    tmp[i] = "L '0'; ";
                }
                else
                {
                    tmp[i] = "L ' '; ";
                }
            }
            return tmp;
        }

    }
}



/*
NETWORK
TITLE =ST350: MERKMAL 1 - Merkmal - Einheit

      L     ' '; 
      T     "DB_IPM_SEND_BA03".daten.ST350_1.M1_Daten.einheit[1]; 
      T     "DB_IPM_SEND_BA03".daten.ST350_1.M1_Daten.einheit[2]; 
      T     "DB_IPM_SEND_BA03".daten.ST350_1.M1_Daten.einheit[3]; 

*/
