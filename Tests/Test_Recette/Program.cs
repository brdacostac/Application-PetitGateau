using System;
using Modele;
using System.Collections.Generic;

namespace Test_Recette
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test de la classe Recette");
            Console.WriteLine("*************************");

            Ingredient ingred2 = new Ingredient("Farine", new Quantité(55, Unité.G));
            Ingredient ingred3 = new Ingredient("Oeuf", new Quantité(10, Unité.UNITE));
            Ingredient ingred4 = new Ingredient("Chocolat", new Quantité(100, Unité.G));
            Ingredient ingred1 = new Ingredient("Galce", new Quantité(200, Unité.G));

            List<Ingredient> l = new List<Ingredient>() { ingred2, ingred3, ingred4, ingred1 };

           /* Recette rec1 = new Recette("Petit gateau", "un petit gateau de chocolat, chaud accompagné de glace",
                Modele.Type.Dessert, l,Region.Sudest);
            rec1.Display();*/
        }
    }
}
