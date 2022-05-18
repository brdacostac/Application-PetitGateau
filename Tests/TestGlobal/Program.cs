using System;
using System.Collections.Generic;
using Modele;

namespace TestGlobal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test des classes reliées a une Recette");
            Console.WriteLine("**************************************");

            Ingredient ingred2 = new Ingredient("farine", new Quantité(55, Unité.G));
            Ingredient ingred3 = new Ingredient("oeuf", new Quantité(10, Unité.UNITE));
            Ingredient ingred4 = new Ingredient("chocolat", new Quantité(100, Unité.G));

            List<Ingredient> l = new List<Ingredient>() { ingred1, ingred2, ingred3, ingred4};

            Recette rec1 = new Recette("Petit gateau", "un petit gateau de chocolat, chaud accompagné de glace", 
                ClassesRecettes.Type.Dessert, l);
            rec1.Display();
        }
    }
}
