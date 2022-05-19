using System;
using System.Collections.Generic;
using Modele;

namespace Test_Chef
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Niveau niveau = new Niveau(10, 99);
            Chef newChef = new Chef(niveau);
            Console.WriteLine("*****TESTE_Chef_Class******");

            void Display(Dictionary<Réalisation, bool> Realisations)
            {
                foreach (KeyValuePair<Réalisation, bool> kvp in Realisations)
                {
                    Console.WriteLine($"{kvp.Key} => { kvp.Value}");
                }
                Console.WriteLine();
                Console.WriteLine($"Niveau : {newChef.Level}");
            }

            for (int i = 0; i < 29; i++)
                newChef.LevelUp();
            Display(newChef.Realisations);
        }
    }
}
