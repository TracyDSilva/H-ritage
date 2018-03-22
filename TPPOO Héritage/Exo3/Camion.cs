using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exo3
{
    class Camion : Vehicule
    {
        protected bool remorque;
        protected int essieux;

        public Camion(string immatriculation, int anneeConstruction, string marque, string modele, bool remorque, int essieux)
            :base(immatriculation,anneeConstruction,marque,modele)
        {
            this.remorque = remorque;
            this.essieux = essieux;
            this.immatriculation = immatriculation;
            this.anneeConstruction = anneeConstruction;
            this.marque = marque;
            this.modele = modele;
        }

        public bool estRemorquable()
        {
            if (remorque == true)
            {
                Console.Write("Camion semi-remorque ");
            }
            else
            {
                Console.Write("Camion non semi-remorque ");
            }
            return remorque;
        }
        public int nbEssieux()
        {
            Console.WriteLine("avec {0} essieux", essieux);
            return essieux;
        }

        public new string ToString()
        {
            base.ToString();
            return string.Format("{0} {1}\nImmatriculation : {2}\nAnnée de construction : {3}\nMarque : {4}\nModèle: {5}\n", estRemorquable(), nbEssieux(), immatriculation, anneeConstruction, marque, modele);
        }
    }
}
