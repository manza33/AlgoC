using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoC
{
    class TriangleXo
    {
        private int nbLignes;
        public TriangleXo(int nbLignes)
        {
            this.nbLignes = nbLignes;
            Console.WriteLine("Triangle XO : ");
        }

        public void dessineTriangle()
        {
            for (int ligne = 1; ligne <= nbLignes; ligne++)
            {
                for (int colonne = 1; colonne <= ligne; colonne++)
                {
                    if (ligne == nbLignes || colonne == 1 || colonne == ligne)
                    {
                        Console.Write("X");
                    }
                    else
                    {
                        Console.Write("O");
                    }
                }
                Console.WriteLine("");
            }
        }
    }

    class TriangleReverse
    {
        private int nbLignes;

        public TriangleReverse ( int nbLignes)
        {
            this.nbLignes = nbLignes;
            Console.WriteLine("Triangle Reverse : ");
        }

        public void dessineTriangleReverse ()
        {
            for (int ligne = 0; ligne <= nbLignes; ligne++)
            {
                //Console.WriteLine("ligne : " + ligne);
                for (int colonne = 0; colonne <= nbLignes; colonne++)
                {
                    
                    if (colonne < ligne)
                    {
                        Console.Write(" ");
                    } else
                    {
                        Console.Write(ligne);
                    }
                }
                Console.WriteLine("");
            }
        }
    }

}
