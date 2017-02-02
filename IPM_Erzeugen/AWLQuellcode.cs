using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPM_Erzeugen
{
    class AWLQuellcode
    {
        public AWLQuellcode()
        {

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
