﻿#pragma checksum "..\..\..\..\Windows\AddRecipeWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "41B11EEB65C10708C74C317128B416C1C2FD6A5E"
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
    /// AddRecipeWindow
    /// </summary>
    public partial class AddRecipeWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 51 "..\..\..\..\Windows\AddRecipeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtName;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\..\Windows\AddRecipeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtIngridients;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\..\Windows\AddRecipeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddIngredient;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\..\Windows\AddRecipeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lvIngredients;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\..\..\Windows\AddRecipeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtQuantity;
        
        #line default
        #line hidden
        
        
        #line 119 "..\..\..\..\Windows\AddRecipeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtTags;
        
        #line default
        #line hidden
        
        
        #line 126 "..\..\..\..\Windows\AddRecipeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddTag;
        
        #line default
        #line hidden
        
        
        #line 133 "..\..\..\..\Windows\AddRecipeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lvTags;
        
        #line default
        #line hidden
        
        
        #line 139 "..\..\..\..\Windows\AddRecipeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSaveRecipe;
        
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
            System.Uri resourceLocater = new System.Uri("/YellowCarrot;component/windows/addrecipewindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Windows\AddRecipeWindow.xaml"
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
            this.txtIngridients = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.btnAddIngredient = ((System.Windows.Controls.Button)(target));
            
            #line 76 "..\..\..\..\Windows\AddRecipeWindow.xaml"
            this.btnAddIngredient.Click += new System.Windows.RoutedEventHandler(this.btnAddIngredient_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.lvIngredients = ((System.Windows.Controls.ListView)(target));
            return;
            case 5:
            this.txtQuantity = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.txtTags = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.btnAddTag = ((System.Windows.Controls.Button)(target));
            
            #line 131 "..\..\..\..\Windows\AddRecipeWindow.xaml"
            this.btnAddTag.Click += new System.Windows.RoutedEventHandler(this.btnAddTag_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.lvTags = ((System.Windows.Controls.ListView)(target));
            return;
            case 9:
            this.btnSaveRecipe = ((System.Windows.Controls.Button)(target));
            
            #line 145 "..\..\..\..\Windows\AddRecipeWindow.xaml"
            this.btnSaveRecipe.Click += new System.Windows.RoutedEventHandler(this.btnSaveRecipe_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

