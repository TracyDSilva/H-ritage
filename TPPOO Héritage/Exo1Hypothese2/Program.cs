using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exo1Hypothese2
{
    class Program
    {
        static void Main(string[] args)
        {
            Lion l1 = new Lion("Simba", "Savanne", "RRRRWAAA", false, 4);
            Chat c1 = new Chat("Nita", "Domicile", "Miaaaou", true, 4);
            Baleine b1 = new Baleine("Moby", "Océan", "MMMMM", false, 500, 1200);

            l1.Afficher();
            c1.Afficher();
            b1.Afficher();
            Console.ReadLine();

        }
    }
}
