﻿#pragma checksum "..\..\..\MasterFavoris.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "316DBF4C18CFC7B451D2F02F1619283F8D12AF60"
//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

using InterfaceAppli1;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace InterfaceAppli1 {
    
    
    /// <summary>
    /// MasterFavoris
    /// </summary>
    public partial class MasterFavoris : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\MasterFavoris.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SearchBar;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\MasterFavoris.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button entree;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\MasterFavoris.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button plat;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\MasterFavoris.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button dessert;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\MasterFavoris.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox recet;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.4.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/InterfaceAppli1;component/masterfavoris.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MasterFavoris.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.SearchBar = ((System.Windows.Controls.TextBox)(target));
            
            #line 17 "..\..\..\MasterFavoris.xaml"
            this.SearchBar.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.SearchBar_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.entree = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\MasterFavoris.xaml"
            this.entree.Click += new System.Windows.RoutedEventHandler(this.entree_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.plat = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\MasterFavoris.xaml"
            this.plat.Click += new System.Windows.RoutedEventHandler(this.plat_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.dessert = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\MasterFavoris.xaml"
            this.dessert.Click += new System.Windows.RoutedEventHandler(this.dessert_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.recet = ((System.Windows.Controls.ListBox)(target));
            
            #line 28 "..\..\..\MasterFavoris.xaml"
            this.recet.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ListBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

