using System;
using Modele;

namespace Test_datacontract
{
    class Program
    {
        static void Main(string[] args)
        {
           Manager manager = new Manager(new StubLib2.Stub());
            manager.LoadRecettes();
            manager.Pers = new DataContractPersistance.DataContractPers();
            manager.SauvegardeDonnées();
        }
    }
}
