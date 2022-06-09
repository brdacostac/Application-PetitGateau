using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MahApps.Metro.Controls;
using ControlzEx.Theming;
using Modele;

namespace InterfaceAppli1
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {

        public Navigator Navigator => (App.Current as App).Navigator;
        public Manager Manager => (App.Current as App).LeManager;
        public MainWindow()
        {
            InitializeComponent();
            (App.Current as App).LeManager.LoadRecettes();
            (App.Current as App).LeManager.LoadComptes();
            DataContext = this;
        }
    }
}
