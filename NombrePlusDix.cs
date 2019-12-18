using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoC
{
    class NombrePlusDix
    {
        private int nombre;

        public void ajouterDix()
        {
            do
            {
                Console.WriteLine("Veuillez saisir un nombre");
                string entree = Console.ReadLine();

                if (int.TryParse(entree, out int intEntree))
                {
                    nombre = intEntree;

                }
                else
                {
                    Console.WriteLine("Vous n'avez pas saisi un nombre.");
                }


            } while (nombre <= 0);

             for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(nombre = nombre + 1);
            }
        }
    }
}

