# Heritage #

Ce TP regroupe plusieurs exercices qui utilisent la notion d'héritage en Programmation Orientée Objet.

Extrait du code de la classe Mammifère:

class Mammifere
    {
        protected string nom;
        protected string LieuHabitation;
        protected string monCri;
        protected bool jeSuisDomestique;
        protected bool dangereux;

        public Mammifere(string nom, string LieuHabitation, string monCri, bool jeSuisDomestique)
        {
            this.nom = nom;
            this.LieuHabitation = LieuHabitation;
            this.monCri = monCri;
            this.jeSuisDomestique = jeSuisDomestique;
            
        }

        public bool JeSuisDangereux()
        {
            return true;
        }
    }
    
Extrait du code de la classe Félin:

class Felin:Mammifere
    {
        protected int nombrePattes;

        public Felin(string nom, string LieuHabitation, string monCri, bool jeSuisDomestique, int nombrePattes):base(nom,LieuHabitation,monCri,jeSuisDomestique)
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
    
Extrait du code de la classe Chat:

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

Voici le main du program.cs:
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
        
On peut noter que la classe Felin hérite de la classe Mammifere et que la classe Chat hérite de la classe Felin.

Voici ce que l'on peut observer : 

![HERITAGE1.png](https://github.com/TracyDSilva/Heritage/blob/master/HERITAGE1.PNG)

![HERITAGE2.png](https://github.com/TracyDSilva/Heritage/blob/master/HERITAGE2.PNG)

![HERITAGE3.png](https://github.com/TracyDSilva/Heritage/blob/master/HERITAGE3.PNG)
