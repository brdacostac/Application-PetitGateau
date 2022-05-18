using System;
using System.Collections.Generic;
using System.Text;

namespace Modele
{
    class Manager
    {
        public List<Recette> Recette
        {
            get { return recettes; }
            private set { recettes = value; }
        }
        private List<Recette> recettes = new List<Recette>();
        
        /// <summary>
        /// Recherche une recettes par nom. L'affiche si trouvé.
        /// </summary>
        /// <param name="nom">le nom de la recette recherchée</param>
        public void SearchByName(string nom)
        {
            int i = 0;
            foreach(Recette r in recettes)
            {
                if (r.Nom == nom)
                {
                    r.Display();
                    i++;
                }       
            }
            if (i == 0)
                Console.Write("Aucune recette de ce nom a été trouvée");
            else
                return;
        }

        /// <summary>
        /// affiche toutes les recettes ayant un type t
        /// </summary>
        /// <param name="t">type de recette desirée</param>
        public void DisplayRecetteType(Type t)
        {
            int i = 0;
            foreach (Recette r in recettes)
            {
                if (r.Filtre == t)
                {
                    r.Display();
                    i++;
                }
            }
            if (i == 0)
                Console.Write("Aucune recette de ce type a été trouver");
            else
                return;
        }

        /// <summary>
        /// affiche toutes les recettes ayant une region og
        /// </summary>
        /// <param name="og">region d'origine des recette desirée</param>
        public void DisplayRecetteRegion(Region og)
        {
            int i = 0;
            foreach (Recette r in recettes)
            {
                if (r.Origine == og)
                {
                    r.Display();
                    i++;
                }
            } 
            if (i == 0)
                Console.Write("Aucune recette de cette region a été trouver");
            else
                return;
        }
    }
 }
