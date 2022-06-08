using System;
using System.Collections.Generic;
using System.Text;

namespace Modele
{
    public  interface IPersistanceManager
    {
        IEnumerable<Recette> LoadRecettes();
        IEnumerable<Compte> LoadComptes();
        void SauvegardeDonnées(IEnumerable<Recette> recettes);
    }
}
