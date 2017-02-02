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
            AWLQuellcode awlQuellcode = new AWLQuellcode();
            MerkmalTyp.MerkmalText10 merkmalText10 = new MerkmalTyp.MerkmalText10(awlQuellcode);
            QuelleErstellen quelleErstellen = new QuelleErstellen(merkmalText10,awlQuellcode );
            Consoleview view = new Consoleview(awlQuellcode);
            Anwendungscontroler controler = new Anwendungscontroler(view, quelleErstellen );

            controler.AnzeigeConsole();
        }
    }
}
