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
            MerkmalTyp.MerkmalFloat merkmalFloat = new MerkmalTyp.MerkmalFloat(awlQuellcode, view);
            MerkmalTyp.MerkmalText50 merkmalText50 = new MerkmalTyp.MerkmalText50(awlQuellcode, view);
            MerkmalTyp.MerkmalText100 merkmalText100 = new MerkmalTyp.MerkmalText100(awlQuellcode, view);
            MerkmalTyp.MerkmalText255 merkmalText255 = new MerkmalTyp.MerkmalText255(awlQuellcode, view);
            Parameter.ParameterFloat parameterFloat = new Parameter.ParameterFloat(awlQuellcode,view );

            QuelleErstellen quelleErstellen = new QuelleErstellen(
                view, 
                awlQuellcode, 
                merkmalText10,
                merkmalText20,
                merkmalText50,
                merkmalText100,
                merkmalText255,
                merkmalFloat,
                parameterFloat                 
                );           

            Anwendungscontroler controler = new Anwendungscontroler(view, quelleErstellen );
            
            controler.AnzeigeConsole();
        }
    }
}
