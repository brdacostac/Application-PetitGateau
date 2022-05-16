using System;
using System.Collections.Generic;
using static System.Console;
using System.Linq;
using System.Text;

namespace Modele
{
    public class Chef
    {

        public Niveau Level
        {
            get { return level; }
            private set { level = value; }

        }
        private Niveau level;

        public Dictionary<Réalisation, bool> Realisations
        {
            get { return realisations; }
            private set { realisations = value; }
        }
        private Dictionary<Réalisation, bool> realisations = new Dictionary<Réalisation, bool>();


        public void LevelUp()
        {
            if (Level.experienceActuel >= Level.experienceNecessaire)
            {
                Level.level++;
            }
            DebloquerOutil();
        }

        public override string ToString()
        {
            return ($"{level}");
        }

        private List<int> listeTrue = new List<int>();
        public void DebloquerOutil()
        {
            Random rdm = new Random();
            int nbRandom = rdm.Next(29);
            while (listeTrue.Contains(nbRandom))
            {
                nbRandom = rdm.Next(29);
            }
            Realisations[(Réalisation)nbRandom] = true;
            listeTrue.Add(nbRandom);
            
            
        }

        public Chef(Niveau level)
        {
            this.level = level;

            Realisations.Add(Réalisation.Livre, false);
            Realisations.Add(Réalisation.Planche, false);
            Realisations.Add(Réalisation.Coutellerie, false);
            Realisations.Add(Réalisation.MicroOndes, false);
            Realisations.Add(Réalisation.Cuillere, false);
            Realisations.Add(Réalisation.Bouilloire, false);
            Realisations.Add(Réalisation.Couvert, false);
            Realisations.Add(Réalisation.Evier, false);
            Realisations.Add(Réalisation.Rouleau, false);
            Realisations.Add(Réalisation.Carafe, false);
            Realisations.Add(Réalisation.Tasse, false);
            Realisations.Add(Réalisation.Bol, false);
            Realisations.Add(Réalisation.Theiere, false);
            Realisations.Add(Réalisation.Ciseaux, false);
            Realisations.Add(Réalisation.Gants, false);
            Realisations.Add(Réalisation.Saliere, false);
            Realisations.Add(Réalisation.Marteau, false);
            Realisations.Add(Réalisation.Montre, false);
            Realisations.Add(Réalisation.Verre, false);
            Realisations.Add(Réalisation.GrillePain, false);
            Realisations.Add(Réalisation.Poele, false);
            Realisations.Add(Réalisation.PotRemplis, false);
            Realisations.Add(Réalisation.PotVide, false);
            Realisations.Add(Réalisation.CasseroleVide, false);
            Realisations.Add(Réalisation.Assiette, false);

        }
        

    }
}
