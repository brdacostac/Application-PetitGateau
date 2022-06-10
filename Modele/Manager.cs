using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Modele
{
    public class Manager : INotifyPropertyChanged
    {
        /// <summary>
        /// represente la base de données contenant les recettes et comptes 
        /// </summary>
        public Database Db
        {
            get { return db; }
            private set { db = value; }
        }
        private Database db;
    
        /// <summary>
        /// permet de savoir si l'utilisateur actuel est connecter a un compte
        /// ou pas. Et si connecter, permet de charger ses données.
        /// </summary>
        public Compte CurrentUser
        {
            get { return currentUser; }
            private set { currentUser = value; }
        }
        private Compte currentUser;

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// la recette a séléctionné par l'utilisateur dans le master d'items.         
        /// </summary>
        public Recette RecetteSelectionne 
        { 
            get => recetteSelectionne;
            set
            {
                if(recetteSelectionne != value)
                {
                    recetteSelectionne = value;
                    OnPropertyChanged("RecetteSelectionne");
                }
            }
        }
        private Recette recetteSelectionne;

        void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));


        /// <summary>
        /// dépendance avec IPersistanceManager
        /// </summary>
        public IPersistanceManager Pers
        {
            get { return pers; }
            set { pers = value; }
        }
        private IPersistanceManager pers;



        /// <summary>
        /// Recherche des recettes vegans par nom et l'ajoute à la liste si trouvé
        /// </summary>
        /// <param name="nom">le nom de la recette recherchée</param>
        public List<RecetteVegan> SearchByNameVegan(string nom)
        {
            List<RecetteVegan> listeVegan_avec_nom = new List<RecetteVegan>();
            foreach (Recette r in db.Recettes)
            {
                RecetteVegan recetteV_demande = r as RecetteVegan;
                
                if (r.Nom.Contains(nom) && recetteV_demande != null)
                {
                    listeVegan_avec_nom.Add(recetteV_demande);
                }
            }
            return listeVegan_avec_nom;
        }

        /// <summary>
        /// Recherche des recettes par nom et l'ajoute à la liste si trouvé
        /// </summary>
        /// <param name="nom">le nom de la recette recherchée</param>
        public List<Recette> SearchByNameRegion(string nom, Region origine)
        {
            List<Recette> liste_avec_nom = new List<Recette>();
            foreach (Recette r in db.Recettes)
            {
                if (r.Nom.Contains(nom) && r.Origine == origine)
                {
                    liste_avec_nom.Add(r);
                }
            }
            return liste_avec_nom;
        }

        /// <summary>
        /// Recherche des recettes par nom qui sont dans les favoris de l'utilisateur et l'ajoute à la liste si trouvé
        /// </summary>
        /// <param name="nom">le nom de la recette recherchée</param>
        public List<Recette> SearchByNameFavoris(string nom)
        {
            List<Recette> liste_avec_nom = new List<Recette>();
            foreach (Recette r in CurrentUser.MesRecettes)
            {
                if (r.Nom.Contains(nom))
                {
                    liste_avec_nom.Add(r);
                }
            }
            return liste_avec_nom;
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
        ///  Retourne une liste contenant seulement mes recettes veganes
        /// </summary>
        public List<RecetteVegan> recettes_vegans()
        {

            List<RecetteVegan> liste_demande = new List<RecetteVegan>();

            foreach (Recette r in db.Recettes)
            {
                RecetteVegan recetteV_demande = r as RecetteVegan;
                if (recetteV_demande != null)
                {
                    liste_demande.Add(recetteV_demande);
                }
            }
            return liste_demande;

        }


        /// <summary>
        /// recettes du type choisi par l'utilisateur 
        /// </summary>
        /// <param name="filtre"></param>
        public List<Recette> recettes_type_choisi(Type filtre)
        {
            List<Recette> liste_demande = new List<Recette>();

            foreach (Recette r in db.Recettes)
            {

                if (r.Filtre == filtre)
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

            foreach (Recette r in db.Recettes)
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

            foreach (Recette r in db.Recettes)
            {

                if (r.Origine == origine && r.Filtre == filtre)
                {
                    liste_par_origine_et_filtre.Add(r);
                }
            }
            return liste_par_origine_et_filtre;

        }

        /// <summary>
        ///  Retourne une liste qui contient la recette avec les plus de likes par type
        /// </summary>
        /// <param name="filtre">type filtre pour filtrer les top recettes</param>
        public List<Recette> recette_top_type_choisi(Type filtre)
        {
            List<Recette> liste_demande = new List<Recette>();

            Recette max = db.Recettes[0];

            foreach (Recette r in Db.Recettes)
            {
                if (r.Liked >= max.Liked && r.Filtre == filtre)
                {
                    max = r;
                }
            }
            
            liste_demande.Add(max);
            return liste_demande;

        }

        /// <summary>
        /// Crée une liste des recettes veganes ayant une type precis (entree, plat ou dessert) passé en parametre
        /// </summary>
        /// <param name="filtre">type filtre pour filtrer les recettes veganes</param>

        public List<RecetteVegan> recettesVegan_type_choisi(Type filtre)
        {
            List<RecetteVegan> liste_demande = new List<RecetteVegan>();

            foreach (Recette r in db.Recettes)
            {
                RecetteVegan recetteV_demande = r as RecetteVegan;
                if (r.Filtre == filtre && recetteV_demande != null)
                {
                    liste_demande.Add(recetteV_demande);
                }
            }
            return liste_demande;
        }

        /// <summary>
        /// Crée une liste des recettes favoris ayant une type precis (entree, plat ou dessert) passé en parametre
        /// </summary>
        /// <param name="filtre">type filtre pour filtrer les recettes favorites</param>

        public List<Recette> recettesFavoris_type_choisi(Type filtre)
        {
            List<Recette> liste_demande = new List<Recette>();

            foreach (Recette r in CurrentUser.MesRecettes)
            {
                
                if (r.Filtre == filtre)
                {
                    liste_demande.Add(r);
                }
            }
            return liste_demande;
        }

        /// <summary>
        /// affiche toutes les recettes ayant une region og
        /// </summary>
        /// <param name="og">region d'origine des recette desirée</param>
        public List<Recette> DisplayRecetteRegion(Region og)
        {
            List<Recette> reg = new List<Recette> ();

            foreach (Recette r in db.Recettes)
            {
                if (r.Origine == og)
                {
                    reg.Add(r);
                }
            }
            return reg;
        }

        /// <summary>
        /// verifie si le compte passé en paramètre existe dans la base de donnée ou pas
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
                    {
                        c.connected = true;
                        currentUser = c;
                        return true;
                    }  
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
        /// Charge toutes les recettes
        /// </summary>
        public void LoadRecettes()
        {
            db.Recettes.Clear();
            db.Recettes.AddRange(Pers.LoadRecettes());
            RecetteSelectionne = Db.Recettes[0];
        }

        /// <summary>
        /// Charge toutes les comptes
        /// </summary>
        public void LoadComptes()
        {
            db.Comptes.Clear();
            db.Comptes.AddRange(Pers.LoadComptes());
        }


        /// <summary>
        /// Sauvegarde les données à l'aide de la persistance
        /// </summary>
        public void SauvegardeDonnées()
        {
            Pers.SauvegardeDonnées(db.Recettes, db.Comptes);
        }

        /// <summary>
        /// constructeur
        /// </summary>
        /// <param name="r">liste de recettes</param>
        /// <param name="c">liste de comptes</param>
        public Manager(IPersistanceManager pers)
        {
            Db = new Database();
            Pers = pers;
            CurrentUser = new Compte("visiteur", "motdepasse", 'h');
        }

        public Manager()
        {
            Db = new Database();
        }

    }
}
