using System;
using System.Collections.Generic;
using Modele;

namespace Test_Chef
{  
    class Program
    {
        static void Main(string[] args)
        {
            Chef newChef = new Chef();
            Console.WriteLine("*****TESTE Classe Chef******");
            Console.WriteLine(newChef);
            Console.WriteLine();

            
            void Display(Dictionary<Réalisation, bool> Realisations)
            {
                foreach (KeyValuePair<Réalisation, bool> kvp in Realisations)
                {
                    Console.WriteLine($"{kvp.Key} => { kvp.Value}");
                }
            }
            
            for (int i = 0; i < 10; i++)
            {
                newChef.ExperienceActuel = newChef.ExperienceActuel + 200;
                newChef.LevelUp();
                Console.WriteLine(newChef.Level);
            }
            Display(newChef.Realisations);
            Console.WriteLine();
            Console.WriteLine(newChef);         
        }
    }
}
