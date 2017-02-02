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
        private MerkmalTyp.MerkmalText50 merkmalText50;
        private MerkmalTyp.MerkmalText100 merkmalText100;
        private MerkmalTyp.MerkmalText255 merkmalText255;
        private MerkmalTyp.MerkmalFloat merkmalFloat;

        public QuelleErstellen(
            Consoleview view, 
            AWLQuellcode awlQuellcode, 
            MerkmalTyp.MerkmalText10 merkmalText10, 
            MerkmalTyp.MerkmalText20 merkmalText20, 
            MerkmalTyp.MerkmalText50 merkmalText50, 
            MerkmalTyp.MerkmalText100 merkmalText100, 
            MerkmalTyp.MerkmalText255 merkmalText255, 
            MerkmalTyp.MerkmalFloat merkmalFloat
            )
        {
            this.view = view;
            this.awlQuellcode = awlQuellcode;
            this.merkmalText10 = merkmalText10;
            this.merkmalText20 = merkmalText20;
            this.merkmalText50 = merkmalText50;
            this.merkmalText100 = merkmalText100;
            this.merkmalText255 = merkmalText255;
            this.merkmalFloat = merkmalFloat;
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

                case "50":
                    merkmalText50.Text50();
                    view.AWLQuelleGeneriert("TEXT 50");
                    break;

                case "100":
                    merkmalText100.Text100();
                    view.AWLQuelleGeneriert("TEXT 100");
                    break;

                case "255":
                    merkmalText255.Text255();
                    view.AWLQuelleGeneriert("TEXT 255");
                    break;

                case "F":
                    merkmalFloat.Float();
                    view.AWLQuelleGeneriert("FLOAT");
                    break;

                default:
                    Console.WriteLine("Merkmal Typ ist ungültig");
                    break;
            }

        }


    }
}
