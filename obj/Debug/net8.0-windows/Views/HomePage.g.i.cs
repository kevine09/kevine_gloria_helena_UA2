﻿#pragma checksum "..\..\..\..\Views\HomePage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49682C798A9CC6215B887EFB0B384C1A60B4542C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
using kevine_gloria_helena_UA2.Views;


namespace kevine_gloria_helena_UA2.Views {
    
    
    /// <summary>
    /// HomePage
    /// </summary>
    public partial class HomePage : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\..\Views\HomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Accueil;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\..\Views\HomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Reservations;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\Views\HomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Chambres;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\Views\HomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Clients;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\Views\HomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ContentControl EspaceDeTravail;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.4.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/kevine_gloria_helena_UA2;V1.0.0.0;component/views/homepage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\HomePage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Accueil = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\..\Views\HomePage.xaml"
            this.Accueil.Click += new System.Windows.RoutedEventHandler(this.Accueil_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Reservations = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\..\Views\HomePage.xaml"
            this.Reservations.Click += new System.Windows.RoutedEventHandler(this.Reservations_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Chambres = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\..\Views\HomePage.xaml"
            this.Chambres.Click += new System.Windows.RoutedEventHandler(this.Chambres_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Clients = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\..\Views\HomePage.xaml"
            this.Clients.Click += new System.Windows.RoutedEventHandler(this.Clients_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.EspaceDeTravail = ((System.Windows.Controls.ContentControl)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
