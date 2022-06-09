using Modele;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace DataContractPersistance1
{
    [DataContract]
    class DataToPersist
    {


        /// <summary>
        /// liste de recettes de l'application
        /// </summary>
        [DataMember]
        public List<Recette> Recettes
        {
            get { return recettes; }
            private set { recettes = value; }
        }
        private List<Recette> recettes = new List<Recette>();


        /// <summary>
        /// liste de comptes utilisateur de l'application
        /// </summary>
        [DataMember]
        public List<Compte> Comptes
        {
            get { return comptes; }
            private set { comptes = value; }
        }
        private List<Compte> comptes = new List<Compte>();
    }
}
