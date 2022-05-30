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

            Recette rec1 = new Recette("Petit gateau",Modele.Type.Dessert,l,new List<string>() 
            {
                new string("Laisser tremper le pirarucu la veille, le faire frire en morceaux puis le déchiqueter"),
                new string("Préparez une salade avec l'oignon, la tomate, le persil et le poivre, en ajoutant l'huile et le sel au goût."),
                new string("Faire la farofa avec un peu de beurre et la farine de manioc et réserver."),
                new string("Sur un tableau, disposez en couches :"),
                new string("1ère couche : arapaima râpé.2ª camada: farofa."),
                new string("3ème couche : salade."),
                new string("4ème couche : banane frite."),
                new string("5ème couche : paille de pomme de terre."),
                new string("Mettre au four pendant 10 minutes.")
            },Region.Sudest,10,1);
            rec1.Display();
        }
    }
}
