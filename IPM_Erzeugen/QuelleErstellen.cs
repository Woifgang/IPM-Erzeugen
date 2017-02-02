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
        private Consoleview view;

        public QuelleErstellen(MerkmalTyp.MerkmalText10 merkmalText10, AWLQuellcode awlQuellcode,Consoleview view)
        {
            this.merkmalText10 = merkmalText10;
            this.awlQuellcode = awlQuellcode;
            this.view = view;
        }

        public void ErzeugeAWLQuellcode()
        {
            switch (view.MerkmalTyp)
            {
                case "10":
                    merkmalText10.Text10();
                    view.AWLQuelleGeneriert("TEXT 10");
                    break;   
                
                default:
                    Console.WriteLine("Merkmal Typ ist ungültig");
                    break;
            }

        }


    }
}
