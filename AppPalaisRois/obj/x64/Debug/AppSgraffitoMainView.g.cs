﻿#pragma checksum "..\..\..\AppSgraffitoMainView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "94B7DD077B0C632194A232DAECC4FF1413F3FD9E9DB3B56FF87D6A5F4C2C8537"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using FluidKit.Controls;
using Microsoft.Surface.Presentation;
using Microsoft.Surface.Presentation.Controls;
using Microsoft.Surface.Presentation.Controls.Primitives;
using Microsoft.Surface.Presentation.Controls.TouchVisualizations;
using Microsoft.Surface.Presentation.Input;
using Microsoft.Surface.Presentation.Palettes;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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


namespace AppPalaisRois {
    
    
    /// <summary>
    /// AppSgraffitoMainView
    /// </summary>
    public partial class AppSgraffitoMainView : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 8 "..\..\..\AppSgraffitoMainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal AppPalaisRois.AppSgraffitoMainView Sgraffito;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\..\AppSgraffitoMainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid SgraffitoPanel;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\..\AppSgraffitoMainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imageFond;
        
        #line default
        #line hidden
        
        
        #line 124 "..\..\..\AppSgraffitoMainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal FluidKit.Controls.ElementFlow flowCarte;
        
        #line default
        #line hidden
        
        
        #line 138 "..\..\..\AppSgraffitoMainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.Media3D.PerspectiveCamera camera;
        
        #line default
        #line hidden
        
        
        #line 166 "..\..\..\AppSgraffitoMainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Quit_button;
        
        #line default
        #line hidden
        
        
        #line 179 "..\..\..\AppSgraffitoMainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image returnSgraffito;
        
        #line default
        #line hidden
        
        
        #line 194 "..\..\..\AppSgraffitoMainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox listboxMaps;
        
        #line default
        #line hidden
        
        
        #line 215 "..\..\..\AppSgraffitoMainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Microsoft.Surface.Presentation.Controls.ScatterView ScatterView;
        
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
            System.Uri resourceLocater = new System.Uri("/AppPalaisRois;component/appsgraffitomainview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\AppSgraffitoMainView.xaml"
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
            this.Sgraffito = ((AppPalaisRois.AppSgraffitoMainView)(target));
            return;
            case 3:
            this.SgraffitoPanel = ((System.Windows.Controls.Grid)(target));
            return;
            case 4:
            this.imageFond = ((System.Windows.Controls.Image)(target));
            return;
            case 5:
            this.flowCarte = ((FluidKit.Controls.ElementFlow)(target));
            
            #line 130 "..\..\..\AppSgraffitoMainView.xaml"
            this.flowCarte.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.disableSelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.camera = ((System.Windows.Media.Media3D.PerspectiveCamera)(target));
            return;
            case 7:
            this.Quit_button = ((System.Windows.Controls.Button)(target));
            
            #line 175 "..\..\..\AppSgraffitoMainView.xaml"
            this.Quit_button.Click += new System.Windows.RoutedEventHandler(this.BoutonQuit_click);
            
            #line default
            #line hidden
            
            #line 176 "..\..\..\AppSgraffitoMainView.xaml"
            this.Quit_button.TouchDown += new System.EventHandler<System.Windows.Input.TouchEventArgs>(this.BoutonQuit_click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.returnSgraffito = ((System.Windows.Controls.Image)(target));
            return;
            case 9:
            this.listboxMaps = ((System.Windows.Controls.ListBox)(target));
            
            #line 203 "..\..\..\AppSgraffitoMainView.xaml"
            this.listboxMaps.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.mapSelection);
            
            #line default
            #line hidden
            return;
            case 10:
            this.ScatterView = ((Microsoft.Surface.Presentation.Controls.ScatterView)(target));
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 2:
            
            #line 89 "..\..\..\AppSgraffitoMainView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.selectOne);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

