using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoC
{
    class CourseChevaux2
    {

        public Dictionary<string,int> initialiserJeux()
        {
            var listJeux = new Dictionary<string, int>();
            int intEntree = -1;

            do
            {
                Console.WriteLine("Veuillez saisir un nombre de chevaux partants");
                string entree = Console.ReadLine();

                if (int.TryParse(entree, out intEntree))
                {                     
                    listJeux.Add("nbPartant", intEntree);
                }
                else
                {
                    Console.WriteLine("Vous n'avez pas saisi un nombre.");
                }
            } while (intEntree <= 0);

            intEntree = -1;

            do
            {
                Console.WriteLine("Veuillez saisir un nombre de chevaux joués");
                string entree = Console.ReadLine();

                if (int.TryParse(entree, out intEntree))
                {
                    listJeux.Add("nbJoue", intEntree);
                }
                else
                {
                    Console.WriteLine("Vous n'avez pas saisi un nombre.");
                }
            } while (intEntree <= 0);

            listJeux.Add("nbPartantMoinsJoue", listJeux["nbPartant"] - listJeux["nbJoue"]);

            //Console.WriteLine($"{listJeux["nbPartant"]} - {listJeux["nbJoue"]} = {listJeux["nbPartantMoinsJoue"]}");
            return listJeux;
        }

        public int calculerFactorielle(int Valeur)
        {
            int result;

                result = 1;
                for (int i = 0; i < Valeur ; i++)
                {
                    result *= i + 1;
                }
            
            //Console.WriteLine($"{result}");
            return result;
        }

        public void calculerProba(Dictionary<string, int> listValeurs)
        {
            int nbPartant = this.calculerFactorielle(listValeurs["nbPartant"]);
            int nbJoue = this.calculerFactorielle(listValeurs["nbJoue"]);
            int nbPartantMoinsJoue = this.calculerFactorielle(listValeurs["nbPartantMoinsJoue"]);
            
            Console.WriteLine($"Dans l'ordre : une chance sur { nbPartant / nbJoue }.");
            Console.WriteLine($"Dans le désordre : une chance sur { nbPartant / (nbPartantMoinsJoue * nbJoue) }.");
        }

    }
}
