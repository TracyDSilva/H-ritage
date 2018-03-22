using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exo1Hypothese2
{
    class Chat:Felin
    {
        public Chat(string nom, string LieuHabitation, string monCri, bool jeSuisDomestique, int nombrePattes)
            : base(nom, LieuHabitation, monCri, jeSuisDomestique, nombrePattes)
        {
        }
        public new void Afficher()
        {
            base.Afficher();
        }
    }
}
