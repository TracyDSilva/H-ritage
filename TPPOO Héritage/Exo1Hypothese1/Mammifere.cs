using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exo1Hypothese1
{
    class Mammifere
    {
        protected string nom;
        protected string LieuHabitation;
        protected string monCri;
        protected bool jeSuisDomestique;
        protected bool dangereux;

        public Mammifere(string nom, string LieuHabitation, string monCri, bool jeSuisDomestique)
        {
            this.nom = nom;
            this.LieuHabitation = LieuHabitation;
            this.monCri = monCri;
            this.jeSuisDomestique = jeSuisDomestique;
            
        }

        public bool JeSuisDangereux()
        {
            return true;
        }
    }
}
