using System;
using System.Collections.Generic;
using System.Text;

namespace Modele
{
    /// <summary>
    /// represente la quantié d'un Ingredient
    /// </summary>
    public class Quantité
    {
        /// <summary>
        /// la quantite
        /// </summary>
        public double Nombre 
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private double nombre;

        /// <summary>
        /// l'unité liée a la quantité 
        /// </summary>
        public Unité Uni 
        {
            get { return uni; }
            set { uni = value; }
        }
        private Unité uni;

        /// <summary>
        /// constructeur
        /// </summary>
        /// <param name="nombre">la quantité desirée</param>
        /// <param name="uni">l'unité liée a la quantité</param>
        public Quantité(double nombre, Unité uni)
        {
            Nombre = nombre;
            Uni = uni;
        }

        public override string ToString()
        {
            if(Uni == Unité.UNITE)
            {
                return $"{Nombre}";
            }
            else
                return $"{Nombre} {Uni}";
        }
    }

}
