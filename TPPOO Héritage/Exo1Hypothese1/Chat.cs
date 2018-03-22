using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exo1Hypothese1
{
    class Chat:Felin
    {
        public Chat(string nom, string LieuHabitation, string monCri, bool jeSuisDomestique, int nombrePattes)
            : base(nom, LieuHabitation, monCri, jeSuisDomestique, nombrePattes)
        {
            this.nom = nom;
            this.LieuHabitation = LieuHabitation;
            this.monCri = monCri;
            this.jeSuisDomestique = jeSuisDomestique;
            this.nombrePattes = nombrePattes;
        }

        public void Afficher()
        {
            Console.WriteLine("Nom: {0}\nLieu d'habitation: {1}\nCri: {2}\nDomestique: {3}\nNombre de pattes: {4}\n",nom,LieuHabitation,monCri,jeSuisDomestique,nombrePattes);
        }

        public bool JesuisDangereux()
        {
            base.JeSuisDangereux();
            dangereux = false;
            Console.WriteLine("{0} est-il dangereux ? " + dangereux + ".", nom);
            return true;
        }
    }
}
