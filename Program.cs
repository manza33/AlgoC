﻿using System;
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
            TriangleXo triangleXo = new TriangleXo(8);
            triangleXo.dessineTriangle();

            Console.WriteLine("");
            Console.WriteLine("***********************");
            Console.WriteLine("");

            TriangleReverse triangleReverse = new TriangleReverse(9);
            triangleReverse.dessineTriangleReverse();
            
        }
    }
}
