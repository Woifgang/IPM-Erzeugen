using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPM_Erzeugen
{
    class Program
    {
        static void Main(string[] args)
        {
            Consoleview view = new Consoleview();
            AWLQuellcode awlQuellcode = new AWLQuellcode(view);
            MerkmalTyp.MerkmalText10 merkmalText10 = new MerkmalTyp.MerkmalText10(awlQuellcode,view);
            MerkmalTyp.MerkmalText20 merkmalText20 = new MerkmalTyp.MerkmalText20(awlQuellcode, view);
            QuelleErstellen quelleErstellen = new QuelleErstellen(view, awlQuellcode, merkmalText10, merkmalText20);           
            Anwendungscontroler controler = new Anwendungscontroler(view, quelleErstellen );

            controler.AnzeigeConsole();
        }
    }
}
