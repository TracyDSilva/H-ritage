using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exo3
{
    class Voiture : Vehicule
    {
        protected bool decapotable;
        protected bool climatisation;

        public Voiture(string immatriculation, int anneeConstruction, string marque, string modele, bool decapotable, bool climatisation):base(immatriculation,anneeConstruction,marque,modele)
        {
            this.decapotable = decapotable;
            this.climatisation = climatisation;
            this.immatriculation = immatriculation;
            this.anneeConstruction = anneeConstruction;
            this.marque = marque;
            this.modele = modele;
        }

        public bool estDecapotable()
        {
            if (decapotable == true)
            {
                Console.Write("Voiture décapotable ");
            }
            else
            {
                Console.Write("Voiture non décapotable ");
            }
            return decapotable;
        }

        public bool estClimatise()
        {
            if (climatisation == true)
            {
                Console.WriteLine("avec climatisation");
            }
            else
            {
                Console.WriteLine("sans climatisation");
            }
            return climatisation;
        }

        public new string ToString()
        {
            base.ToString();
            return string.Format("{0} {1}\nImmatriculation : {2}\nAnnée de construction : {3}\nMarque : {4}\nModèle: {5}\n",estDecapotable(), estClimatise() ,immatriculation, anneeConstruction, marque, modele);
        }
    }
}
