﻿#pragma checksum "..\..\ePosta.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5EB82FFA5F149C3629F5B7AA9FFD0AFAA6A0111812916E21FDB311C6A550020D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MahApps.Metro.Controls;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
using Zapisnik;


namespace Zapisnik {
    
    
    /// <summary>
    /// ePosta
    /// </summary>
    public partial class ePosta : MahApps.Metro.Controls.MetroWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\ePosta.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtZa;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\ePosta.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtZadeva;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\ePosta.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtBoxVsebinaePoste;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\ePosta.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Poslji;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\ePosta.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Priponka;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\ePosta.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Izbriši;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\ePosta.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtBoxPriponka;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\ePosta.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtBoxUporabiskoIme;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\ePosta.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox pswBoxPassword;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Zapisnik;component/eposta.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ePosta.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.txtZa = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txtZadeva = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtBoxVsebinaePoste = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.Poslji = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\ePosta.xaml"
            this.Poslji.Click += new System.Windows.RoutedEventHandler(this.Poslji_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Priponka = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\ePosta.xaml"
            this.Priponka.Click += new System.Windows.RoutedEventHandler(this.Priponka_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Izbriši = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\ePosta.xaml"
            this.Izbriši.Click += new System.Windows.RoutedEventHandler(this.Izbriši_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.txtBoxPriponka = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.txtBoxUporabiskoIme = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.pswBoxPassword = ((System.Windows.Controls.PasswordBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

