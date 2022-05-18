using System;
using System.Collections.Generic;
using Modele;

namespace Test_Niveau
{
    class Program
    {
        static void Main(string[] args)
        {
            Niveau niveau = new Niveau(10, 101);
            Console.WriteLine("*****TESTE_Niveau_Class******");

            Console.WriteLine(niveau.ToString());

        }
    }
}
