using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Modele
{
    [DataContract]
    public class Niveau
    {
        [DataMember]
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
        /// experience necessaire pour passer au prochain niveau
        /// </summary>
        [DataMember]
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
            return $"Niveau: {Indice}\nExperience Nécéssaire: {ExperienceNecessaire}";
        }
    }
}
