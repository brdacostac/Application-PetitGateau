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
    /// Logique d'interaction pour MonChefUC.xaml
    /// </summary>
    public partial class MonChefUC : UserControl
    {
        public MonChefUC()
        {
            InitializeComponent();
        }

        private void UCbuttons_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private async void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            int valeur = 100;
            while (progressBar.Value <= valeur)
            {

                await Task.Delay(1);

                if (progressBar.Value <= valeur)
                {
                    progressBar.Value = progressBar.Value + 0.50;
                }

            }
        }
    }
}
