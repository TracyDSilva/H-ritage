using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exo1Hypothese2
{
    class Baleine:Cetace
    {
        public Baleine(string nom, string LieuHabitation, string monCri, bool jeSuisDomestique, int DureeApnee, int ProfondeurPlongee)
            : base(nom, LieuHabitation, monCri, jeSuisDomestique, DureeApnee, ProfondeurPlongee)
        {
        }

        public new void Afficher()
        {
            base.Afficher();
        }
    }
}
