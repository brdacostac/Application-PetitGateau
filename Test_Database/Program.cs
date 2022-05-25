using System;
using Modele;
using System.Collections.Generic;

namespace Test_Database
{
    class Program
    {
        static void Main(string[] args)
        {
            Compte c1 = new Compte("botuser1", "password", 'h');
            Compte c2 = new Compte("botuser2", "password", 'h');
            Compte c3 = new Compte("botuser3", "password", 'f');
            Compte c4 = new Compte("botuser4", "password", 'f');
            List<Compte> comptes = new List<Compte>() { c1, c2, c3, c4 };

            Ingredient ingred2 = new Ingredient("Farine", new Quantité(55, Unité.G));
            Ingredient ingred3 = new Ingredient("Oeuf", new Quantité(10, Unité.UNITE));
            Ingredient ingred4 = new Ingredient("Chocolat", new Quantité(100, Unité.G));
            Ingredient ingred1 = new Ingredient("Galce", new Quantité(200, Unité.G));

            List<Ingredient> l = new List<Ingredient>() { ingred2, ingred3, ingred4, ingred1 };

            Recette rec1 = new Recette("Petit gateau", "un petit gateau de chocolat, chaud accompagné de glace", Modele.Type.Dessert, l, Region.Sudest);
            Recette rec2 = new Recette("Petit gateau", "un petit gateau de chocolat, chaud accompagné de glace", Modele.Type.Dessert, l, Region.Sudest);
            Recette rec3 = new Recette("Petit gateau", "un petit gateau de chocolat, chaud accompagné de glace", Modele.Type.Dessert, l, Region.Sudest);
            List<Recette> recettes  = new List<Recette>() { rec1, rec2, rec3 };


            Console.WriteLine("Teste database");
            Database db = new Database(comptes, recettes);

            foreach(Recette r in db.Recettes)
            {
                r.Display();
            }

            foreach(Compte c in db.Comptes)
            {
                Console.WriteLine(c);
            }
        }
    }
}
