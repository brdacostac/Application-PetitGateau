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
            manager.LoadComptes();
            manager.Pers = new DataContractPersistance1.DataContractPers();
            manager.SauvegardeDonnées();
        }
    }
}
