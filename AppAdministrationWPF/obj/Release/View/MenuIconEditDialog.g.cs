﻿#pragma checksum "..\..\..\View\MenuIconEditDialog.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9E6EAE752654357E6EC775152A941DAD495C2F777D1F28D33624A1A2C539737A"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using AppAdministrationWPF.View;
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
using Xceed.Wpf.Toolkit;
using Xceed.Wpf.Toolkit.Chromes;
using Xceed.Wpf.Toolkit.Core.Converters;
using Xceed.Wpf.Toolkit.Core.Input;
using Xceed.Wpf.Toolkit.Core.Media;
using Xceed.Wpf.Toolkit.Core.Utilities;
using Xceed.Wpf.Toolkit.Panels;
using Xceed.Wpf.Toolkit.Primitives;
using Xceed.Wpf.Toolkit.PropertyGrid;
using Xceed.Wpf.Toolkit.PropertyGrid.Attributes;
using Xceed.Wpf.Toolkit.PropertyGrid.Commands;
using Xceed.Wpf.Toolkit.PropertyGrid.Converters;
using Xceed.Wpf.Toolkit.PropertyGrid.Editors;
using Xceed.Wpf.Toolkit.Zoombox;


namespace AppAdministrationWPF.View {
    
    
    /// <summary>
    /// MenuIconEditDialog
    /// </summary>
    public partial class MenuIconEditDialog : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 39 "..\..\..\View\MenuIconEditDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel stckPreview;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\View\MenuIconEditDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imagePreview;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\View\MenuIconEditDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labelPreview;
        
        #line default
        #line hidden
        
        
        #line 111 "..\..\..\View\MenuIconEditDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtImageURI;
        
        #line default
        #line hidden
        
        
        #line 114 "..\..\..\View\MenuIconEditDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonSearchFile;
        
        #line default
        #line hidden
        
        
        #line 127 "..\..\..\View\MenuIconEditDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Xceed.Wpf.Toolkit.ColorPicker ClrPcker_Background;
        
        #line default
        #line hidden
        
        
        #line 137 "..\..\..\View\MenuIconEditDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtImageLabelFR;
        
        #line default
        #line hidden
        
        
        #line 149 "..\..\..\View\MenuIconEditDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtImageLabelCAT;
        
        #line default
        #line hidden
        
        
        #line 161 "..\..\..\View\MenuIconEditDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtImageLabelEN;
        
        #line default
        #line hidden
        
        
        #line 173 "..\..\..\View\MenuIconEditDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtImageLabelES;
        
        #line default
        #line hidden
        
        
        #line 185 "..\..\..\View\MenuIconEditDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtImageLabelDE;
        
        #line default
        #line hidden
        
        
        #line 200 "..\..\..\View\MenuIconEditDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonValidate;
        
        #line default
        #line hidden
        
        
        #line 206 "..\..\..\View\MenuIconEditDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonCancel;
        
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
            System.Uri resourceLocater = new System.Uri("/AppAdministrationWPF;component/view/menuiconeditdialog.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\MenuIconEditDialog.xaml"
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
            this.stckPreview = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 2:
            this.imagePreview = ((System.Windows.Controls.Image)(target));
            return;
            case 3:
            this.labelPreview = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.txtImageURI = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.buttonSearchFile = ((System.Windows.Controls.Button)(target));
            
            #line 120 "..\..\..\View\MenuIconEditDialog.xaml"
            this.buttonSearchFile.Click += new System.Windows.RoutedEventHandler(this.buttonSearchFile_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ClrPcker_Background = ((Xceed.Wpf.Toolkit.ColorPicker)(target));
            
            #line 127 "..\..\..\View\MenuIconEditDialog.xaml"
            this.ClrPcker_Background.SelectedColorChanged += new System.Windows.RoutedPropertyChangedEventHandler<System.Nullable<System.Windows.Media.Color>>(this.ClrPcker_Background_SelectedColorChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.txtImageLabelFR = ((System.Windows.Controls.TextBox)(target));
            
            #line 138 "..\..\..\View\MenuIconEditDialog.xaml"
            this.txtImageLabelFR.KeyDown += new System.Windows.Input.KeyEventHandler(this.updateLabelPreview);
            
            #line default
            #line hidden
            
            #line 139 "..\..\..\View\MenuIconEditDialog.xaml"
            this.txtImageLabelFR.KeyUp += new System.Windows.Input.KeyEventHandler(this.updateLabelPreview);
            
            #line default
            #line hidden
            return;
            case 8:
            this.txtImageLabelCAT = ((System.Windows.Controls.TextBox)(target));
            
            #line 150 "..\..\..\View\MenuIconEditDialog.xaml"
            this.txtImageLabelCAT.KeyDown += new System.Windows.Input.KeyEventHandler(this.updateLabelPreview);
            
            #line default
            #line hidden
            
            #line 151 "..\..\..\View\MenuIconEditDialog.xaml"
            this.txtImageLabelCAT.KeyUp += new System.Windows.Input.KeyEventHandler(this.updateLabelPreview);
            
            #line default
            #line hidden
            return;
            case 9:
            this.txtImageLabelEN = ((System.Windows.Controls.TextBox)(target));
            
            #line 162 "..\..\..\View\MenuIconEditDialog.xaml"
            this.txtImageLabelEN.KeyDown += new System.Windows.Input.KeyEventHandler(this.updateLabelPreview);
            
            #line default
            #line hidden
            
            #line 163 "..\..\..\View\MenuIconEditDialog.xaml"
            this.txtImageLabelEN.KeyUp += new System.Windows.Input.KeyEventHandler(this.updateLabelPreview);
            
            #line default
            #line hidden
            return;
            case 10:
            this.txtImageLabelES = ((System.Windows.Controls.TextBox)(target));
            
            #line 174 "..\..\..\View\MenuIconEditDialog.xaml"
            this.txtImageLabelES.KeyDown += new System.Windows.Input.KeyEventHandler(this.updateLabelPreview);
            
            #line default
            #line hidden
            
            #line 175 "..\..\..\View\MenuIconEditDialog.xaml"
            this.txtImageLabelES.KeyUp += new System.Windows.Input.KeyEventHandler(this.updateLabelPreview);
            
            #line default
            #line hidden
            return;
            case 11:
            this.txtImageLabelDE = ((System.Windows.Controls.TextBox)(target));
            
            #line 186 "..\..\..\View\MenuIconEditDialog.xaml"
            this.txtImageLabelDE.KeyDown += new System.Windows.Input.KeyEventHandler(this.updateLabelPreview);
            
            #line default
            #line hidden
            
            #line 187 "..\..\..\View\MenuIconEditDialog.xaml"
            this.txtImageLabelDE.KeyUp += new System.Windows.Input.KeyEventHandler(this.updateLabelPreview);
            
            #line default
            #line hidden
            return;
            case 12:
            this.buttonValidate = ((System.Windows.Controls.Button)(target));
            
            #line 202 "..\..\..\View\MenuIconEditDialog.xaml"
            this.buttonValidate.Click += new System.Windows.RoutedEventHandler(this.buttonValidate_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.buttonCancel = ((System.Windows.Controls.Button)(target));
            
            #line 208 "..\..\..\View\MenuIconEditDialog.xaml"
            this.buttonCancel.Click += new System.Windows.RoutedEventHandler(this.buttonCancel_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
