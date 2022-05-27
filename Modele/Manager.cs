using System;
using System.Collections.Generic;
using System.Text;

namespace Modele
{
    class Manager
    {
        public Database Dd
        {
            get { return db; }
            private set { db = value; }
        }
        private Database db;

        /// <summary>
        /// Recherche une recettes par nom. L'affiche si trouvé.
        /// </summary>
        /// <param name="nom">le nom de la recette recherchée</param>
        public void SearchByName(string nom)
        {
            int i = 0;
            foreach(Recette r in db.Recettes)
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
            foreach (Recette r in db.Recettes)
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
            foreach (Recette r in db.Recettes)
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

        /// <summary>
        /// verifie si les un compte existe dans la base de donnée ou pas
        /// </summary>
        /// <param name="username">nom du compte cherché</param>
        /// <param name="password">le mot de passe associé</param>
        /// <returns>true si le compte et dans la base et le mot de passe est correcte.
        /// false si le mot de passe n'est pas correcete ou si le compte n'existe pas</returns>
        public bool Login(string username, string password)
        {
            foreach (Compte c in db.Comptes)
            {
                if (c.Username == username)
                    if (c.Password == password)
                        return true;
                    else
                        Console.WriteLine("Le mot de passe n'est pas correcte");
            }
            return false;
        }

        /// <summary>
        /// ajoute un nouveau compte a la base de données
        /// </summary>
        /// <param name="username">le choisi par l'utilisateur</param>
        /// <param name="password">le mot de passe associé</param>
        /// <param name="sexe">le sexe choisi</param>
        public void NouveauCompte(string username, string password, char sexe)
        {
            Compte c = new Compte(username, password, sexe);
            db.Comptes.Add(c);
            Console.WriteLine("Le nouveau compte a été créé");
        }


        /// <summary>
        /// constructeur
        /// </summary>
        /// <param name="r">liste de recettes</param>
        /// <param name="c">liste de comptes</param>
        public Manager(List<Recette> r, List<Compte> c)
        {
            db = new Database(c, r);
        }
    }
 }
