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

            QuelleErstellen quelleErstellen = new QuelleErstellen();
            Consoleview view = new Consoleview(quelleErstellen);
            Anwendungscontroler controler = new Anwendungscontroler(view, quelleErstellen );

            controler.AnzeigeConsole();
        }
    }
}
