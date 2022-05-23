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
        public double Indice
        {
            get { return indice; }
            private set { indice = value; }

        }
        public double indice;

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
            Indice = 1;
            ExperienceNecessaire = 100;
        }   

        /// <summary>
        /// permet d'afficher les information d'un niveau
        /// </summary>
        /// <returns>un string contenant le niveau et experience nécessaire</returns>
        public override string ToString()
        {
            return $"Level: {Indice} Experience Nécéssaire: {ExperienceNecessaire}";
        }
    }
}
