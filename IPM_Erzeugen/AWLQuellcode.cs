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
            string[] tmp = new string[19];
            //string wert = ".kennung[";


            for (int i = 1; i < 19; i++)
            {
                //"T \"DB_IPM_SEND_BA03\".daten.ST350_1.M1_Daten.kennung[1];";
                //         DBnummer + Stationbezeichnung + Merkmalsblock +
                string kennung = Convert.ToString(i);

                tmp[i] = "T DB" + view.DBnummer + ".daten." + view.Stationbezeichnung + "." + view.Merkmalsblock + "." + wert + "[" + kennung + "];";
            }
            return tmp;
        }

    }
}



/*
NETWORK
TITLE =ST350: MERKMAL 1 - Merkmalskennung

      L     'S'; 
      T     "DB_IPM_SEND_BA03".daten.ST350_1.M1_Daten.kennung[1]; 
      L     'T'; 
      T     "DB_IPM_SEND_BA03".daten.ST350_1.M1_Daten.kennung[2]; 
      L     'K'; 
      T     "DB_IPM_SEND_BA03".daten.ST350_1.M1_Daten.kennung[3]; 
      L     'Z'; 
      T     "DB_IPM_SEND_BA03".daten.ST350_1.M1_Daten.kennung[4]; 
      L     ' '; 
      T     "DB_IPM_SEND_BA03".daten.ST350_1.M1_Daten.kennung[5]; 
      L     ' '; 
      T     "DB_IPM_SEND_BA03".daten.ST350_1.M1_Daten.kennung[6]; 
*/
