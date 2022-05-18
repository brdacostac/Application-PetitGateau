using System;
using Modele;

namespace Test_Quantité
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test de la classe Quantité");
            Console.WriteLine("**************************");

            Quantité qtest = new Quantité(32, Unité.KG);
            Console.WriteLine(qtest);
        }
    }
}
