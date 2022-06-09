using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        },Region.Nord,60,6, img:"Images/Recettes/amazonie.jpg"),
//************************************************************************************************
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
        },Region.Nord,50,5, img:"Images/Recettes/casaca.jpg"),
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
        },Region.Nord,30,4, img:"Images/Recettes/tambaqui.jpg"),
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
        },Region.Nord,50,5, img:"Images/Recettes/araipama.jpg"),
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
            "Servir la salade avec la vinaigrette."
        },Region.Nord,20,2, img:"Images/Recettes/marajo.jpg"),
//************************************************************************************************

            new Recette("Cartola",Modele.Type.Dessert,new List<Ingredient>()
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
            "Consommez de préférence tout de suite."
        },Region.Nord,10,1, img:"Images/Recettes/cartola.jpg"),
//************************************************************************************************

            new Recette("Gâteau Macaxeira",Modele.Type.Dessert,new List<Ingredient>()
        {
            new Ingredient("assiettes creuses de manioc cru grossièrement râpé", new Quantité(2, Unité.UNITE)),
            new Ingredient("boîte de lait concentré", new Quantité(1, Unité.UNITE)),
            new Ingredient("œufs entiers", new Quantité(2, Unité.UNITE)),
            new Ingredient("tasse (thé) de margarine fondue", new Quantité(0.5, Unité.UNITE)),
            new Ingredient("cuillère à soupe de levure chimique", new Quantité(1, Unité.UNITE)),
            new Ingredient("noix de coco fraîchement râpée", new Quantité(100, Unité.G)),
            new Ingredient("tasses de (thé) sucre", new Quantité(3, Unité.UNITE)),
            new Ingredient("tasses de (thé) d'eau", new Quantité(1, Unité.UNITE)),

        },new List<string>()
        {
            "Bien mélanger les 4 premiers ingrédients, ajouter la levure et la noix de coco fraîche.",
            "Placer sur une plaque à pâtisserie graissée et farinée.",
            "Portez-le au four moyen, préchauffé, pendant environ 40 minutes.",
            "Pour le sirop, porter les 2 ingrédients à feu doux, quand ça bout, remuer un peu et laisser sur le feu encore 2 minutes.",
            "Le gâteau encore chaud, versez le sirop dessus et remettez le gâteau au four encore 10 minutes."
        },Region.Nord,80,5, img:"Images/Recettes/macaxeira.jpg"),
//************************************************************************************************

            new Recette("Panelada piauense",Modele.Type.Plat,new List<Ingredient>()
        {
            new Ingredient("tripes", new Quantité(1, Unité.KG)),
            new Ingredient("nerfs", new Quantité(1, Unité.KG)),
            new Ingredient("poivre moyen", new Quantité(1, Unité.UNITE)),
            new Ingredient("oignons moyens, hachés", new Quantité(2, Unité.UNITE)),
            new Ingredient("tomates au goût", new Quantité(2, Unité.UNITE)),
            new Ingredient("poivre et sel", new Quantité(100, Unité.G)),
            new Ingredient("sabots de boeuf", new Quantité(6, Unité.UNITE)),
            new Ingredient("gousses d'ail, hachées ou écrasées", new Quantité(4, Unité.UNITE)),
            new Ingredient("feuilles de laurier", new Quantité(10, Unité.UNITE)),
            new Ingredient("citron", new Quantité(2, Unité.UNITE)),

        },new List<string>()
        {
            "Mélangez les tripes, les tripes et les pieds de boeuf et faites bouillir 15 minutes avec le jus de 2 citrons.",
            "Ajouter les assaisonnements et mélanger avec les tripes, les tripes et les pieds.",
            "Cuire pendant 2 heures et vérifier toutes les 30 minutes pour voir ce que vous aimez."
        },Region.Nordest,135,10, img:"Images/Recettes/piauense.jpg"),
//************************************************************************************************

            new Recette("Moqueca aux crevettes",Modele.Type.Plat,new List<Ingredient>()
        {
            new Ingredient("crevettes moyennes", new Quantité(0.5, Unité.KG)),
            new Ingredient("jus de citron", new Quantité(100, Unité.ML)),
            new Ingredient("tasse de café à l'huile de palme", new Quantité(0.5, Unité.UNITE)),
            new Ingredient("oignons moyens, coupés en rondelles", new Quantité(2, Unité.UNITE)),
            new Ingredient("tasse de thé à la coriandre", new Quantité(0.5, Unité.UNITE)),
            new Ingredient("tasse de persil haché", new Quantité(0.5, Unité.UNITE)),
            new Ingredient("oignons verts hachés", new Quantité(2, Unité.UNITE)),
            new Ingredient("tomates coupées en tranches", new Quantité(3, Unité.UNITE)),
            new Ingredient("Sel", new Quantité(10, Unité.G)),
            new Ingredient("verre de lait de coco", new Quantité(1, Unité.UNITE)),

        },new List<string>()
        {
            "Nettoyez les crevettes et assaisonnez avec du sel et du jus de citron.",
            "Réservez",
            "Faire revenir tous les assaisonnements pendant 15 minutes dans l'huile de palme.",
            "Ajouter les crevettes et cuire 5 minutes avec la poêle couverte",
            "Enfin, ajoutez le lait de coco",
            "Servir avec du riz blanc"
        },Region.Nordest,20,2, img:"Images/Recettes/crevettes.jpg"),
//************************************************************************************************

            new Recette("Caruru",Modele.Type.Plat,new List<Ingredient>()
        {
            new Ingredient("gombo coupé en forme de croix", new Quantité(1, Unité.KG)),
            new Ingredient("oignon râpé", new Quantité(1, Unité.UNITE)),
            new Ingredient("gousses d'ail", new Quantité(2, Unité.UNITE)),
            new Ingredient("gingebre râpé", new Quantité(100, Unité.G)),
            new Ingredient("crevettes séchées moulues", new Quantité(0.5, Unité.KG)),
            new Ingredient("noix de cajou moulues", new Quantité(200, Unité.G)),
            new Ingredient("tasse de thé à l'huile de palme", new Quantité(1, Unité.UNITE)),
            new Ingredient("jus de citron", new Quantité(1, Unité.L)),
            new Ingredient("Eau chaude", new Quantité(200, Unité.ML)),

        },new List<string>()
        {
            "Faites chauffer l'huile de palme dans une poêle et faites revenir l'oignon et l'ail.",
            "Ajoutez ensuite le gingembre râpé.",
            "Ajoutez le gombo et laissez-le sauter.",
            "Ajouter les crevettes séchées, les marrons et laisser cuire un peu plus longtemps",
            "Ajouter suffisamment d'eau chaude pour couvrir.",
            "Pendant la cuisson, testez la bave de gombo et ajoutez, petit à petit, des cuillerées de jus de citron",
            "Laissez cuire jusqu'à ce que les graines deviennent roses",
        },Region.Nordest,80,5, img:"Images/Recettes/caruru.jpg"),
//************************************************************************************************

            new Recette("Tapioca poulet et catupiry",Modele.Type.Entree,new List<Ingredient>()
        {
            new Ingredient("tapioca", new Quantité(1, Unité.KG)),
            new Ingredient("sel", new Quantité(10, Unité.G)),
            new Ingredient("poitrines de poulet", new Quantité(500, Unité.G)),
            new Ingredient("1cube de bouillon de poulet", new Quantité(1, Unité.UNITE)),
            new Ingredient("coriandre et paprika", new Quantité(100, Unité.G)),
            new Ingredient("cuillière de soupe d'huile d'olive", new Quantité(1, Unité.UNITE)),
            new Ingredient("poivron vert", new Quantité(1, Unité.UNITE)),
            new Ingredient("oignon haché", new Quantité(1, Unité.UNITE)),
            new Ingredient("tomate hachée", new Quantité(1, Unité.UNITE)),
            new Ingredient("bouquet d'odeur verte", new Quantité(1, Unité.UNITE)),
            new Ingredient("sel au goût", new Quantité(10, Unité.G)),
            new Ingredient("catupiry", new Quantité(250, Unité.G)),


        },new List<string>()
        {
            "Assaisonnez la poitrine de poulet désossée avec le cube de bouillon de poulet, la coriandre, le paprika " +
            "et une cuillère à soupe d'huile d'olive.",
            "Placer le poivron vert coupé en petits cubes, l'oignon haché, la tomate hachée, l'odeur " +
            "verte et le sel au goût.",
            "Râpez et ajoutez 150 g de crème.",
            "Étalez le caillé sur le tapioca, placez une tranche de fromage mozzarella et la farce de" +
            "poulet avec la crème."

        },Region.Nordest,40,4, img:"Images/Recettes/catupiry.jpg"),
//************************************************************************************************

            new Recette("Pudim de tapioca",Modele.Type.Dessert,new List<Ingredient>()
        {
            new Ingredient("tasse de sucre", new Quantité(1, Unité.UNITE)),
            new Ingredient("tasse d'eau", new Quantité(1, Unité.UNITE)),
            new Ingredient("tasse de tapioca granulé", new Quantité(1, Unité.UNITE)),
            new Ingredient("lait de coco", new Quantité(100, Unité.ML)),
            new Ingredient("tasse de lait", new Quantité(2, Unité.UNITE)),
            new Ingredient("boite de lait concentré", new Quantité(1, Unité.UNITE)),
            new Ingredient("oeuf", new Quantité(4, Unité.UNITE)),
        },new List<string>()
        {
            "Portez le sucre, dans une casserole, au feu et faites cuire jusqu'à ce qu'il caramélise.",
            "Ajouter 1/2 tasse d'eau et éteindre le feu.",
            "Versez ce sirop dans une forme avec un trou au milieu et réservez.",
            "Dans un bol, mélanger le tapioca granulé avec le lait de coco et laisser hydrater 20 à 30 minutes, réserver.",
            "Battez le lait avec le lait concentré et les œufs dans un mélangeur.",
            "Ouvrez le couvercle du mélangeur et ajoutez le tapioca hydraté.",
            "Fouettez rapidement, juste pour mélanger",
            "Versez ce mélange dans la forme réservée avec le sirop.",
            "Recouvrez le moule de papier d'aluminium et faites cuire au bain-marie (180°C) pendant environ 60 minutes.",
            "Démouler et conserver au réfrigérateur."
        },Region.Nordest,90,8, img:"Images/Recettes/tapioca.jpg"),
//************************************************************************************************

            new Recette("Bouillon de piranha",Modele.Type.Plat,new List<Ingredient>()
        {
            new Ingredient("piranhas", new Quantité(1, Unité.KG)),
            new Ingredient("oignons", new Quantité(2, Unité.UNITE)),
            new Ingredient("sachet d'assaisonnement pour poisson assaisonné", new Quantité(1, Unité.UNITE)),
            new Ingredient("gousses d'ail", new Quantité(4, Unité.UNITE)),
            new Ingredient("eau", new Quantité(1, Unité.L)),
            new Ingredient("paquet de creme d'oignon", new Quantité(1, Unité.UNITE)),
            new Ingredient("cuillière (soupe) huile d'olive", new Quantité(1, Unité.UNITE)),
            new Ingredient("", new Quantité(1, Unité.UNITE)),

        },new List<string>()
        {
            "Pressez l'ail, écrasez l'oignon et mettez-le à dorer dans l'huile, dans une cocotte-minute.",
            "Assaisonnez les piranhas avec l'assaisonnement pour poisson",
            "Lorsque l'ail et l'oignon sont dorés, ajoutez les piranhas.",
            "Faire sauter et ajouter l'eau, le persil et la ciboulette.",
            "Laisser sous pression pendant 30 minutes.",
            "Laisser refroidir et passer au tamis.",
            "Placer dans une casserole, ajouter la crème d'oignon et porter à ébullition en remuant constamment, à feu doux.",
            "Servir avec du persil et du parmesan râpé."

        },Region.CentreOuest,90,8, img:"Images/Recettes/piranha.jpg"),
//************************************************************************************************

            new Recette("TERERÊ",Modele.Type.Entree,new List<Ingredient>()
        {
            new Ingredient("paquet de jus de citron", new Quantité(1, Unité.KG)),
            new Ingredient("citron hachés", new Quantité(4, Unité.UNITE)),
            new Ingredient("tasse de sucre", new Quantité(1.5, Unité.UNITE)),
            new Ingredient("eau glacée", new Quantité(1, Unité.L)),
            new Ingredient("courge préparée avec des herbes", new Quantité(1, Unité.UNITE)),

        },new List<string>()
        {
            "Mettez 1 litre d'eau glacée dans un thermos, le jus du jus de citron, le jus des 4 citrons, le sucre et remuez",
            "Servir dans la calebasse avec l'herbe."
        },Region.CentreOuest,40,1, img:"Images/Recettes/terere.jpg"),
//************************************************************************************************

            new Recette("Gâteau mané Nelado",Modele.Type.Dessert,new List<Ingredient>()
        {
            new Ingredient("de manioc râpé", new Quantité(1, Unité.KG)),
            new Ingredient("tasses de sucre", new Quantité(2, Unité.UNITE)),
            new Ingredient("cuillères à soupe de margarine ou de beurre", new Quantité(2, Unité.UNITE)),
            new Ingredient("oeufs", new Quantité(3, Unité.UNITE)),
            new Ingredient("paquet de noix de coco râpée", new Quantité(1, Unité.UNITE)),
            new Ingredient("lait de coco", new Quantité(1, Unité.L)),
            new Ingredient("lait concentré", new Quantité(1, Unité.L)),
            new Ingredient("pincée de sel", new Quantité(1, Unité.UNITE)),
            new Ingredient("cuillère de levure chimique", new Quantité(1, Unité.UNITE)),



        },new List<string>()
        {
            "Combinez tous les ingrédients et mélangez bien.",
            "Verser dans une forme graissée avec de la margarine",
            "Placer au four préchauffé, laisser à haute température, jusqu'à ce qu'ils soient dorés.",
            "Il est préférable de servir après quelques heures, c'est meilleur !"
        },Region.CentreOuest,40,12, img:"Images/Recettes/nelado.jpg"),
//************************************************************************************************

            new Recette("Feijoada",Modele.Type.Plat,new List<Ingredient>()
        {
            new Ingredient("haricots noirs", new Quantité(1, Unité.KG)),
            new Ingredient("viande séchée", new Quantité(100, Unité.G)),
            new Ingredient("oreille de porc", new Quantité(70, Unité.G)),
            new Ingredient("queue de porc", new Quantité(70, Unité.G)),
            new Ingredient("pieds de porc", new Quantité(70, Unité.G)),
            new Ingredient("côtes de porc", new Quantité(100, Unité.G)),
            new Ingredient("longe de porc", new Quantité(50, Unité.G)),
            new Ingredient("paio", new Quantité(100, Unité.G)),
            new Ingredient("saucisse portugaise", new Quantité(150, Unité.G)),
            new Ingredient("gros oignons hachés", new Quantité(2, Unité.UNITE)),
            new Ingredient("bouquet d'oignons verts hachés", new Quantité(1, Unité.UNITE)),
            new Ingredient("feuilles de laurier", new Quantité(3, Unité.UNITE)),
            new Ingredient("gousses d'ail", new Quantité(6, Unité.UNITE)),
            new Ingredient("poivre noir au goût", new Quantité(1, Unité.UNITE)),
            new Ingredient("oranges", new Quantité(2, Unité.UNITE)),
            new Ingredient("pinga", new Quantité(50, Unité.ML)),
            new Ingredient("pincée de sel", new Quantité(1, Unité.UNITE))
        },new List<string>()
        {
            "Faites tremper les viandes pendant 36 heures ou plus, changez l'eau plusieurs fois, s'il s'agit d'un environnement" +
            " chaud ou estival, mettez de la glace sur le dessus ou en couches froides.",
            "Cuire pas à pas : les viandes dures, puis les viandes tendres.",
            "Lorsqu'ils sont tendres, ajoutez les haricots et retirez la viande",
            "Enfin, assaisonnez les haricots."
        },Region.Sudest,140,5, img:"Images/Recettes/feijoada.jpg"),
//************************************************************************************************

            new Recette("Bolinho de bacalhau",Modele.Type.Entree,new List<Ingredient>()
        {
            new Ingredient("cabillaud dessalé et effiloché", new Quantité(300, Unité.G)),
            new Ingredient("tasses (thé) de pommes de terre bouillies et pressées", new Quantité(3, Unité.UNITE)),
            new Ingredient("cuillère à soupe (soupe) de farine de blé", new Quantité(1, Unité.UNITE)),
            new Ingredient("Sel et poivre noir au goût", new Quantité(1, Unité.UNITE)),
            new Ingredient("oeufs", new Quantité(3, Unité.UNITE)),
            new Ingredient("cuillères à soupe de persil haché", new Quantité(2, Unité.UNITE)),
            new Ingredient("huile de friture", new Quantité(1, Unité.L)),
        },new List<string>()
        {
            "Dans un bol, bien mélanger tous les ingrédients.",
            "A l'aide d'une cuillère à soupe, prélever des portions de pâte, les faire revenir dans l'huile chaude " +
            "jusqu'à ce qu'elles soient dorées et les égoutter sur du papier absorbant."
        },Region.Sudest,50,10, img:"Images/Recettes/bacalhau.jpg"),
//************************************************************************************************

            new Recette("Brigadeiro",Modele.Type.Dessert,new List<Ingredient>()
        {
            new Ingredient("lait concentré", new Quantité(1, Unité.L)),
            new Ingredient("cuillère à soupe de margarine non salée", new Quantité(1, Unité.UNITE)),
            new Ingredient("cuillères à soupe de lait au chocolat", new Quantité(1, Unité.UNITE)),
            new Ingredient("PEPITES de chocolat", new Quantité(300, Unité.G))
        },new List<string>()
        {
            "Dans une casserole profonde, ajouter le lait concentré, la margarine et le lait au chocolat" +
            " (ou 4 cuillères à soupe de chocolat en poudre).",
            "Cuire à feu moyen et remuer jusqu'à ce que le brigadeiro commence à se décoller de la poêle.",
            "Laisser refroidir et faire des petites boules à la main en passant la pâte dans les pépites de chocolat"
        },Region.Sudest,25,8, img:"Images/Recettes/brigadeiro.jpg"),
//************************************************************************************************

            new Recette("Riz carreteiro",Modele.Type.Plat,new List<Ingredient>()
        {
            new Ingredient("tasses de riz", new Quantité(3, Unité.UNITE)),
            new Ingredient("viande séchée", new Quantité(500, Unité.G)),
            new Ingredient("bacon tranché", new Quantité(200, Unité.G)),
            new Ingredient("pepperoni", new Quantité(200, Unité.G)),
            new Ingredient("tomate bien mûre", new Quantité(1, Unité.UNITE)),
            new Ingredient("oignon", new Quantité(1, Unité.UNITE)),
            new Ingredient("pincé de piment pepperoni", new Quantité(1, Unité.UNITE)),
            new Ingredient("bout de persil", new Quantité(1, Unité.UNITE)),
            new Ingredient("pincé de sel", new Quantité(1, Unité.UNITE)),
        },new List<string>()
        {
            "Faites cuire la viande dans une cocotte-minute, retirez-le, attendez qu'il refroidisse et râpez-le.",
            "Réservez",
            "Pelez la peau du pepperoni et coupez-la en cubes avec le bacon.",
            "Couper la tomate en petits dés sans les pépins ainsi que l'oignon",
            "Réservez",
            "Faire sauter le bacon et le pepperoni jusqu'à ce qu'ils soient dorés, puis ajouter " +
            "l'oignon, la tomate, le pepperoni et la viande effilochée.",
            "Après avoir ajouté le riz, bien le noyer, ajouter l'eau en corrigeant le sel si nécessaire " +
            "et baisser le feu en attendant qu'il sèche.",
            "Lorsque vous êtes prêt, mettez le persil sur le dessus."
        },Region.Sud,60,6, img:"Images/Recettes/carreteiro.jpg"),
//************************************************************************************************

            new Recette("Chimarrão",Modele.Type.Entree,new List<Ingredient>()
        {
            new Ingredient("une gourde de herba mate", new Quantité(750, Unité.ML)),
            new Ingredient("eau", new Quantité(200, Unité.ML)),
            new Ingredient("gourde", new Quantité(1, Unité.UNITE)),
        },new List<string>()
        {
            "Remplir aux deux tiers d'une gourde (un bol dans lequel on prend le maté) de maté.",
            "Ensuite, faites un petit tas sur un côté de la calebasse et versez de l'eau tiède ou chaude jusqu'à la bouche.",
            "Attendez 5 minutes avant de boire pour laisser le temps à l'herbe de gonfler.",
            "La première gorgée doit être crachée car elle est toujours accompagnée d'un peu de poudre de maté.",
            "Si vous voulez répéter, vous n'avez pas besoin d'ajouter plus de maté, il suffit de remplir à nouveau la gourde avec de l'eau."
        },Region.Sud,10,1, img:"Images/Recettes/chimarrao.jpg"),
//************************************************************************************************

            new Recette("Cuca",Modele.Type.Dessert,new List<Ingredient>()
        {
            new Ingredient("tasses de farine de blé", new Quantité(4, Unité.UNITE)),
            new Ingredient("tasses de sucre", new Quantité(2, Unité.UNITE)),
            new Ingredient("tasse de lait", new Quantité(1, Unité.UNITE)),
            new Ingredient("œufs", new Quantité(4, Unité.UNITE)),
            new Ingredient("cuillères a soupe de beurre ou de margarine", new Quantité(2, Unité.UNITE)),
            new Ingredient("cuillères a soupe de levure chimique", new Quantité(2, Unité.UNITE)),
            new Ingredient("tasse de sucre", new Quantité(1, Unité.UNITE)),
            new Ingredient("tasse de farine de blé", new Quantité(0.5, Unité.UNITE)),
            new Ingredient("poudre de cannelle", new Quantité(5, Unité.G)),
            new Ingredient("cuillères à soupe de margarine ou de beurre", new Quantité(2, Unité.UNITE)),
        },new List<string>()
        {
            "Battre les œufs avec le sucre et mélanger les autres ingrédients jusqu'à formation d'une masse homogène.",
            "Il suffit de tout mettre dans un bol et de pétrir jusqu'à ce que cela ressemble à des miettes.",
            "Unir une forme avec de la margarine, mettre la pâte et saupoudrer le farofa",
            "Placer dans le four préchauffé pour cuire environ 40 minutes."
        },Region.Sud,60,12, img:"Images/Recettes/cuca.jpg"),
//************************************************************************************************
// RECETTES VEGANES

            new RecetteVegan("Moqueca Vegana",Modele.Type.Plat,new List<Ingredient>()
        {
            new Ingredient("cœur de palmier (tranches épaisses)", new Quantité(300, Unité.G)),
            new Ingredient("carotte (en tranches)", new Quantité(1, Unité.UNITE)),
            new Ingredient("tasse de haricots verts (hachés)", new Quantité(1, Unité.UNITE)),
            new Ingredient("poivron/poivron rouge (en tranches)", new Quantité(1, Unité.UNITE)),
            new Ingredient("tomates", new Quantité(4, Unité.UNITE)),
            new Ingredient("poireau ", new Quantité(1, Unité.UNITE)),
            new Ingredient("oignon ", new Quantité(1, Unité.UNITE)),
            new Ingredient("tasse de persil/salsa (haché)", new Quantité(1, Unité.UNITE)),
            new Ingredient("lait de coco", new Quantité(250, Unité.ML)),
            new Ingredient("cuillères à soupe d'huile d'olive", new Quantité(15, Unité.UNITE)),
            new Ingredient("sel et poivre a goût", new Quantité(1, Unité.UNITE)),
        },new List<string>()
        {
            "Faites revenir l'oignon et le poireau dans l'huile d'olive chaude. ",
            "Ajoutez ensuite la carotte, les haricots verts et les tomates. ",
            "Assaisonnez avec du sel et du poivre. Après 10 minutes, ajoutez les cœurs de palmier et le lait de coco",
            "Lorsque les ingrédients sont tendres, éteignez le feu et servez avec le persil haché",
        },Region.Sudest,60,4, img:"Images/Recettes/moquecaV.jpg","Moqueca de crevettes"),
//************************************************************************************************

            new RecetteVegan("Vatapa Vegano",Modele.Type.Plat,new List<Ingredient>()
        {
            new Ingredient("miches de pain", new Quantité(2, Unité.UNITE)),
            new Ingredient("lait de coco", new Quantité(125, Unité.ML)),
            new Ingredient("eau", new Quantité(125, Unité.ML)),
            new Ingredient("tomate", new Quantité(1, Unité.UNITE)),
            new Ingredient("oignon", new Quantité(1, Unité.UNITE)),
            new Ingredient("poivron vert", new Quantité(1, Unité.UNITE)),
            new Ingredient("coriandre fraîche", new Quantité(10, Unité.G)),
            new Ingredient("cuillère de cumin en poudre", new Quantité(1, Unité.UNITE)),
            new Ingredient("cuillères à soupe d'huile d'olive", new Quantité(5, Unité.UNITE)),
            new Ingredient("Sel et poivre noir/poivre a goût", new Quantité(1, Unité.UNITE)),
        },new List<string>()
        {
            "Placez le pain dans un bol avec le lait de coco pendant 20 minutes. ",
            "Pendant ce temps, passez au mixeur l'eau avec l'oignon, la tomate, le poivron vert, la coriandre et les cacahuètes.",
            " Lorsque le mélange est lisse, transférez-le dans une casserole et faites-le cuire à feu moyen.",
            "Ajoutez le pain trempé, ainsi que le cumin, le sel et le poivre noir.",
            "Laissez cuire en remuant constamment",
            "Dès que le mélange commence à s'épaissir, vous saurez qu'il arrive à point.",
        },Region.Nordest,60,4, img:"Images/Recettes/vatapaV.jpg","Vatapa"),
//************************************************************************************************

            new RecetteVegan("Gâteau de Banane Vegano ",Modele.Type.Dessert,new List<Ingredient>()
        {
            new Ingredient("bananes mûres", new Quantité(3, Unité.UNITE)),
            new Ingredient("cuillères à soupe de graines de chia", new Quantité(4, Unité.UNITE)),
            new Ingredient(" lait végétal (l'amande et la noix de coco sont les meilleures options pour le sucré)", new Quantité(150, Unité.ML)),
            new Ingredient("cuillère à soupe de sirop d'agave", new Quantité(1, Unité.UNITE)),
            new Ingredient("cuillères à soupe d'huile de noix de coco", new Quantité(2, Unité.UNITE)),
            new Ingredient("cuillères à soupe de farine", new Quantité(4, Unité.UNITE)),
            new Ingredient("cuillère à café de levure chimique", new Quantité(1, Unité.UNITE)),
            new Ingredient("d'amandes entières", new Quantité(50, Unité.G)),
            new Ingredient("pincée de sel", new Quantité(1, Unité.UNITE))
        },new List<string>()
        {
            "Ecraser les bananes dans un bol",
            "Ajoutez les graines, le lait végétal, le sirop d'agave et l'huile de coco",
            "Mélangez bien et laissez reposer pendant une heure",
            "Ajoutez ensuite la farine, le sel, la levure chimique et les amandes",
            "Mélangez le tout et versez le mélange dans un moule à pain",
            "Sur le dessus, vous pouvez mettre des tranches de banane ou des morceaux d'autres fruits (comme des myrtilles ou des framboises)",
            "Sur le dessus, vous pouvez mettre des tranches de banane ou des morceaux d'autres fruits (comme des myrtilles ou des framboises)",
            "Retirer du moule lorsqu'il a refroidi et qu'il est prêt à être servi."
        },Region.Sudest,40,12, img:"Images/Recettes/bananeV.jpg","gâteau de banane"),
//************************************************************************************************

            new RecetteVegan("Quindim Vegano",Modele.Type.Dessert,new List<Ingredient>()
        {
            new Ingredient("lait de coco", new Quantité(200, Unité.ML)),
            new Ingredient("tasse de sucre", new Quantité(1, Unité.UNITE)),
            new Ingredient("cuillères à soupe d'extrait de soja", new Quantité(3, Unité.UNITE)),
            new Ingredient("cuillères à soupe d'eau", new Quantité(2, Unité.UNITE)),
            new Ingredient("cuillères à soupe d'huile (maïs ou tournesol)", new Quantité(2, Unité.UNITE)),
            new Ingredient("cuillères à soupe de fécule de maïs", new Quantité(3, Unité.UNITE)),
            new Ingredient("tasses de manioc brut râpé", new Quantité(2, Unité.UNITE)),
            new Ingredient("sucre glace pour saupoudrer", new Quantité(20, Unité.G))
        },new List<string>()
        {
            "Laissez la noix de coco râpée de côté, mais battez les autres ingrédients dans le mixeur. ",
            "Placez les éléments liquides en premier et ajoutez les autres progressivement tout en mixant. Mélangez ensuite la noix de coco râpée. ",
            "Graissez le moule avec de l'huile et saupoudrez-le d'un peu de sucre. ",
            "Versez le mélange dans le moule et faites cuire au bain-marie à four moyen pendant environ 40 minutes.",
            "Vérifiez avec un cure-dent pour décider quand éteindre le four.",
            "Démouler à froid et saupoudrer le sucre sur le quindim."
        },Region.Sudest,20,1, img:"Images/Recettes/quindimV.jpg","Quindim")
        };

        List<Compte> comptes = new List<Compte>()
        {
            new Compte("user1","senha1",'h'),
            new Compte("user2","senha2",'f'),
            new Compte("user3","senha3",'f'),
            new Compte("user4","senha4",'h')
        };

        IEnumerable<Recette> IPersistanceManager.LoadRecettes()
        {
            return recettes;
        }

        IEnumerable<Compte> IPersistanceManager.LoadComptes()
        {
            return comptes;
        }

        void IPersistanceManager.SauvegardeDonnées(IEnumerable<Recette> recettes, IEnumerable<Compte> comptes)
        {
            Debug.WriteLine("Sauvegarde demandée");
        }
        
    }
}