using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exo3
{
    class Vehicule
    {
        protected string immatriculation;
        protected int anneeConstruction;
        protected string marque;
        protected string modele;

        public Vehicule(string immatriculation, int anneeConstruction, string marque, string modele)
        {
            this.immatriculation = immatriculation;
            this.anneeConstruction = anneeConstruction;
            this.marque = marque;
            this.modele = modele;
        }

        public new string ToString()
        {
            return string.Format("Immatriculation : {0}\nAnnée de construction : {1}\nMarque : {2}\nModèle: {3}\n", immatriculation,anneeConstruction,marque,modele);
        }


    }
}
