﻿#pragma checksum "..\..\..\..\..\Menus\ContentViews\TrackView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "EEFB8A8C09ADD2B2855A2E9A5B33F84AA6C91E34"
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
    /// TrackView
    /// </summary>
    public partial class TrackView : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\..\..\Menus\ContentViews\TrackView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock DesctiptionTextBlock;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\..\..\Menus\ContentViews\TrackView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label userRatingLabel;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\..\..\Menus\ContentViews\TrackView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label editorsRatingLabel;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\..\Menus\ContentViews\TrackView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ratingComboBox;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\..\..\Menus\ContentViews\TrackView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ratingButton;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\..\Menus\ContentViews\TrackView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RichTextBox reviewTextBox;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\..\Menus\ContentViews\TrackView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button reviewButton;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\..\Menus\ContentViews\TrackView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock editorsReviewTextBlock;
        
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
            System.Uri resourceLocater = new System.Uri("/MuzickiKatalog;component/menus/contentviews/trackview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Menus\ContentViews\TrackView.xaml"
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
            this.DesctiptionTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.userRatingLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.editorsRatingLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.ratingComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.ratingButton = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\..\..\Menus\ContentViews\TrackView.xaml"
            this.ratingButton.Click += new System.Windows.RoutedEventHandler(this.ratingButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.reviewTextBox = ((System.Windows.Controls.RichTextBox)(target));
            return;
            case 7:
            this.reviewButton = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\..\..\Menus\ContentViews\TrackView.xaml"
            this.reviewButton.Click += new System.Windows.RoutedEventHandler(this.reviewButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.editorsReviewTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            
            #line 30 "..\..\..\..\..\Menus\ContentViews\TrackView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

