﻿#pragma checksum "..\..\FirstLvlWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "32E9D20A50DD96F79923B5CA14EEDB7871F7BF78ABACE435F5565F1FBDADCC98"
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
using WpfAnimatedGif;
using Zaidimas_Pirmoji_Programvimo_Praktika;


namespace Zaidimas_Pirmoji_Programvimo_Praktika {
    
    
    /// <summary>
    /// FirstLvlWindow
    /// </summary>
    public partial class FirstLvlWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\FirstLvlWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid mainContainer;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\FirstLvlWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image mainHero;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\FirstLvlWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAttack;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\FirstLvlWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image enemyHero;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\FirstLvlWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ProgressBar HeroMana;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\FirstLvlWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ProgressBar EnemyMana;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\FirstLvlWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ProgressBar EnemyHp;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\FirstLvlWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ProgressBar HeroHp;
        
        #line default
        #line hidden
        
        
        #line 137 "..\..\FirstLvlWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnQuit1;
        
        #line default
        #line hidden
        
        
        #line 160 "..\..\FirstLvlWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAttack2;
        
        #line default
        #line hidden
        
        
        #line 183 "..\..\FirstLvlWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnHeal;
        
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
            System.Uri resourceLocater = new System.Uri("/Zaidimas_Pirmoji_Programvimo_Praktika;component/firstlvlwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\FirstLvlWindow.xaml"
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
            this.mainContainer = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.mainHero = ((System.Windows.Controls.Image)(target));
            return;
            case 3:
            this.btnAttack = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\FirstLvlWindow.xaml"
            this.btnAttack.Click += new System.Windows.RoutedEventHandler(this.btnAttack_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.enemyHero = ((System.Windows.Controls.Image)(target));
            return;
            case 5:
            this.HeroMana = ((System.Windows.Controls.ProgressBar)(target));
            return;
            case 6:
            this.EnemyMana = ((System.Windows.Controls.ProgressBar)(target));
            return;
            case 7:
            this.EnemyHp = ((System.Windows.Controls.ProgressBar)(target));
            return;
            case 8:
            this.HeroHp = ((System.Windows.Controls.ProgressBar)(target));
            return;
            case 9:
            this.btnQuit1 = ((System.Windows.Controls.Button)(target));
            
            #line 146 "..\..\FirstLvlWindow.xaml"
            this.btnQuit1.Click += new System.Windows.RoutedEventHandler(this.btnAttack_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btnAttack2 = ((System.Windows.Controls.Button)(target));
            
            #line 170 "..\..\FirstLvlWindow.xaml"
            this.btnAttack2.Click += new System.Windows.RoutedEventHandler(this.btnAttack2_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.btnHeal = ((System.Windows.Controls.Button)(target));
            
            #line 193 "..\..\FirstLvlWindow.xaml"
            this.btnHeal.Click += new System.Windows.RoutedEventHandler(this.btnHeal_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

