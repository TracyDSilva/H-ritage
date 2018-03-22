using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exo1Hypothese1
{
    class Cetace:Mammifere
    {
        protected int DureeApnee;
        protected int ProfondeurPlongee;

        public Cetace(string nom, string LieuHabitation, string monCri, bool jeSuisDomestique, int dureeApnee, int ProfondeurPlongee):base(nom,LieuHabitation,monCri,jeSuisDomestique)
        {
            this.nom = nom;
            this.LieuHabitation = LieuHabitation;
            this.monCri = monCri;
            this.jeSuisDomestique = jeSuisDomestique;
        }

        //public new bool JeSuisDangereux()
        //{
        //    base.JeSuisDangereux();
        //    dangereux = true;
        //    Console.WriteLine("{0} est-il dangereux ? " + dangereux + ".", nom);
        //    return true;
        //}
    }
}
