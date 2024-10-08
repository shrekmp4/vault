﻿#pragma checksum "..\..\..\ReportWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6CE21FAF2B693CE65ECBD04EC48043271DE1CD93"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using FullControls.Common;
using FullControls.Controls;
using FullControls.SystemComponents;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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
using Vault.Properties;


namespace Vault {
    
    
    /// <summary>
    /// ReportWindow
    /// </summary>
    public partial class ReportWindow : FullControls.SystemComponents.AvalonWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 73 "..\..\..\ReportWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ReportTotal;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\..\ReportWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ReportDuplicated;
        
        #line default
        #line hidden
        
        
        #line 129 "..\..\..\ReportWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock WeakPasswordsLink;
        
        #line default
        #line hidden
        
        
        #line 136 "..\..\..\ReportWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ReportWeak;
        
        #line default
        #line hidden
        
        
        #line 167 "..\..\..\ReportWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ReportOld;
        
        #line default
        #line hidden
        
        
        #line 197 "..\..\..\ReportWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ReportViolated;
        
        #line default
        #line hidden
        
        
        #line 239 "..\..\..\ReportWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ReportScore;
        
        #line default
        #line hidden
        
        
        #line 258 "..\..\..\ReportWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal FullControls.Controls.ButtonPlus NewReport;
        
        #line default
        #line hidden
        
        
        #line 281 "..\..\..\ReportWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ReportDate;
        
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
            System.Uri resourceLocater = new System.Uri("/Vault;V1.0.0.0;component/reportwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ReportWindow.xaml"
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
            
            #line 16 "..\..\..\ReportWindow.xaml"
            ((Vault.ReportWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ReportTotal = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.ReportDuplicated = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.WeakPasswordsLink = ((System.Windows.Controls.TextBlock)(target));
            
            #line 134 "..\..\..\ReportWindow.xaml"
            this.WeakPasswordsLink.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.WeakPasswordsLink_MouseDown);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ReportWeak = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.ReportOld = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.ReportViolated = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.ReportScore = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.NewReport = ((FullControls.Controls.ButtonPlus)(target));
            
            #line 266 "..\..\..\ReportWindow.xaml"
            this.NewReport.Click += new System.Windows.RoutedEventHandler(this.NewReport_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.ReportDate = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

