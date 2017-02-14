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
        private QuelleErstellen quelleErstellen;
       
        public Anwendungscontroler(Consoleview view, QuelleErstellen quelleErstellen)
        {
            this.view = view;
            this.quelleErstellen = quelleErstellen;
        }
       
        public void AnzeigeConsole()
        {

            view.HoleBenutzereingabe();
            quelleErstellen.ErzeugeHeader();
            quelleErstellen.ErzeugeAWLQuellcode();

           /* while (!view.ParameterEnde)
            {
                view.ParameterEingabe();
                if (!view.ParameterEnde)
                {
                    quelleErstellen.ErzeugeParameter();
                }
            }*/
            

            while (!view.BenutzerWillBeenden )
            {
                view.NachFolgendeBenutzerEingabe();
                if (!view.BenutzerWillBeenden)
                {
                    quelleErstellen.ErzeugeAWLQuellcode();

                    while (!view.ParameterEnde)
                    {
                        view.ParameterZaehlen = view.ParameterZaehlen + 1;
                        view.ParameterEingabe();
                        if (!view.ParameterEnde)
                        {
                            quelleErstellen.ErzeugeParameter();
                        }
                    }
                }
                
            }
            quelleErstellen.ErzeugeEndFuncttion();
            view.BeendeProgramm();
        }

    }
}
