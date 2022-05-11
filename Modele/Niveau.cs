using System;
using System.Collections.Generic;
using System.Text;

namespace Modele
{
    public class Niveau
    {
        
        public int Level
        {
            get { return level; }
            private set { level = value; }

        }
        public int level = 0;

        public int ExperienceActuel
        {
            get { return experienceActuel; }
            private set { experienceActuel = value; }

        }
        public int experienceActuel = 0;

        public int ExperienceNecessaire
        {
            get { return experienceNecessaire; }
            private set { experienceNecessaire = value; }

        }
        public int experienceNecessaire = 100;

        public Niveau(int level, int experienceActuel)
        {
            this.level = level;
            this.experienceActuel = experienceActuel;
        }

        public void LevelUp()
        {
            if (experienceActuel >= experienceNecessaire)
            {
                level++;
            }
        }
    }
}
