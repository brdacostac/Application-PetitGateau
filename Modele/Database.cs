using System;
using System.Collections.Generic;
using System.Text;

namespace Modele
{
    public class Database
    {
        /// <summary>
        /// liste de recettes de l'application
        /// </summary>
        public List<Recette> Recettes
        {
            get { return recettes; }
            private set { recettes = value; }
        }
        private List<Recette> recettes = new List<Recette>();

        /// <summary>
        /// liste de comptes utilisateur de l'application
        /// </summary>
        public List<Compte> Comptes
        {
            get { return comptes; }
            private set { comptes = value; }
        }
        private List<Compte> comptes = new List<Compte>();

        /// <summary>
        /// database 
        /// </summary>
        /// <param name="c"></param>
        /// <param name="r"></param>
        public Database(List<Compte> c, List<Recette> r)
        {
            Comptes = c;
            Recettes = r;
        }
        /// <summary>
        /// database
        /// </summary>
        public Database()
        {
            Comptes = new List<Compte>();
            Recettes = new List<Recette>();
        }

    }
}
