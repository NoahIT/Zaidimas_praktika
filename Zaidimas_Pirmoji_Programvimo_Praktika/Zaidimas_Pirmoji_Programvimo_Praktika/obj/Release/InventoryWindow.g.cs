﻿#pragma checksum "..\..\InventoryWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2406B116925EA3DEF12172022614D7D20BE2D83134AB3275CE3188F2092E36B1"
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
    /// InventoryWindow
    /// </summary>
    public partial class InventoryWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 34 "..\..\InventoryWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image hero;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\InventoryWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblMoney;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\InventoryWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dtgInventory;
        
        #line default
        #line hidden
        
        
        #line 120 "..\..\InventoryWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSell;
        
        #line default
        #line hidden
        
        
        #line 143 "..\..\InventoryWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnShop;
        
        #line default
        #line hidden
        
        
        #line 166 "..\..\InventoryWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnInventory;
        
        #line default
        #line hidden
        
        
        #line 189 "..\..\InventoryWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnMainMenu;
        
        #line default
        #line hidden
        
        
        #line 234 "..\..\InventoryWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEquip;
        
        #line default
        #line hidden
        
        
        #line 256 "..\..\InventoryWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnUnEquip;
        
        #line default
        #line hidden
        
        
        #line 278 "..\..\InventoryWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dtgEquipped;
        
        #line default
        #line hidden
        
        
        #line 329 "..\..\InventoryWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblMoney_Copy;
        
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
            System.Uri resourceLocater = new System.Uri("/Zaidimas_Pirmoji_Programvimo_Praktika;component/inventorywindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\InventoryWindow.xaml"
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
            
            #line 93 "..\..\InventoryWindow.xaml"
            this.dtgInventory.Loaded += new System.Windows.RoutedEventHandler(this.dtgInventory_Loaded);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnSell = ((System.Windows.Controls.Button)(target));
            
            #line 128 "..\..\InventoryWindow.xaml"
            this.btnSell.Click += new System.Windows.RoutedEventHandler(this.btnSell_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnShop = ((System.Windows.Controls.Button)(target));
            
            #line 149 "..\..\InventoryWindow.xaml"
            this.btnShop.Click += new System.Windows.RoutedEventHandler(this.btnShop_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnInventory = ((System.Windows.Controls.Button)(target));
            
            #line 172 "..\..\InventoryWindow.xaml"
            this.btnInventory.Click += new System.Windows.RoutedEventHandler(this.btnInventory_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnMainMenu = ((System.Windows.Controls.Button)(target));
            
            #line 195 "..\..\InventoryWindow.xaml"
            this.btnMainMenu.Click += new System.Windows.RoutedEventHandler(this.btnMainMenu_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnEquip = ((System.Windows.Controls.Button)(target));
            
            #line 242 "..\..\InventoryWindow.xaml"
            this.btnEquip.Click += new System.Windows.RoutedEventHandler(this.btnEquip_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnUnEquip = ((System.Windows.Controls.Button)(target));
            
            #line 264 "..\..\InventoryWindow.xaml"
            this.btnUnEquip.Click += new System.Windows.RoutedEventHandler(this.btnUnEquip_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.dtgEquipped = ((System.Windows.Controls.DataGrid)(target));
            
            #line 286 "..\..\InventoryWindow.xaml"
            this.dtgEquipped.Loaded += new System.Windows.RoutedEventHandler(this.dtgInventory_Loaded);
            
            #line default
            #line hidden
            return;
            case 11:
            this.lblMoney_Copy = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
