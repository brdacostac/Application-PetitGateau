using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele
{
    /// <summary>
    /// represente un ingredient
    /// </summary>
    public class Ingredient
    {
        /// <summary>
        /// nom de l'aliment
        /// </summary>
        public string Aliment 
        {
            get { return aliment; }
            private set { aliment = value; } 
        }
        private string aliment;

        /// <summary>
        /// la quantité de l'ingredient
        /// </summary>
        public Quantité Quant 
        { 
            get { return quant; }
            private set { quant = value; } 
        }
        private Quantité quant;

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
            return $"{Aliment} {Quant}";
        }
    }
}
