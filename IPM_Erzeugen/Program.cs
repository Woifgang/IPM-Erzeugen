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
            Anwendungscontroler controler = new Anwendungscontroler(view);

            controler.AnzeigeConsole();
        }
    }
}
