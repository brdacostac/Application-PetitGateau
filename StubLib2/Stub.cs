using System;
using System.Collections.Generic;
using Modele;

namespace StubLib2
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
           "Placer le tucupí dans une casserole, assaisonner avec l'ail, la chicorée et le sel, porter à ébullition et porter à ébullition",
            "Puis baissez le feu, couvrez la casserole et laissez cuire 30 minutes.",
            "Cuire le jambu dans de l'eau chaude, laisser cuire jusqu'à ce que les tiges soient tendres, retirer et égoutter, réserver. " +
                "Retirez la tête des crevettes et faites-les tremper dans un bol d'eau pour éliminer le sel. Faire bouillir 4 tasses d'eau avec du sel au goût, " +
                "dissoudre la gomme dans un bol d'eau froide, l'ajouter petit à petit à l'eau bouillante, jusqu'à ce qu'elle devienne une bouillie épaisse, ou " +
                "au point de votre préférence.",
            "Servir dans une calebasse dans cet ordre : 2 cuillères à soupe de tucupí, une louche de gomme, une louche de tucupí, quelques feuilles de jambú" +
                " et 5 crevettes, sel et poivre au goût.",
            "Si l'amidon de manioc n'est pas disponible, l'amidon acide peut être utilisé."
        },Region.Nord,60,6, img:"Images/Recettes/amazonie.png"),

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
            "Laisser tremper le pirarucu la veille, le faire frire en morceaux puis le déchiqueter",
            "Préparez une salade avec l'oignon, la tomate, le persil et le poivre, en ajoutant l'huile et le sel au goût.",
            "Faire la farofa avec un peu de beurre et la farine de manioc et réserver.",
            "Sur un tableau, disposez en couches :",
            "1ère couche : arapaima râpé.2ª camada: farofa.",
            "3ème couche : salade.",
            "4ème couche : banane frite.",
            "5ème couche : paille de pomme de terre.",
            "Mettre au four pendant 10 minutes."
        },Region.Nord,50,5, img:"Images/Recettes/casaca.png"),
//************************************************************************************************
            new Recette("Caldeirada de Tambaqui",Modele.Type.Plat,new List<Ingredient>()
        {
            new Ingredient("tambaqui", new Quantité(1, Unité.KG)),
            new Ingredient("tomates sans pépins, coupées", new Quantité(3, Unité.UNITE)),
            new Ingredient("oignon coupés", new Quantité(3, Unité.UNITE)),
            new Ingredient("piments chili, épépinés et coupé", new Quantité(15, Unité.UNITE)),
            new Ingredient("bouquet de persil haché ", new Quantité(1, Unité.UNITE)),
            new Ingredient("botte de ciboulette ciselée", new Quantité(1, Unité.UNITE)),
            new Ingredient("cuillère de Paprika", new Quantité(1, Unité.UNITE)),
            new Ingredient("cuillère d'huile d'olive", new Quantité(1, Unité.UNITE)),
            new Ingredient("cuillère de sel", new Quantité(1, Unité.UNITE)),
            new Ingredient("citron", new Quantité(1, Unité.UNITE))
        },new List<string>()
        {
            "La veille, bien laver le poisson à l'eau froide. Placez-le dans un bol en le baignant de jus de citron (bouillon) et de sel, couvrez le bol et placez-le au réfrigérateur.",
            "Le lendemain, faites tremper le poisson une seule fois dans l'eau pour éliminer l'excès de citron et de sel.",
            "Dans une grande casserole, déposer le poisson, la tomate, l'oignon, le piment et une partie de la coriandre et de la ciboulette.",
            "Ajouter suffisamment d'eau pour couvrir le poisson.",
            "Si l'amidon de manioc n'est pas disponible, l'amidon acide peut être utilisé.",
            "Ajouter l'huile d'olive au goût, 1 cuillère à soupe de vinaigre et le colorant ou la pâte de tomate.",
            "Ajoutez le sel petit à petit, car pendant l'ébullition, le sel contenu dans le poisson se libère dans le bouillon.",
            "Faire bouillir environ 20 minutes.",
            "Après 20 minutes, éteignez le feu, ajoutez le reste de la coriandre et de la ciboulette et servez immédiatement.",
            "Ce ragoût peut être accompagné de riz blanc."
        },Region.Nord,30,4, img:"Images/Recettes/tambaqui.png"),
//************************************************************************************************
            new Recette("Gâteau arapaïma",Modele.Type.Entree,new List<Ingredient    >()
        {
            new Ingredient("pirarucu, déssalé, néttoyé et râpé", new Quantité(400, Unité.G)),
            new Ingredient("cuillère de soupe d'huile d'olive", new Quantité(3, Unité.UNITE)),
            new Ingredient("gousses d'ail hachées", new Quantité(2, Unité.UNITE)),
            new Ingredient("oignon hachées", new Quantité(1, Unité.UNITE)),
            new Ingredient("pincé de sel ", new Quantité(1, Unité.UNITE)),
            new Ingredient("Poivre noir", new Quantité(50, Unité.G)),
            new Ingredient("cuillères à soupe de persil haché", new Quantité(2, Unité.UNITE)),
            new Ingredient("cuillères à soupe de coriandre hachée", new Quantité(2, Unité.UNITE)),
            new Ingredient("pommes de terre", new Quantité(500, Unité.G)),
            new Ingredient("oeuf", new Quantité(1, Unité.UNITE)),
            new Ingredient("tasses (thé) d'huile", new Quantité(3, Unité.UNITE))
        },new List<string>()
        {
            "Dessalez l'arapaima en le laissant macérer 1 jour au réfrigérateur et en changeant l'eau au moins 3 fois",
            "Démêler et mettre de côté.",
            "Dans une poêle, chauffer l'huile et faire revenir l'ail, l'oignon, le sel, le poivre, le persil et la coriandre",
            "Bien mélanger, ajouter l'arapaima et faire sauter..",
            "Faites cuire les pommes de terre et écrasez-les.",
            "Ajouter les pommes de terre pressées et l'œuf à l'arapaima braisé et mélanger jusqu'à l'obtention d'une masse homogène.",
            "Ajustez le sel",
            "Faites des boulettes avec vos mains, faites-les frire dans l'huile chaude jusqu'à ce qu'elles soient dorées.",
            "Égoutter sur du papier absorbant et servir chaud."
        },Region.Nord,50,5, img:"Images/Recettes/araipama.png"),
//************************************************************************************************
            new Recette("Salade d'île de marajo",Modele.Type.Entree,new List<Ingredient    >()
        {
            new Ingredient("Feuilles de laitue de 1 pied, coupées en lanières", new Quantité(3, Unité.UNITE)),
            new Ingredient("petites tomates, coupées en tranches", new Quantité(2, Unité.UNITE)),
            new Ingredient("blanc de dinde, en cubes", new Quantité(150, Unité.G)),
            new Ingredient("branches de céleri, hachées", new Quantité(4, Unité.UNITE)),
            new Ingredient("manchon moyen, en cales", new Quantité(1, Unité.UNITE)),
            new Ingredient("tasse (thé) de noix du Brésil hachées", new Quantité(0.5, Unité.UNITE)),
            new Ingredient("unités moyennes de mozzarella de bufflonne, en tranches", new Quantité(8, Unité.UNITE)),
            new Ingredient("tasse (thé) de mayonnaise", new Quantité(1, Unité.UNITE)),
            new Ingredient("cuillère à soupe de moutarde", new Quantité(1, Unité.UNITE)),
            new Ingredient("cuillère (soupe) de ketchup", new Quantité(1, Unité.UNITE)),
            new Ingredient("vinaigre de vin blanc", new Quantité(20, Unité.ML)),
            new Ingredient("sachets d'assaisonnement pour salade ", new Quantité(2, Unité.ML))
        },new List<string>()
        {
            "Dans un grand saladier, disposer les feuilles de laitue, les tranches de tomate, " +
            "la poitrine de dinde, le céleri, la mangue, les noix du Brésil et la mozzarella de bufflonne",
            "Préparez la sauce : dans un petit bol, placez la mayonnaise, la moutarde, le ketchup, " +
            "le vinaigre et l'Assaisonnement SAZÓN® et mélangez",
            "Servir la salade avec la vinaigrette.",
        },Region.Nord,20,2, img:"Images/Recettes/marajo.png"),
//************************************************************************************************

            new Recette("Salade d'île de marajo",Modele.Type.Dessert,new List<Ingredient>()
        {
            new Ingredient("Type de fromage Queijo do Norte ou Beurre", new Quantité(200, Unité.G)),
            new Ingredient("Banane", new Quantité(3, Unité.UNITE)),
            new Ingredient("Du sucre", new Quantité(100, Unité.G)),
            new Ingredient("Poudre de cannelle", new Quantité(100, Unité.G)),
            new Ingredient("", new Quantité(3, Unité.UNITE)),
            
        },new List<string>()
        {
            "Coupez la banane en deux dans le sens de la longueur, faites-la revenir dans du beurre et réservez.",
            "Coupez le fromage en tranches généreuses de 1,5 cm d'épaisseur et faites revenir jusqu'à ce qu'il soit presque entièrement fondu.",
            "Dans une casserole, mélanger le sucre et la cannelle à votre goût (brun)",
            "Placer les deux tranches de banane froide dans une assiette, le fromage presque fondu sur la banane, puis " +
            "recouvrir le tout avec le sucre et la cannelle.",
            "Le plat doit être assemblé avec la banane et le fromage encore chauds.",
            "Consommez de préférence tout de suite.",
        },Region.Nord,10,1, img:"Images/Recettes/cartola.png"),
        };


        IEnumerable<Recette> IPersistanceManager.LoadRecettes()
        {
            return recettes;
        }
    }
}