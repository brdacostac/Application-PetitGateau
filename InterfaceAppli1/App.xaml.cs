using DataContractPersistance1;
using Modele;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using StubLib2;

namespace InterfaceAppli1
{
    /// <summary>
    /// Logique d'interaction pour App.xaml
    /// </summary>
    public partial class App : Application
    {
        public Manager LeManager { get; private set; } = new Manager(new DataContractPers());

        public Navigator Navigator { get; private set; } = new Navigator();

        public App()
        {

        }

        public void App_end(object sender, ExitEventArgs e)
        {
            LeManager.SauvegardeDonnées();
        }

    }

}
