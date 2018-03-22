using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exo1Hypothese1
{
    class Baleine : Cetace
    {
        public Baleine(string nom, string LieuHabitation, string monCri, bool jeSuisDomestique, int DureeApnee, int ProfondeurPlongee)
            : base(nom, LieuHabitation, monCri, jeSuisDomestique, DureeApnee, ProfondeurPlongee)
        {
            this.nom = nom;
            this.LieuHabitation = LieuHabitation;
            this.monCri = monCri;
            this.jeSuisDomestique = jeSuisDomestique;
            this.DureeApnee = DureeApnee;
            this.ProfondeurPlongee = ProfondeurPlongee;
        }

        public void Afficher()
        {
            Console.WriteLine("Nom: {0}\nLieu d'habitation: {1}\nCri: {2}\nDomestique: {3}\nDurée Apnée: {4}\nProfondeur de plongée: {5}\n", nom, LieuHabitation, monCri, jeSuisDomestique, DureeApnee, ProfondeurPlongee);
        }

        public new bool JeSuisDangereux()
        {
            base.JeSuisDangereux();
            dangereux = false;
            Console.WriteLine("{0} est-il dangereux ? " + dangereux + ".", nom);
            return true;
        }
    }
}
