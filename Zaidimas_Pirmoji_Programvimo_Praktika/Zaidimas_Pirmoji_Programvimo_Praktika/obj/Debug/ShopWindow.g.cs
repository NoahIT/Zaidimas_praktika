﻿#pragma checksum "..\..\ShopWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "47BD788BD203519DF7BCB66D7858F2BCDB2586D23C48D61FEC98C78EA4F872B4"
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
    /// ShopWindow
    /// </summary>
    public partial class ShopWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\ShopWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image hero;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\ShopWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblMoney;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\ShopWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dtgInventory;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\ShopWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSell;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\ShopWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnShop;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\ShopWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnInventory;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\ShopWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnMainMenu;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\ShopWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblError;
        
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
            System.Uri resourceLocater = new System.Uri("/Zaidimas_Pirmoji_Programvimo_Praktika;component/shopwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ShopWindow.xaml"
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
            this.hero = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            this.lblMoney = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.dtgInventory = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 4:
            this.btnSell = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\ShopWindow.xaml"
            this.btnSell.Click += new System.Windows.RoutedEventHandler(this.btnBuy_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnShop = ((System.Windows.Controls.Button)(target));
            
            #line 50 "..\..\ShopWindow.xaml"
            this.btnShop.Click += new System.Windows.RoutedEventHandler(this.btnShop_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnInventory = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\ShopWindow.xaml"
            this.btnInventory.Click += new System.Windows.RoutedEventHandler(this.btnInventory_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnMainMenu = ((System.Windows.Controls.Button)(target));
            
            #line 52 "..\..\ShopWindow.xaml"
            this.btnMainMenu.Click += new System.Windows.RoutedEventHandler(this.btnMainMenu_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.lblError = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

