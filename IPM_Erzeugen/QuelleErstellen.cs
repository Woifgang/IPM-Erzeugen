using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPM_Erzeugen
{
    class QuelleErstellen
    {
        // private AWLQuellcode awlQuellcode;

        private MerkmalTyp.MerkmalText10 merkmalText10;
        private AWLQuellcode awlQuellcode;

        public QuelleErstellen(MerkmalTyp.MerkmalText10 merkmalText10, AWLQuellcode awlQuellcode)
        {
            this.merkmalText10 = merkmalText10;
            this.awlQuellcode = awlQuellcode;
        }

        public void ErzeugeAWLQuellcode()
        {
            

            switch (awlQuellcode.MerkmalTyp)
            {
                case "10":
                    merkmalText10.Text10();
                    break;   
                
                default:
                    Console.WriteLine("Merkmal Typ ist ungültig");
                    break;
            }

        }


    }
}
