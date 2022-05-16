using System;
using System.Collections.Generic;
using Modele;

namespace Test_Compte
{
    class Program
    {
        static void Main(string[] args)
        {
            Niveau niveau = new Niveau(10, 99);
            Chef newChef = new Chef(niveau);
            Compte compte = new Compte("Bruno","cachorro",'M',newChef);
            Console.WriteLine("*****TESTE_Compte_Class******");
            Console.WriteLine(compte.ToString());
        }
    }
}
