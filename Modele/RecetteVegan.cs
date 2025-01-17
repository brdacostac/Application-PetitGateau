﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Modele
{

    /// <summary>
    /// represente les recettes vegans
    /// </summary>
    [DataContract]
    [KnownType(typeof(RecetteVegan))]
    public class RecetteVegan : Recette
    {
        /// <summary>
        /// contient le plat qui a servi de base pour la recette vegane
        /// </summary>
        [DataMember]
        public string source
        {
            get { return sources; }
            private set { sources = value; }
        }
        private string sources;


        /// <summary>
        /// constructeur
        /// </summary>
        public RecetteVegan(string nom, Type type, List<Ingredient> l, List<string> prep, Region og, int t, int couv, string img, string s) : base(nom, type, l, prep, og, t, couv, img)
        {
            if (type == Type.Plat)
                sources = "Cette recette est une version vegane du plat " + s;
            else if (type == Type.Entree)
                sources = "Cette recette est une version vegane de l'entrée " + s;
            else
                sources = "Cette recette est une version vegane du dessert " + s;
        }
    }
}
