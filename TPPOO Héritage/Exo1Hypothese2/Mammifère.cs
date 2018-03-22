using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exo1Hypothese2
{
    class Mammifère
    {
        private string nom;
        private string LieuHabitation;
        private string monCri;
        private bool jeSuisDomestique;

        public Mammifère(string nom, string LieuHabitation, string monCri, bool jeSuisDomestique)
        {
            this.nom = nom;
            this.LieuHabitation = LieuHabitation;
            this.monCri = monCri;
            this.jeSuisDomestique = jeSuisDomestique;
        }
        public void Afficher()
        {
            Console.WriteLine("Nom: {0}\nLieu d'habitation: {1}\nCri: {2}\nDomestique: {3}\n", nom, LieuHabitation,monCri,jeSuisDomestique);
        }
        public bool JeSuisDangereux()
        {
            return true;
        }
    }
}
