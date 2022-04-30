// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModeleItems;

namespace Test_quantite
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test de la classe Quantite");

            Quantité qte = new Quantité(20,Unité.KG);
            Console.WriteLine(qte);
        }
    }
}