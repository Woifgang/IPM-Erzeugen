using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPM_Erzeugen
{
    class QuelleErstellen
    {

        private Consoleview view;
        private AWLQuellcode awlQuellcode;
        private MerkmalTyp.MerkmalText10 merkmalText10;
        private MerkmalTyp.MerkmalText20 merkmalText20;

        public QuelleErstellen(Consoleview view, AWLQuellcode awlQuellcode, MerkmalTyp.MerkmalText10 merkmalText10, MerkmalTyp.MerkmalText20 merkmalText20)
        {
            this.view = view;
            this.awlQuellcode = awlQuellcode;
            this.merkmalText10 = merkmalText10;
            this.merkmalText20 = merkmalText20;
        }

        public void ErzeugeAWLQuellcode()
        {
            switch (view.MerkmalTyp)
            {
                case "10":
                    merkmalText10.Text10();
                    view.AWLQuelleGeneriert("TEXT 10");
                    break;

                case "20":
                    merkmalText20.Text20();
                    view.AWLQuelleGeneriert("TEXT 20");
                    break;

                default:
                    Console.WriteLine("Merkmal Typ ist ungültig");
                    break;
            }

        }


    }
}
