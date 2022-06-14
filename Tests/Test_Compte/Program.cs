using System;
using System.Collections.Generic;
using Modele;

namespace Test_Compte
{
    class Program
    {
        static void Main(string[] args)
        {
            Niveau niveau = new Niveau();
            Chef newChef = new Chef();
            Compte compte = new Compte("Bruno","cachorro",'M',"63000, Clermont-Ferrand Rue Pablo Picasso 48");
            Console.WriteLine("*****TESTE_Compte_Class******");
            Console.WriteLine(compte.ToString());
        }
    }
}
