using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            //CHEVAUX2 (11)
            
            CourseChevaux2 course = new CourseChevaux2();
            Dictionary<string, int> list = course.initialiserJeux();
            course.calculerProba(list);
            

            //CHEVAUX (11)
            /*
            CourseChevaux course = new CourseChevaux();
            List<int> list = course.initialiserJeux();
            List<int> listFactorielle = course.calculerFactorielle(list);
            course.calculerProba(listFactorielle);
            */

            //MAX NUMBER STOP (9)
            /*
            MaxNumber maxNumber = new MaxNumber();
            maxNumber.findMaxNumberStop();
            */

            // MAX NUMBER (8)
            /*
            MaxNumber maxNumber = new MaxNumber();
            maxNumber.findMaxNumber();
            */

            //OPERATIONS (6 et 7)
            /*
            Operation operation = new Operation();
            operation.additionner();
            operation.calculerFactorielle();
            */

            //PLUS DIX (3)
            /*
            NombrePlusDix nombrePlusDix = new NombrePlusDix();
            nombrePlusDix.ajouterDix();
            */

            //QUEL NOMBRE? (2)
            /*
            QuelNombre1_2 quelNombre1_2 = new QuelNombre1_2();
            quelNombre1_2.trouverNombre();
            */

            //MULTIPLICATION NOMBRE (5)
            /*
            TableMulti tableMulti = new TableMulti();
            tableMulti.calculerTable();
            */

            // CAISSE (10)
            
            Caisse maCaisse = new Caisse();
            Console.WriteLine($"Total : { maCaisse.calculerSomme()}");
            Console.WriteLine($"Encaissement : { maCaisse.encaisser()}");
            maCaisse.rendreMonnaie();
            

            /*
            // TRIANGLES
            TriangleXo triangleXo = new TriangleXo(8);
            triangleXo.dessineTriangle();

            Console.WriteLine("");
            Console.WriteLine("***********************");
            Console.WriteLine("");

            TriangleReverse triangleReverse = new TriangleReverse(9);
            triangleReverse.dessineTriangleReverse();
            //**************************************************************************
            */
        }
    }
}
