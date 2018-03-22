using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exo1Hypothese1
{
    class Program
    {
        static void Main(string[] args)
        {
            Lion l1 = new Lion("Mufasa", "Savanne", "RRR", true, 4);
            Chat c1 = new Chat("Potté", "Forêt", "Miaou", false, 4);
            Baleine b1 = new Baleine("Moby Dick", "Océan", "MMMMMMMM", false, 900, 1000);

            //l1.Afficher();
            //c1.Afficher();
            //b1.Afficher();

            //l1.JeSuisDangereux();
            //c1.JesuisDangereux();
            //b1.JeSuisDangereux();


            Console.WriteLine("Quel type animal voulez vous adopter ?");
            int choix;
            Console.WriteLine("1) Félin");
            Console.WriteLine("2) Cétacé");
            choix = Convert.ToInt32(Console.ReadLine());
            switch (choix)
            {
                case 1:
                    int choix2;
                    Console.WriteLine("1. Chat");
                    Console.WriteLine("2. Lion");
                    choix2 = Convert.ToInt32(Console.ReadLine());
                    switch (choix2)
                    {
                        case 1:
                                if (c1.JesuisDangereux() == false)
                                {
                                    Console.WriteLine("Vous ne pouvez pas adopter cet animal.");
                                }
                                else
                                {
                                    Console.WriteLine("Vous pouvez adopter cet animal.");
                                }
                            break;

                        case 2:
                            if (l1.JeSuisDangereux() == true)
                            {
                                Console.WriteLine("Vous ne pouvez pas adopter cet animal.");
                            }
                            else
                            {
                                Console.WriteLine("Vous pouvez adopter cet animal.");
                            }
                            break;
                        default:
                            break;
                    }
                    break;
                case 2:
                    int choix3;
                    Console.WriteLine("1. Baleine");
                    choix3 = Convert.ToInt32(Console.ReadLine());
                    switch (choix3)
                    {
                        case 1:
                                if (b1.JeSuisDangereux() == false)
                                {
                                    Console.WriteLine("Vous ne pouvez pas adopter cet animal.");
                                }
                                else
                                {
                                    Console.WriteLine("Vous pouvez adopter cet animal.");
                                }
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;

                    
            }
            Console.ReadLine();
        }

    }
}