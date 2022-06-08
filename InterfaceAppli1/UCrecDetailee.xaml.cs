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
using Modele;

namespace InterfaceAppli1
{
    /// <summary>
    /// Interação lógica para UCrecDetailee.xam
    /// </summary>
    public partial class UCrecDetailee : UserControl
    {
        public Manager Mgr => (App.Current as App).LeManager;
        public UCrecDetailee()
        {
            InitializeComponent();

            (App.Current as App).LeManager.LoadRecettes();
            DataContext = Mgr.Db.Recettes;
        }
    }
}
