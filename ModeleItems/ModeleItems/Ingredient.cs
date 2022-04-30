using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeleItems
{
    /// <summary>
    /// represente un ingredient
    /// </summary>
    public class Ingredient
    {
        /// <summary>
        /// nom de l'aliment
        /// </summary>
        public string Aliment { get; private set; }

        /// <summary>
        /// la quantité de l'ingredient
        /// </summary>
        public Quantité Quant { get; private set; }

        /// <summary>
        /// constructeur
        /// </summary>
        /// <param name="aliment">le nom de l'aliment</param>
        public Ingredient(string aliment, Quantité quant)
        {
            Aliment = aliment;
            Quant = quant;
        }

        public override string ToString()
        {
            return $"{Quant} {Aliment}";
        }
    }
}
