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

        public string MerkmalKennung { get; set; }
        public string MerkmalBeschreibung { get; set; }
        public string MerkmalTyp { get; set; }

        public void ErzeugeLogdatei()
        {
            awlQuellcode.AWL();

            string[] kennung = MerkmalKennungLaden(MerkmalKennung);

            string[] lines = {
                // Header
                awlQuellcode.FunktionStart,
                awlQuellcode.Titel,
                awlQuellcode.Version,
                awlQuellcode.Begin,
                // Netzwerk 1
                awlQuellcode.Network,
                awlQuellcode.NetworKTitle,
                kennung[0],
                kennung[1],
                MerkmalBeschreibung ,
                // Netzwerk 2
                awlQuellcode.Network,
                awlQuellcode.NetworKTitle,
                MerkmalTyp,
                // Ende
                awlQuellcode.EndFunction
            };

            System.IO.File.WriteAllLines(@"C:\Users\Public\WriteLines.awl", lines);
        }


        private string[] MerkmalKennungLaden(string wert)
        {
            string kennung = wert;
            string[] zerlegen = new string[kennung.Length];
            for (int i = 0; i < kennung.Length; i++)
            {
                zerlegen[i] = "L " + kennung[i].ToString() + ";";
            }
            return zerlegen;
        }




        /*

        private string[] Kennung()
        {

            string[] tmp = new string[18];
            for (int i = 0; i <= 18; i++)
            {
                tmp[i] = "L " + MerkmalKennungZerlegen(quelleErstellen.MerkmalKennung)[i] + ";";
            }
            return tmp;

        }

        private string[] KennungZuweisen()
        {

            string[] tmp = new string[18];
            for (int i = 0; i <= 18; i++)
            {
                tmp[i] = "T " + Convert.ToString(i) + ";";
            }
            return tmp;

        }

        */


    }
}
