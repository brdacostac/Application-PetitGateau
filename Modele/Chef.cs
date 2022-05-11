using System;
using System.Collections.Generic;
using System.Text;

namespace Modele
{
    public class Chef
    {
        Niveau level;
        Dictionary<int, bool> Realisations = new Dictionary<int, bool>();

        static void Display(Dictionary<Réalisation, bool> Realisations)
        {
            foreach(KeyValuePair<Réalisation, bool> kvp in Realisations)
            {
                Console.WriteLine($"{kvp.Key} => { kvp.Value}");
            }
            Console.WriteLine();
        }



        public Chef(Niveau level)
        {
            this.level = level;

        }
        

}
}
