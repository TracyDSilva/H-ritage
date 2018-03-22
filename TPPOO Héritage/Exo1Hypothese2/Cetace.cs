using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exo1Hypothese2
{
    class Cetace:Mammifère
    {
        private int DureeApnee;
        private int ProfondeurPlongee;

        public Cetace(string nom, string LieuHabitation, string monCri, bool jeSuisDomestique, int DureeApnee, int ProfondeurPlongee)
            : base(nom, LieuHabitation, monCri, jeSuisDomestique)
        {
            this.DureeApnee = DureeApnee;
            this.ProfondeurPlongee = ProfondeurPlongee;
        }

        //public void Afficher()
        //{
        //    base.Afficher();
        //    Console.WriteLine("Durée apnée: {0}\nProfondeur Plongée; {1}", DureeApnee, ProfondeurPlongee);
        //}

    }
}
