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

        public RecetteVegan(string nom, Type type, List<Ingredient> l, List<string> prep, Region og, int t, int couv, List<string> s) : base(nom, type, l, prep, og, t, couv, null)
        {
            sources = s;
        }
    }
}
