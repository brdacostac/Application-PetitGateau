﻿using Modele;
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

namespace InterfaceAppli1
{
    /// <summary>
    /// Logique d'interaction pour SudesteUC.xaml
    /// </summary>
    public partial class SudesteUC : UserControl
    {
        public Manager Mgr => (App.Current as App).LeManager;
        public SudesteUC()
        {
            InitializeComponent();
        }

        private void regionSudestUC_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
