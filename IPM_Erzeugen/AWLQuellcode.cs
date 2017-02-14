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
        public string VarTempStart { get; private set; }
        public string VarTempEnd { get; private set; }
        public string Begin { get; private set; }
        public string Network { get; private set; }
        public string NetworkTitle { get; private set; }
        public string EndFunction { get; private set; }
        public string[] Header { get; private set; }


        public void AWLStruktur()
        {
            FunktionStart = "FUNCTION" + BenutzerdefinierterTitel( "\"IPM__QUELLE\"" ) + ": VOID";
            Titel = "TITLE ="+ BenutzerdefinierterTitel(" Automatisch Generierte Quelle ");
            Version = "VERSION : 0.1";
            VarTempStart = "VAR_TEMP";
            VarTempEnd = "END_VAR";
            Begin = "BEGIN";
            Network = "NETWORK";
            EndFunction = "END_FUNCTION";
            Header = AWLQuellCodeHeader();
        }

        /// <summary>
        /// Temporär Variable erzeugen
        /// </summary>
        /// <param name="name"></param>
        /// <param name="datentyp"></param>
        /// <param name="kommentar"></param>
        /// <returns></returns>
        private string Variable(string name, string datentyp, string kommentar)
        {
            return name + " : " + datentyp + " ; " + " // " + kommentar;
        }

        /// <summary>
        /// Benuzerdefinierten Text ausgeben
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        private string BenutzerdefinierterTitel(string text)
        {
            return text;
        }

        /// <summary>
        /// Erzeuge Netzwerktitel
        /// </summary>
        /// <param name="beschreiben"></param>
        /// <returns></returns>
        public string NetzwerkTitel(string beschreiben)
        {
            return "TITLE =" + beschreiben;
        }

        /// <summary>
        /// Erzeuge Netzwerk Kommentar
        /// </summary>
        /// <param name="kommentar"></param>
        /// <returns></returns>
        public string NetzwerkKommentar(string kommentar)
        {
            return "// " + kommentar;
        }


        /// <summary>
        /// Merkmal Details Laden
        /// </summary>
        /// <param name="wert"></param>
        /// <returns></returns>
        public string[] MerkmalDetailsLaden(string wert)
        {
            string kennung = wert;
            string[] zerlegen = new string[20];

            for (int i = 0; i < 20; i++)
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

        public string[] AnzahlParameter(int anzahl)
        {
            string[] parameterAnzahl = new string[2];
            string tmp = Convert.ToString(anzahl);

            if (anzahl <= 9)
            {
                parameterAnzahl[1] = "L '" + tmp + "';";
            }
            else
            {
                parameterAnzahl[2] = "L ' ';";
            }

            return parameterAnzahl;
        }


        /// <summary>
        /// Baut eine Variable zusammen;
        /// Gibt z.B.: "  T "DB_IPM_SEND_BA03".daten.ST350_1.M1_Daten.kennung[1]   " zurück abhängig vom eingetragen Wert
        /// </summary>
        /// <param name="wert"></param>
        /// <returns></returns>
        public string[] AdresseDBZusammenbauen(string wert)
        {
            string[] tmp = new string[256];

            for (int i = 1; i < 256; i++)
            {
                string kennung = Convert.ToString(i);
                tmp[i] = "T DB" + view.DBnummer + ".daten." + view.Stationbezeichnung + "." + view.MerkmalsBlock + "." + wert + "[" + kennung + "];";
            }
            return tmp;
        }

 
        /// <summary>
        /// Baut eine Variable zusammen;
        /// Gitbt z.B.:  "DB_IPM_SEND_BA03".daten.ST350_1.M5_Parameter[1].kennung[1] zurück
        /// </summary>
        /// <param name="wert"></param>
        /// <returns></returns>
        public string[] AdresseDBZusammenbauenParameter(string wert)
        {
            //Merkmalsblock zerlegen
            string s1 = view.MerkmalsBlock;
            char[] charSeparators = new char[] { '_' };
            string[] result;
            result = s1.Split(charSeparators);

            string array = Convert.ToString(view.ParameterZaehlen);
            

            string[] tmp = new string[256];

            for (int i = 1; i < 256; i++)
            {
                string kennung = Convert.ToString(i);
                tmp[i] = "T DB" + view.DBnummer + ".daten." + view.Stationbezeichnung + "." + result[0]  + "_Parameter["+ array +"]." + wert + "[" + kennung + "];";
            }
            return tmp;
        }

        /// <summary>
        /// Standartwerte Laden;
        /// tmp[0] gibt " L '0'; " zurück!!! 
        /// tmp[1] gibt " L ' '; " zurück!!! 
        /// </summary>
        /// <returns></returns>
        public string[] StandartwerteLaden()
        {
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

        // Header für Temporäre Variablen erzeugen
        private string[] AWLQuellCodeHeader()
        {
            string[] header = {
           FunktionStart,
                Titel,
                Version,
                // Variablen
                VarTempStart,
                Variable("_retval", "int", ""),
                Variable("t_WIO", "BOOL", "HM Werker-IO"),
                Variable("t_WNIO", "BOOL", "HM Werker-NIO"),
                Variable("t_ABGW", "BOOL", "HM abgewählt"),
                Variable("t_NG", "BOOL", "HM nicht getätigt"),
                Variable("t_ZIO", "BOOL", "HM nach 2. mal IO"),
                Variable("t_RIO", "BOOL", "HM nach Rep IO"),
                Variable("t_ok", "BOOL", "HM Status OK"),
                Variable("t_HW_R", "REAL", "Hilfswert Real"),
                VarTempEnd,
                Begin
            };
            return header;
        }


        private string KennungZerlegen(string merkmalsBlock, int parameterAnzahl)
        {
            string s1 = merkmalsBlock;
            char[] charSeparators = new char[] { '_' };
            string[] result;
            result = s1.Split(charSeparators);

            string array = Convert.ToString(parameterAnzahl);

            return result[0];
        }

        /// <summary>
        /// Erzeugt den FC FC_KONV_REAL_CHAR;
        /// Dieser sting wird zusammengebaut
        /// "DB_IPM_SEND_BA03".daten.ST350_1.M4_Parameter[1].numWert,
        /// </summary>
        /// <param name="dbNummer"></param>
        /// <param name="station"></param>
        /// <param name="parameter"></param>
        /// <param name="parameterNummer"></param>
        /// <returns></returns>
        public string[] ErzeugeFC_KONV_REAL_CHAR(string dbNummer, string station, string merkmalsBlock, int parameterAnzahl)
        {
            string tmp = KennungZerlegen(merkmalsBlock, parameterAnzahl);


            string[] function =
            {
                Network,
                NetzwerkTitel("Station xxx Merkmal xxx - Parameter xxx - WERT"),
                NetzwerkKommentar("Hier noch befüllen!!!"),
                "CALL \"FC_KONV_REAL_CHAR\" (",
                "Wert := #t_HW_R,",
                "Anz_Nachkomma := 2,",
               // "Zeiger := DB"+dbNummer + ".daten."+station+"."+parameter+"["+parameterNummer+"].numWert,",
                "Zeiger := DB"+dbNummer + ".daten."+station+"."+tmp+"_Parameter["+Convert.ToString(parameterAnzahl )+"].numWert,",
                "Leerzeichen := \"VKE1\");",
            };
            return function;
        }

    }
}