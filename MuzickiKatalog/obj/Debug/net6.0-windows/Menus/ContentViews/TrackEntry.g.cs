﻿#pragma checksum "..\..\..\..\..\Menus\ContentViews\TrackEntry.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5738379AD84AF82E35F6E2D79BADED02197F210D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MuzickiKatalog.Menus.ContentViews;
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


namespace MuzickiKatalog.Menus.ContentViews {
    
    
    /// <summary>
    /// TrackEntry
    /// </summary>
    public partial class TrackEntry : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\..\..\Menus\ContentViews\TrackEntry.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox nazivText;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\..\Menus\ContentViews\TrackEntry.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox trajanjeText;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\..\..\Menus\ContentViews\TrackEntry.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox slikaText;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\..\..\Menus\ContentViews\TrackEntry.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox zanrText;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\..\Menus\ContentViews\TrackEntry.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Documents.Run opisText;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\..\Menus\ContentViews\TrackEntry.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox izvodjacText;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\..\Menus\ContentViews\TrackEntry.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addButton;
        
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
            System.Uri resourceLocater = new System.Uri("/MuzickiKatalog;component/menus/contentviews/trackentry.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Menus\ContentViews\TrackEntry.xaml"
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
            this.nazivText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.trajanjeText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.slikaText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.zanrText = ((System.Windows.Controls.ListBox)(target));
            return;
            case 5:
            this.opisText = ((System.Windows.Documents.Run)(target));
            return;
            case 6:
            this.izvodjacText = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.addButton = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\..\..\Menus\ContentViews\TrackEntry.xaml"
            this.addButton.Click += new System.Windows.RoutedEventHandler(this.addButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

