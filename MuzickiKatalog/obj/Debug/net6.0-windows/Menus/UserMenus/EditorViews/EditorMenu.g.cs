﻿#pragma checksum "..\..\..\..\..\..\Menus\UserMenus\EditorViews\EditorMenu.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2CEEC7BB5B182610AF8E17053C1C79510497B61E"
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
    /// EditorMenu
    /// </summary>
    public partial class EditorMenu : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\..\..\..\Menus\UserMenus\EditorViews\EditorMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button backButton;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\..\..\..\Menus\UserMenus\EditorViews\EditorMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addTrack;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\..\..\..\Menus\UserMenus\EditorViews\EditorMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addAlbum;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\..\..\..\Menus\UserMenus\EditorViews\EditorMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addArtist;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\..\..\..\Menus\UserMenus\EditorViews\EditorMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addBand;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.3.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/MuzickiKatalog;component/menus/usermenus/editorviews/editormenu.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\Menus\UserMenus\EditorViews\EditorMenu.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.3.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.backButton = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\..\..\..\..\Menus\UserMenus\EditorViews\EditorMenu.xaml"
            this.backButton.Click += new System.Windows.RoutedEventHandler(this.backButton_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.addTrack = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\..\..\..\..\Menus\UserMenus\EditorViews\EditorMenu.xaml"
            this.addTrack.Click += new System.Windows.RoutedEventHandler(this.addTrack_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.addAlbum = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\..\..\..\..\Menus\UserMenus\EditorViews\EditorMenu.xaml"
            this.addAlbum.Click += new System.Windows.RoutedEventHandler(this.addAlbum_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.addArtist = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\..\..\..\Menus\UserMenus\EditorViews\EditorMenu.xaml"
            this.addArtist.Click += new System.Windows.RoutedEventHandler(this.addArtist_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.addBand = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\..\..\..\..\Menus\UserMenus\EditorViews\EditorMenu.xaml"
            this.addBand.Click += new System.Windows.RoutedEventHandler(this.addBand_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

