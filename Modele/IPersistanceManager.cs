using System;
using System.Collections.Generic;
using System.Text;

namespace Modele
{
    /// <summary>
    /// represente la persistance manager
    /// </summary>
    public interface IPersistanceManager
    {
        /// <summary>
        /// chargement des recettes
        /// </summary>
        /// <returns></returns>
        IEnumerable<Recette> LoadRecettes();

        /// <summary>
        /// chargement des comptes
        /// </summary>
        /// <returns></returns>
        IEnumerable<Compte> LoadComptes();

        /// <summary>
        /// sauvegarde des données
        /// </summary>
        /// <param name="recettes">collection de recettes</param>
        /// <param name="comptes">collection de comptes</param>
        void SauvegardeDonnées(IEnumerable<Recette> recettes, IEnumerable<Compte> comptes);
    }
}
