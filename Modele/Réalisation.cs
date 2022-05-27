using System;
using System.Collections.Generic;
using System.Text;

namespace Modele
{
    [Flags]
    public enum Réalisation : int
    {
        Livre = 0,
        Planche = 1,
        Coutellerie = 2,
        MicroOndes = 3,
        Frigo = 4,
        Cuillere = 5,
        Bouilloire = 6,
        Four = 7,
        Couvert = 8,
        Evier = 9,
        Rouleau = 10,
        Carafe = 11,
        Tasse = 12,
        CasseroleFerme = 13,
        Bol = 14,
        Theiere = 15,
        Ciseaux = 16,
        Gants = 17,
        Saliere = 18,
        CasseroleRemplis = 19,
        Marteau = 20,
        Montre = 21,
        Verre = 22,
        GrillePain = 23,
        Poele = 24,
        PotRemplis = 25,
        PotVide = 26,
        CasseroleVide = 27,
        Assiette = 28
    }
}
