// Updated by XamlIntelliSenseFileGenerator 5/4/2023 7:01:23 PM
#pragma checksum "..\..\ChooseHeroWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0AA11DB038286987D53D8F6D18561AF2EA347B4D3A28485FC17CB7A6E31DA12A"
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


namespace Zaidimas_Pirmoji_Programvimo_Praktika
{


    /// <summary>
    /// ChooseHeroWindow
    /// </summary>
    public partial class ChooseHeroWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {


#line 21 "..\..\ChooseHeroWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image hero1;

#line default
#line hidden


#line 32 "..\..\ChooseHeroWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image hero2;

#line default
#line hidden


#line 43 "..\..\ChooseHeroWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image hero3;

#line default
#line hidden


#line 54 "..\..\ChooseHeroWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnNinja;

#line default
#line hidden


#line 81 "..\..\ChooseHeroWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnVampire;

#line default
#line hidden


#line 108 "..\..\ChooseHeroWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnGirl;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Zaidimas_Pirmoji_Programvimo_Praktika;component/chooseherowindow.xaml", System.UriKind.Relative);

#line 1 "..\..\ChooseHeroWindow.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.hero1 = ((System.Windows.Controls.Image)(target));
                    return;
                case 2:
                    this.hero2 = ((System.Windows.Controls.Image)(target));
                    return;
                case 3:
                    this.hero3 = ((System.Windows.Controls.Image)(target));
                    return;
                case 4:
                    this.btnNinja = ((System.Windows.Controls.Button)(target));

#line 62 "..\..\ChooseHeroWindow.xaml"
                    this.btnNinja.Click += new System.Windows.RoutedEventHandler(this.btnNinja_Click);

#line default
#line hidden
                    return;
                case 5:
                    this.btnVampire = ((System.Windows.Controls.Button)(target));

#line 89 "..\..\ChooseHeroWindow.xaml"
                    this.btnVampire.Click += new System.Windows.RoutedEventHandler(this.btnVampire_Click);

#line default
#line hidden
                    return;
                case 6:
                    this.btnGirl = ((System.Windows.Controls.Button)(target));

#line 118 "..\..\ChooseHeroWindow.xaml"
                    this.btnGirl.Click += new System.Windows.RoutedEventHandler(this.btnGirl_Click);

#line default
#line hidden
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.Label lblAttack;
        internal System.Windows.Controls.Label lblAttack_Copy;
        internal System.Windows.Controls.Label lblAttack_Copy1;
        internal System.Windows.Controls.Label lblAttack_Copy2;
        internal System.Windows.Controls.Label lblAttack_Copy3;
        internal System.Windows.Controls.Label lblAttack_Copy4;
        internal System.Windows.Controls.Label lblAttack_Copy5;
        internal System.Windows.Controls.Label lblAttack_Copy6;
        internal System.Windows.Controls.Label lblAttack_Copy7;
        internal System.Windows.Controls.Label lblAttack_Copy8;
        internal System.Windows.Controls.Label lblAttack_Copy9;
        internal System.Windows.Controls.Label lblAttack_Copy10;
        internal System.Windows.Controls.Label lblAttack_Copy11;
        internal System.Windows.Controls.Label lblAttack_Copy12;
        internal System.Windows.Controls.Label lblAttack_Copy13;
    }
}

