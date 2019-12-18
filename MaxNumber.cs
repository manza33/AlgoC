using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoC
{
    class MaxNumber
    {
        private const int SEUIL = 5;
        private int number;
        private int maxNumber = 0;
        private int count = 0;
        private int maxIndice;

        public void findMaxNumber()
        {

            do
            {
                Console.WriteLine("Veuillez saisir un nombre");
                string entree = Console.ReadLine();

                if (int.TryParse(entree, out int intEntree))
                {
                    number = int.Parse(entree);

                    if (number > maxNumber)
                    {
                        maxNumber = number;
                    }
                }
                else
                {
                    Console.WriteLine("Vous n'avez pas saisi un nombre.");
                }
                                               
                count++;

            } while (count < SEUIL);
            Console.WriteLine($"Nombre Max : {maxNumber}");
        }

        public void findMaxNumberStop()
        {


            int numberIndice = 0;
            number = -1;

            do
            {              

                Console.WriteLine("Veuillez saisir un nombre");
                string entree = Console.ReadLine();

                if (int.TryParse(entree, out int intEntree))
                {
                    number = int.Parse(entree);

                    if (number > maxNumber)
                    {

                        maxNumber = number;
                        maxIndice = numberIndice;

                    }

                    numberIndice++;

                }
                else
                {
                    Console.WriteLine("Vous n'avez pas saisi un nombre.");
                }


            } while (number != 0);

            Console.WriteLine($"Nombre Max : {maxNumber}");
            Console.WriteLine($"Indice Max : {maxIndice}");

        }

    }
}
