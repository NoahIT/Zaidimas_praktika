﻿#pragma checksum "..\..\ChooseAccountWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1D5FFA39A99C7419364FCE3ABE863EC4005DC46F425E28D60767E81CE309974A"
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
    /// ChooseAccountWindow
    /// </summary>
    public partial class ChooseAccountWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 30 "..\..\ChooseAccountWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tbChooseSave;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\ChooseAccountWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAccountSelect1;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\ChooseAccountWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnLoadGame;
        
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
            System.Uri resourceLocater = new System.Uri("/Zaidimas_Pirmoji_Programvimo_Praktika;component/chooseaccountwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ChooseAccountWindow.xaml"
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
            this.tbChooseSave = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.btnAccountSelect1 = ((System.Windows.Controls.Button)(target));
            
            #line 57 "..\..\ChooseAccountWindow.xaml"
            this.btnAccountSelect1.Click += new System.Windows.RoutedEventHandler(this.btnAccountSelect1_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnLoadGame = ((System.Windows.Controls.Button)(target));
            
            #line 84 "..\..\ChooseAccountWindow.xaml"
            this.btnLoadGame.Click += new System.Windows.RoutedEventHandler(this.btnLoadGame_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

