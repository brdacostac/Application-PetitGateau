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
            Console.WriteLine("*****TESTE_Chef_Class******");
            Chef newChef = new Chef(niveau);
         
            newChef.LevelUp();
            newChef.Display(newChef.Realisations);
        }
    }
}
