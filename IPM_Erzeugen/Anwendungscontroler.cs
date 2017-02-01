using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPM_Erzeugen
{
    class Anwendungscontroler
    {
        private Consoleview view;

        public Anwendungscontroler(Consoleview view)
        {
            this.view = view;
        }

        public void AnzeigeConsole()
        {
            view.HoleBenutzereingabe();
        }

    }
}
