using Modele;

namespace StubLib
{
    public class Stub : IPersistanceManager
    {
        List<Recette> recettes = new List<Recette>()
        {
           new Recette("Tacaca d'Amazonie",Modele.Type.Plat,new List<Ingredient>()
        {
            new Ingredient("tucupi", new Quantité(2, Unité.L)),
            new Ingredient("gousses d'ail", new Quantité(4, Unité.UNITE)),
            new Ingredient("poivres", new Quantité(4, Unité.UNITE)),
            new Ingredient("paquets de jambu", new Quantité(2, Unité.UNITE)),
            new Ingredient("crevettes salées", new Quantité(0.5, Unité.KG)),
            new Ingredient("tasse d'amidon de manioc", new Quantité(0.5, Unité.KG)),
            new Ingredient("cuillère de sel", new Quantité(1, Unité.UNITE))
        },new List<string>()
        {
            new string("Placer le tucupí dans une casserole, assaisonner avec l'ail, la chicorée et le sel, porter à ébullition et porter à ébullition"),
            new string("Puis baissez le feu, couvrez la casserole et laissez cuire 30 minutes."),
            new string("Cuire le jambu dans de l'eau chaude, laisser cuire jusqu'à ce que les tiges soient tendres, retirer et égoutter, réserver. " +
                "Retirez la tête des crevettes et faites-les tremper dans un bol d'eau pour éliminer le sel. Faire bouillir 4 tasses d'eau avec du sel au goût, " +
                "dissoudre la gomme dans un bol d'eau froide, l'ajouter petit à petit à l'eau bouillante, jusqu'à ce qu'elle devienne une bouillie épaisse, ou " +
                "au point de votre préférence."),
            new string("Servir dans une calebasse dans cet ordre : 2 cuillères à soupe de tucupí, une louche de gomme, une louche de tucupí, quelques feuilles de jambú" +
                " et 5 crevettes, sel et poivre au goût."),
            new string("Si l'amidon de manioc n'est pas disponible, l'amidon acide peut être utilisé.")
        },Region.Nord,60,6),

           new Recette("Pirarucu de casaca",Modele.Type.Plat,new List<Ingredient>()
        {
            new Ingredient("d'arapaïma salé et séché", new Quantité(1, Unité.KG)),
            new Ingredient("d'huile d'olive", new Quantité(30, Unité.ML)),
            new Ingredient("tomates sans peau ni pépins, hachées", new Quantité(2, Unité.UNITE)),
            new Ingredient("oignons hachés", new Quantité(2, Unité.UNITE)),
            new Ingredient("Odeur verte", new Quantité(1, Unité.UNITE)),
            new Ingredient("Poivre parfumé au goût", new Quantité(1, Unité.UNITE)),
            new Ingredient("paquet de paille de pomme de terre", new Quantité(1, Unité.UNITE)),
            new Ingredient("Plantains frits", new Quantité(1, Unité.UNITE)),
            new Ingredient("Farine de manioc", new Quantité(100, Unité.G)),
            new Ingredient("Lait de coco", new Quantité(200, Unité.ML))
        },new List<string>()
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
        },Region.Nord,50,5)
        };

        public IEnumerable<Recette> LoadRecettes()
        {
            return recettes;
        }
    }
}