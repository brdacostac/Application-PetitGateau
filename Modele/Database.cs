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
        public Database()
        {
            Comptes = new List<Compte>();
            Recettes = new List<Recette>();
        }

        /// <summary>
        /// recettes du type choisi par l'utilisateur 
        /// </summary>
        /// <param name="filtre"></param>
        public List<Recette> recettes_type_choisi(Type filtre)
        {
            List<Recette> liste_demande = new List<Recette>();

            foreach ( Recette r in recettes)
            {

                if(r.Filtre == filtre)
                {
                    liste_demande.Add(r);
                }
            }
            return liste_demande;
            
        }


        /// <summary>
        /// recettes de la region choisi par l'utilisateur 
        /// </summary>
        /// <param name="origine"></param>
        public List<Recette> recettes_region_choisi(Region origine)
        {
            List<Recette> liste_par_origine = new List<Recette>();

            foreach (Recette r in recettes)
            {

                if (r.Origine == origine)
                {
                    liste_par_origine.Add(r);
                }
            }
            return liste_par_origine;

        }

        /// <summary>
        /// recettes du type et de la region choisi par l'utilisateur
        /// </summary>
        /// <param name="origine"></param>
        /// <param name="filtre"></param>
        public List<Recette> recettes_region_type_choisi(Region origine, Type filtre)
        {
            List<Recette> liste_par_origine_et_filtre = new List<Recette>();

            foreach (Recette r in recettes)
            {

                if (r.Origine == origine && r.Filtre == filtre)
                {
                    liste_par_origine_et_filtre.Add(r);
                }
            }
            return liste_par_origine_et_filtre;

        }
    }
}
