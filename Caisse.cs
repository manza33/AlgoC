using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoC
{
    class Caisse
    {
        private int prixSaisi;
        private int somme;
        private int monnaieEncaissée;
        private int reste;

        /*Dictionary<string, int> listBillets = new Dictionary<string, int>()
        {
            {"billetDix", 10},
            {"billetCinq", 5},
            {"billetUn", 1}                                
        };*/

        private int[] listBillets = new int[3] { 10, 5, 1 };

        public int calculerSomme()
        {
            somme = 0;
            prixSaisi = -1;
            do
            {
                Console.WriteLine("Veuillez saisir le prix du produit");
                string entree = Console.ReadLine();

                if (int.TryParse(entree, out int intEntree))
                {
                    prixSaisi = intEntree;
                    somme = somme + prixSaisi;
                }
                else
                {
                    Console.WriteLine("Vous n'avez pas saisi un nombre.");
                }

            } while (prixSaisi != 0);

            return somme;
        }

        public int encaisser()
        {

            Console.WriteLine("Veuillez me saisir la monnaie encaissée");
            string entree = Console.ReadLine();

            if (int.TryParse(entree, out int intEntree))
            {
                monnaieEncaissée = intEntree;
            }
            else
            {
                Console.WriteLine("Vous n'avez pas saisi un nombre.");
            }

            while (monnaieEncaissée < somme)
            {
                Console.WriteLine("La monnaie n'est pas suffisante.");
                Console.WriteLine("Veuillez me saisir la monnaie encaissée");
                entree = Console.ReadLine();


                if (int.TryParse(entree, out intEntree))
                {
                    monnaieEncaissée = intEntree;
                }
                else
                {
                    Console.WriteLine("Vous n'avez pas saisi un nombre.");
                }
            }

            return monnaieEncaissée;
        }

        public void rendreMonnaie()
        {
            //int billet;

            if (monnaieEncaissée > somme)
            {
                reste = monnaieEncaissée - somme;

                Console.WriteLine($"monnaie a rendre : {reste}");
                Console.WriteLine($"Taille listBillet : {listBillets.Length}");

                //for (int i = 0; i < listBillets.Length; i++)
                foreach (int billet in listBillets)
                {

                    //    billet = listBillets[i];      

                    while (reste >= billet)
                    {
                        Console.WriteLine($"{billet} {this.afficheEuro(billet)}");
                        reste = reste - billet;
                    }
                }
            }
            else
            {
                Console.WriteLine("Pas de monnaie à rendre");
            }
        }

        public string afficheEuro(int billet)
        {
            if (billet > 1)
            {
                return "Euros";
            }
            return "Euro";
        }
    }
}

