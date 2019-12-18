using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoC
{
    class CourseChevaux
    {
        public List<int> initialiserJeux()
        {
            var listJeux = new List<int>();

            Console.WriteLine("Veuillez saisir un nombre de chevaux partants");
            string entree = Console.ReadLine();

            if (entree != "")
            {
                listJeux.Add(int.Parse(entree));                
            }

            Console.WriteLine("Veuillez saisir un nombre de chevaux joué");
            entree = Console.ReadLine();

            if (entree != "")
            {
                listJeux.Add(int.Parse(entree));
            }

            listJeux.Add(listJeux[0] - listJeux[1]);

            Console.WriteLine($"{listJeux[0]} - {listJeux[1]} = {listJeux[2]}");
            return listJeux;
        }

        public List<int> calculerFactorielle(List<int> listValeurs)
        {
            int result;
           
            for (int listCase = 0; listCase < listValeurs.Count; listCase++) 
            {
                result = 1;
                for( int i = 0; i < listValeurs[listCase] ; i++)
                {
                    result *= i + 1;                    
                }
                listValeurs[listCase] = result;
            }
            Console.WriteLine($"{listValeurs[0]} - {listValeurs[1]} - {listValeurs[2]}");
            return listValeurs;
        }

        public void calculerProba(List<int> listValeurs)
        {
            Console.WriteLine($"Dans l'ordre : une chance sur { listValeurs[0] / listValeurs[2] }.");
            Console.WriteLine($"Dans le désordre : une chance sur { listValeurs[0] / ( listValeurs[1] * listValeurs[2])}.");
        }
        
    }
}
