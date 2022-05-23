using System;
using System.Collections.Generic;
using static System.Console;
using System.Linq;
using System.Text;

namespace Modele
{
    public class Chef
    {
        /// <summary>
        /// représente le niveau du chef 
        /// </summary>
        public Niveau Level
        {
            get { return level; }
            private set { level = value; }

        }
        private Niveau level;

        /// <summary>
        /// l'experience actuel de l'utilisateur
        /// </summary>
        public double ExperienceActuel
        {
            get { return experienceActuel; }
            private set { experienceActuel = value; }

        }
        public double experienceActuel;

        /// <summary>
        /// permet de savoir quels réalisation ont été débloquées
        /// </summary>
        public Dictionary<Réalisation, bool> Realisations
        {
            get { return realisations; }
            private set { realisations = value; }
        }
        private Dictionary<Réalisation, bool> realisations = new Dictionary<Réalisation, bool>();


        /// <summary>
        /// Monte le niveau du chef de 1 en mettant a jour l'experience 
        /// nécéssaire et en débloquant un nouvel outil
        /// </summary>
        public void LevelUp()
        {
            if (experienceActuel >= Level.experienceNecessaire)
            {
                Level.indice = Level.indice + 1;
                DebloquerOutil();
                Level.experienceNecessaire = Level.experienceNecessaire * 2;
            }
        }

        /// <summary>
        /// permet de savoir quelles associations ont étées débloquées ou pas
        /// </summary>
        public List<int> ListeTrue
        {
            get { return listeTrue; }
            private set { listeTrue = value; }
        }
        private List<int> listeTrue = new List<int>();

        /// <summary>
        /// débloque un nouvel outil a l'utilisateur
        /// </summary>
        public void DebloquerOutil()
        {
            Random rdm = new Random();
            int nbRandom = rdm.Next(29);
            while (listeTrue.Contains(nbRandom))
            {
                nbRandom = rdm.Next(29);
            }
            Realisations[(Réalisation)nbRandom] = true;
            listeTrue.Add(nbRandom);        
        }

        /// <summary>
        /// contructeur
        /// </summary>
        /// <param name="level"></param>
        public Chef()
        {
            Level = new Niveau();

            Realisations.Add(Réalisation.Livre, false);
            Realisations.Add(Réalisation.Planche, false);
            Realisations.Add(Réalisation.Coutellerie, false);
            Realisations.Add(Réalisation.MicroOndes, false);
            Realisations.Add(Réalisation.Cuillere, false);
            Realisations.Add(Réalisation.Bouilloire, false);
            Realisations.Add(Réalisation.Couvert, false);
            Realisations.Add(Réalisation.Evier, false);
            Realisations.Add(Réalisation.Rouleau, false);
            Realisations.Add(Réalisation.Carafe, false);
            Realisations.Add(Réalisation.Tasse, false);
            Realisations.Add(Réalisation.Bol, false);
            Realisations.Add(Réalisation.Theiere, false);
            Realisations.Add(Réalisation.Ciseaux, false);
            Realisations.Add(Réalisation.Gants, false);
            Realisations.Add(Réalisation.Saliere, false);
            Realisations.Add(Réalisation.Marteau, false);
            Realisations.Add(Réalisation.Montre, false);
            Realisations.Add(Réalisation.Verre, false);
            Realisations.Add(Réalisation.GrillePain, false);
            Realisations.Add(Réalisation.Poele, false);
            Realisations.Add(Réalisation.PotRemplis, false);
            Realisations.Add(Réalisation.PotVide, false);
            Realisations.Add(Réalisation.CasseroleVide, false);
            Realisations.Add(Réalisation.Assiette, false);
        }

        /// <summary>
        /// affiche les informations basiques du chef
        /// </summary>
        /// <returns>Une string contenant le niveau et l'experience actuel du chef</returns>
        public override string ToString()
        {
            return ($"{Level}\nExperience actuelle : {ExperienceActuel}");
        }
    }
}
