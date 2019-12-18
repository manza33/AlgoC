using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoC
{
    class TableMulti
    {

        private int nombre;

        public void calculerTable()
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

            for (int multiplier = 1; multiplier <= nombre; multiplier++)
            {
                Console.WriteLine($"{nombre} x {multiplier} = {nombre * multiplier}");
            }

        }

    }
}
