using System;
using Modele;

namespace Test_Ingredient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test de la classe Ingredient");
            Console.WriteLine("****************************");

            Ingredient ingred1 = new Ingredient("viande", new Quantité(1, Unité.KG));
            Console.WriteLine(ingred1);
        }
    }
}
