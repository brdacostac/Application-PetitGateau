using System;
using Modele;

namespace Test_Unité
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test de la classe Unité");
            Console.WriteLine("***********************");

            Quantité qtest = new Quantité(32, Unité.KG);
            Console.WriteLine(qtest);
        }
    }
}
