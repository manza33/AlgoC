using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoC
{
    class Operation
    {
        
        public void additionner()
        {
            int result = 0;
            int number = -1;

            do
            {
                Console.WriteLine("Veuillez saisir un nombre");
                string entree = Console.ReadLine();

                if (int.TryParse(entree, out int intEntree))
                {
                    number = intEntree;

                }
                else
                {
                    Console.WriteLine("Vous n'avez pas saisi un nombre.");
                }
            } while (number <= 0);

            Console.WriteLine("Addition");

            for( int i = 1; i <= number; i++ )
            {
                result += i;
            }
            Console.WriteLine($"Resultat : {result}");
        }

        public void calculerFactorielle()
        {
            int result = 1;
            int number = -1;

            do
            {
                Console.WriteLine("Veuillez saisir un nombre");
                string entree = Console.ReadLine();

                if (int.TryParse(entree, out int intEntree))
                {
                    number = intEntree;

                }
                else
                {
                    Console.WriteLine("Vous n'avez pas saisi un nombre.");
                }
            } while (number <= 0);

            Console.WriteLine("Factorielle");

            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }
            Console.WriteLine($"Resultat : {result}");
        }
    }
}
