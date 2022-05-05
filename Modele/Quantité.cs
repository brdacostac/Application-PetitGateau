using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public double Nombre { get; private set; }

        public Unité Uni { get; private set; }

        /// <summary>
        /// constructeur
        /// </summary>
        /// <param name="nombre">la quantité desirée</param>
        public Quantité(double nombre, Unité uni)
        {
            Nombre = nombre;
            Uni = uni;
        }

        public override string ToString()
        {
            return $"{Nombre} {Uni}";
        }
    }
}
