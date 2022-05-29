using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele
{
    public class Recette // : IEquatable<Recette> ? ou IEquatable<Ingredients>
    {
        /// <summary>
        /// nom de la recette
        /// </summary>
        public string Nom
        {
            get { return nom; }
            private set { nom = value; }
        }
        private string nom;

        /// <summary>
        /// nombre de "like" reçues par cette recette
        /// </summary>
        public int Liked 
        {
            get { return liked; }
            set { liked = value; }
        }
        private int liked;

        /// <summary>
        /// Liste de commentaires attribués a la recettte
        /// </summary>
        public List<string> Commentaires
        {
            get { return commentaires; }
            private set { commentaires = value; }
        }
        private List<string> commentaires;

        /// <summary>
        /// indique le nombre de couverts possible par cette recette
        /// </summary>
        public int Couverts
        {
            get { return couverts; }
            set { couverts = value; }
        }
        private int couverts;

        /// <summary>
        /// indique le temps de préparation de la recette
        /// </summary>
        public int Temps
        {
            get { return temps; }
            set { temps = value; }
        }
        private int temps;


        /// <summary>
        /// Le type de plat (entrée, plat ou dessert)
        /// </summary>
        public Type Filtre 
        {
            get { return filtre; } 
            private set { filtre = value; } 
        }
        private Type filtre;

        /// <summary>
        /// Indique la region d'origine d'une recette
        /// </summary>
        public Region Origine
        {
            get { return origine; }
            private set { origine = value; }
        }
        private Region origine;

        /// <summary>
        /// Liste d'ingredients de la recette
        /// * verifier si encapsulation de la liste est necessaire / correcte
        /// </summary>
        public List<Ingredient> Ingredients
        {
            get { return ingredients; }
            private set { ingredients = value; }
        }
        private List<Ingredient> ingredients = new List<Ingredient>();

        /// <summary>
        /// Liste contenant les étapes de preparation de la recette
        /// </summary>
        public List<string> Preparation
        {
            get { return preparation; }
            private set { preparation = value; }
        }
        private List<string> preparation = new List<string>();


        /// <summary>
        /// constructeur
        /// </summary>
        /// <param name="nom">nom de la recette</param>
        /// <param name="description">description de la recettte</param>
        /// <param name="type">type de la recette</param>
        public Recette(string nom, Type type, List<Ingredient> l, List<string> prep, Region og, int t, int couv)
        {
            Nom = nom;
            Preparation = prep;
            Liked = 0;
            Filtre = type;
            Ingredients = l;
            Origine = og;
            Temps = t;
            Couverts = couv;
        }

        /// <summary>
        /// Permet d'affiché une recette avec toutes ces informations
        /// </summary>
        public void Display()
        {
            Console.Write($"Nom : {Nom}\nType : {Filtre}\nDescription : {Description}\nRegion : {Origine}");
            Console.WriteLine();
            Console.Write("Ingredients : \n");
            foreach(Ingredient i in ingredients)
            {
                Console.Write($"- {i} \n");
            }
            Console.WriteLine();
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            else if (obj.GetType() != this.GetType())
                return false;
            else
            {
                Recette r = (Recette)obj; 
                if (r.Nom == this.nom && r.Liked == this.Liked && r.Description == this.Description)
                    return true;
                else
                    return false;
            }
        }
    }
}
