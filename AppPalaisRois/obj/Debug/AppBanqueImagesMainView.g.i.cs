﻿#pragma checksum "..\..\AppBanqueImagesMainView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "348AB1FD9F7AD5CEBF8C1208541FF74B370C7FE0A19F7B6B2320B8F1902506D0"
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
    /// AppBanqueImagesMainView
    /// </summary>
    public partial class AppBanqueImagesMainView : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 8 "..\..\AppBanqueImagesMainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal AppPalaisRois.AppBanqueImagesMainView BanqueImages;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\AppBanqueImagesMainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid BanqueImagesPanel;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\AppBanqueImagesMainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imageFond;
        
        #line default
        #line hidden
        
        
        #line 124 "..\..\AppBanqueImagesMainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal FluidKit.Controls.ElementFlow flowCarte;
        
        #line default
        #line hidden
        
        
        #line 138 "..\..\AppBanqueImagesMainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.Media3D.PerspectiveCamera camera;
        
        #line default
        #line hidden
        
        
        #line 166 "..\..\AppBanqueImagesMainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Quit_button;
        
        #line default
        #line hidden
        
        
        #line 179 "..\..\AppBanqueImagesMainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image returnBanqueImages;
        
        #line default
        #line hidden
        
        
        #line 194 "..\..\AppBanqueImagesMainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox listboxMaps;
        
        #line default
        #line hidden
        
        
        #line 215 "..\..\AppBanqueImagesMainView.xaml"
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
            System.Uri resourceLocater = new System.Uri("/AppPalaisRois;component/appbanqueimagesmainview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AppBanqueImagesMainView.xaml"
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
            this.BanqueImages = ((AppPalaisRois.AppBanqueImagesMainView)(target));
            return;
            case 3:
            this.BanqueImagesPanel = ((System.Windows.Controls.Grid)(target));
            return;
            case 4:
            this.imageFond = ((System.Windows.Controls.Image)(target));
            return;
            case 5:
            this.flowCarte = ((FluidKit.Controls.ElementFlow)(target));
            
            #line 130 "..\..\AppBanqueImagesMainView.xaml"
            this.flowCarte.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.disableSelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.camera = ((System.Windows.Media.Media3D.PerspectiveCamera)(target));
            return;
            case 7:
            this.Quit_button = ((System.Windows.Controls.Button)(target));
            
            #line 175 "..\..\AppBanqueImagesMainView.xaml"
            this.Quit_button.Click += new System.Windows.RoutedEventHandler(this.BoutonQuit_click);
            
            #line default
            #line hidden
            
            #line 176 "..\..\AppBanqueImagesMainView.xaml"
            this.Quit_button.TouchDown += new System.EventHandler<System.Windows.Input.TouchEventArgs>(this.BoutonQuit_click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.returnBanqueImages = ((System.Windows.Controls.Image)(target));
            return;
            case 9:
            this.listboxMaps = ((System.Windows.Controls.ListBox)(target));
            
            #line 203 "..\..\AppBanqueImagesMainView.xaml"
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
            
            #line 89 "..\..\AppBanqueImagesMainView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.selectOne);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

