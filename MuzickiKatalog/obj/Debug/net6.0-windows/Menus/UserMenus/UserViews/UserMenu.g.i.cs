﻿#pragma checksum "..\..\..\..\..\..\Menus\UserMenus\UserViews\UserMenu.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "06F36E1BBA239549DED02A91823A003844BBF4DE"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MuzickiKatalog.Menus.UserMenus.UserViews;
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


namespace MuzickiKatalog.Menus.UserMenus.UserViews {
    
    
    /// <summary>
    /// UserMenu
    /// </summary>
    public partial class UserMenu : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\..\..\..\Menus\UserMenus\UserViews\UserMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button logoutButon;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\..\..\..\Menus\UserMenus\UserViews\UserMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SearchBox;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\..\..\..\Menus\UserMenus\UserViews\UserMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid tableDataGrid;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\..\..\Menus\UserMenus\UserViews\UserMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button searchButton;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\..\..\Menus\UserMenus\UserViews\UserMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label emailText;
        
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
            System.Uri resourceLocater = new System.Uri("/MuzickiKatalog;component/menus/usermenus/userviews/usermenu.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\Menus\UserMenus\UserViews\UserMenu.xaml"
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
            this.logoutButon = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\..\..\..\Menus\UserMenus\UserViews\UserMenu.xaml"
            this.logoutButon.Click += new System.Windows.RoutedEventHandler(this.logoutButon_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.SearchBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.tableDataGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 17 "..\..\..\..\..\..\Menus\UserMenus\UserViews\UserMenu.xaml"
            this.tableDataGrid.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.tableDataGrid_MouseDoubleClick_1);
            
            #line default
            #line hidden
            return;
            case 4:
            this.searchButton = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\..\..\..\Menus\UserMenus\UserViews\UserMenu.xaml"
            this.searchButton.Click += new System.Windows.RoutedEventHandler(this.searchButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.emailText = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

