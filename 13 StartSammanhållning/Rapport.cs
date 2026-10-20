using System;
using System.Collections.Generic;
using System.Text;

namespace _13_StartSammanhållning
{
    internal class Rapport
    {
        public string titel;
        public string Titel
        {
            get { return titel; }
        }
        public Rapport(string rapportTitel)
        {
            titel = rapportTitel;
        }
        //Så det handlar om att klassen ska ha ett ansvarsområde, i detta fall så har den bara en egenskap som heter titel på rapporten och gör att man kan läsa den
        //Man sätter den genom en kontruktor.
    }
}
