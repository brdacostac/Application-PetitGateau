using System;
using System.Collections.Generic;
using System.Text;

namespace Modele
{
    public class Niveau
    {
        /// <summary>
        /// indique le niveau
        /// </summary>
        public double Level
        {
            get { return level; }
            private set { level = value; }

        }
        public double level;

        /// <summary>
        /// Experience necessaire pour passer au prochain niveau
        /// </summary>
        public double ExperienceNecessaire
        {
            get { return experienceNecessaire; }
            private set { experienceNecessaire = value; }

        }
        public double experienceNecessaire;

        /// <summary>
        /// contructeur
        /// </summary>
        public Niveau()
        {
            Level = 1;
            ExperienceNecessaire = 100;
        }   

        /// <summary>
        /// permet d'afficher les information d'un niveau
        /// </summary>
        /// <returns>un string contenant le niveau et experience nécessaire</returns>
        public override string ToString()
        {
            return $"Level: {Level} Experience Nécéssaire: {ExperienceNecessaire}";
        }
    }
}
