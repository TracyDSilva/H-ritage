using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exo3
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicule[] tab = new Vehicule[4];
            tab[0] = new Voiture("333 ABC 06",2000,"Peugeot","306",true,false);
            tab[1] = new Voiture("321 BBD 06", 2001, "Renault", "Clio", false, true);
            tab[2] = new Camion("1234 TZ 06",1993,"DAF","T43", true, 4);
            tab[3] = new Camion("765 ACE 06", 1999, "Mercedes", "C.L", false, 3);

            ////boucle d'affichage
            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i] is Voiture)
                {
                    ((Voiture)tab[i]).estDecapotable();
                    ((Voiture)tab[i]).estClimatise();
                }

                if (tab[i] is Camion)
                {
                    ((Camion)tab[i]).estRemorquable();
                    ((Camion)tab[i]).nbEssieux();
                }
                Console.WriteLine(tab[i].ToString());
            }

            Console.ReadLine();
        }
    }
}
