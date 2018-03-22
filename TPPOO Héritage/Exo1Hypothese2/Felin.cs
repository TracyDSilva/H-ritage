using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exo1Hypothese2
{
    class Felin:Mammifère
    {
        private int nombrePattes;

        public Felin(string nom, string LieuHabitation, string monCri, bool jeSuisDomestique, int nombrePattes)
            : base(nom, LieuHabitation, monCri, jeSuisDomestique)
        {
            this.nombrePattes = nombrePattes;
        }

        public new void Afficher()
        {
            base.Afficher();
            Console.WriteLine("Nombre de pattes: {0}\n", nombrePattes);
        }
    }
}
