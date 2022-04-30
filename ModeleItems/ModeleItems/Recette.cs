using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeleItems
{
    public class Recette
    {
        /// <summary>
        /// nom de la recette
        /// </summary>
        public string Nom { get; private set; }

        /// <summary>
        /// description de la recette
        /// </summary>
        public string Description { get; private set; }

        /// <summary>
        /// nombre de "like" reçues par cette recette
        /// </summary>
        public int Liked { get; private set; }

        /// <summary>
        /// Le type de plat (entrée, plat ou dessert)
        /// </summary>
        public Type Filtre { get; private set; }

        // liste d'ingredients

        /// <summary>
        /// constructeur
        /// </summary>
        /// <param name="nom">nom de la recette</param>
        /// <param name="description">description de la recettte</param>
        /// <param name="type">type de la recette</param>
        public Recette(string nom, string description, Type type)
        {
            Nom = nom;
            Description = description;
            Liked = 0;
            Filtre = type;
        }

        public void LikeRecette()
        {
            Liked++;
        }
    }
}
