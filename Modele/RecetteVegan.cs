using System;
using System.Collections.Generic;
using System.Text;

namespace Modele
{
    public class RecetteVegan : Recette
    {
        public List<string> Sources
        {
            get { return sources; }
            private set { sources = value; }
        }
        private List<string> sources = new List<string>();

        public RecetteVegan(string nom, string description, Type type, List<Ingredient> l, Region og, List<string> s) : base(nom, description, type, l, og)
        {
            sources = s;
        }
    }
}
