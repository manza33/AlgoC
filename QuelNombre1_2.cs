using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoC
{
    class QuelNombre1_2
    {
        private int nombre;
        private const int NOMBREMIN = 10;
        private const int NOMBREMAX = 20;

        public void trouverNombre()
        {

            do
            {
                Console.WriteLine("Veuillez saisir un nombre");

                string entree = Console.ReadLine();

                if (int.TryParse(entree, out int intEntree))
                {
                    nombre = intEntree;

                    if (nombre > NOMBREMAX)
                    {
                        Console.WriteLine("Nombre trop haut");
                    }
                    else if (nombre < NOMBREMIN)
                    {
                        Console.WriteLine("Nombre trop bas");
                    }

                }
                else
                {
                    Console.WriteLine("Vous n'avez pas saisi un nombre.");
                }

            } while (nombre > NOMBREMAX || nombre < NOMBREMIN);

            Console.WriteLine($"Le nombre choisi : {nombre}");
        }
    }
}
