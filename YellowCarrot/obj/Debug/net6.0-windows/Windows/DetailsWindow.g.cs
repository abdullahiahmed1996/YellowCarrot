#pragma checksum "..\..\..\..\Windows\DetailsWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1931FBD9D12117B9738F0BBE1722B449DC011F63"
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
using YellowCarrot.Windows;


namespace YellowCarrot.Windows {
    
    
    /// <summary>
    /// DetailsWindow
    /// </summary>
    public partial class DetailsWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 48 "..\..\..\..\Windows\DetailsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtName;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\..\Windows\DetailsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lvIngridients;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\..\Windows\DetailsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSave;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\..\..\Windows\DetailsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnUnlock;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\..\..\Windows\DetailsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDeleteIngredient;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\..\..\Windows\DetailsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView txtTags;
        
        #line default
        #line hidden
        
        
        #line 120 "..\..\..\..\Windows\DetailsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtnewRecipeName;
        
        #line default
        #line hidden
        
        
        #line 130 "..\..\..\..\Windows\DetailsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnNewRecipeName;
        
        #line default
        #line hidden
        
        
        #line 148 "..\..\..\..\Windows\DetailsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNewIngredient;
        
        #line default
        #line hidden
        
        
        #line 151 "..\..\..\..\Windows\DetailsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddNewIngredient;
        
        #line default
        #line hidden
        
        
        #line 159 "..\..\..\..\Windows\DetailsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnExit;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.10.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/YellowCarrot;component/windows/detailswindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Windows\DetailsWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.10.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.txtName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.lvIngridients = ((System.Windows.Controls.ListView)(target));
            
            #line 71 "..\..\..\..\Windows\DetailsWindow.xaml"
            this.lvIngridients.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.lvIngridients_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnSave = ((System.Windows.Controls.Button)(target));
            
            #line 79 "..\..\..\..\Windows\DetailsWindow.xaml"
            this.btnSave.Click += new System.Windows.RoutedEventHandler(this.btnSave_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnUnlock = ((System.Windows.Controls.Button)(target));
            
            #line 86 "..\..\..\..\Windows\DetailsWindow.xaml"
            this.btnUnlock.Click += new System.Windows.RoutedEventHandler(this.btnUnlock_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnDeleteIngredient = ((System.Windows.Controls.Button)(target));
            
            #line 95 "..\..\..\..\Windows\DetailsWindow.xaml"
            this.btnDeleteIngredient.Click += new System.Windows.RoutedEventHandler(this.btnDeleteIngredient_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.txtTags = ((System.Windows.Controls.ListView)(target));
            return;
            case 7:
            this.txtnewRecipeName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.btnNewRecipeName = ((System.Windows.Controls.Button)(target));
            
            #line 136 "..\..\..\..\Windows\DetailsWindow.xaml"
            this.btnNewRecipeName.Click += new System.Windows.RoutedEventHandler(this.btnNewRecipeName_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.txtNewIngredient = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.btnAddNewIngredient = ((System.Windows.Controls.Button)(target));
            
            #line 156 "..\..\..\..\Windows\DetailsWindow.xaml"
            this.btnAddNewIngredient.Click += new System.Windows.RoutedEventHandler(this.btnAddNewIngredient_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.btnExit = ((System.Windows.Controls.Button)(target));
            
            #line 164 "..\..\..\..\Windows\DetailsWindow.xaml"
            this.btnExit.Click += new System.Windows.RoutedEventHandler(this.btnExit_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

