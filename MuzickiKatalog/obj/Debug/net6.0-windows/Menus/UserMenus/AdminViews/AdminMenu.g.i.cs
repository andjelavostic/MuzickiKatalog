﻿#pragma checksum "..\..\..\..\..\..\Menus\UserMenus\AdminViews\AdminMenu.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "506C0D084F31E64A9E020C66132D70511DA3EB9C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MuzickiKatalog;
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


namespace MuzickiKatalog {
    
    
    /// <summary>
    /// AdminMenu
    /// </summary>
    public partial class AdminMenu : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\..\..\..\Menus\UserMenus\AdminViews\AdminMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addTrackButton;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\..\..\..\Menus\UserMenus\AdminViews\AdminMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addAlbumButton;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\..\..\..\Menus\UserMenus\AdminViews\AdminMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addArtistButton;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\..\..\..\Menus\UserMenus\AdminViews\AdminMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addBandButton;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\..\..\Menus\UserMenus\AdminViews\AdminMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addGenre;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.3.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/MuzickiKatalog;V1.0.0.0;component/menus/usermenus/adminviews/adminmenu.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\Menus\UserMenus\AdminViews\AdminMenu.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.3.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.addTrackButton = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\..\..\..\..\Menus\UserMenus\AdminViews\AdminMenu.xaml"
            this.addTrackButton.Click += new System.Windows.RoutedEventHandler(this.addTrackButton_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.addAlbumButton = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\..\..\..\..\Menus\UserMenus\AdminViews\AdminMenu.xaml"
            this.addAlbumButton.Click += new System.Windows.RoutedEventHandler(this.addAlbumButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.addArtistButton = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\..\..\..\Menus\UserMenus\AdminViews\AdminMenu.xaml"
            this.addArtistButton.Click += new System.Windows.RoutedEventHandler(this.addArtistButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.addBandButton = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\..\..\..\..\Menus\UserMenus\AdminViews\AdminMenu.xaml"
            this.addBandButton.Click += new System.Windows.RoutedEventHandler(this.addBandButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.addGenre = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\..\..\..\..\Menus\UserMenus\AdminViews\AdminMenu.xaml"
            this.addGenre.Click += new System.Windows.RoutedEventHandler(this.addGenre_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

