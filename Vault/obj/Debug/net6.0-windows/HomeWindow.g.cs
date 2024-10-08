﻿#pragma checksum "..\..\..\HomeWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "AFAC18E2816AF2724C750B673C03837B6B0E2521"
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
using Vault.Core.Controls;
using Vault.Properties;


namespace Vault {
    
    
    /// <summary>
    /// HomeWindow
    /// </summary>
    public partial class HomeWindow : FullControls.SystemComponents.AvalonWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 52 "..\..\..\HomeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal FullControls.Controls.TextBoxPlus Search;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\HomeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal FullControls.Controls.Switcher ShowPasswords;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\HomeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal FullControls.Controls.Switcher ShowNotes;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\..\HomeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal FullControls.Controls.Switcher ShowCards;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\..\HomeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal FullControls.Controls.Switcher ShowDocuments;
        
        #line default
        #line hidden
        
        
        #line 117 "..\..\..\HomeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal FullControls.Controls.ButtonPlus ShowCategories;
        
        #line default
        #line hidden
        
        
        #line 132 "..\..\..\HomeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal FullControls.Controls.ButtonPlus ShowReport;
        
        #line default
        #line hidden
        
        
        #line 142 "..\..\..\HomeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal FullControls.Controls.ButtonPlus ShowSettings;
        
        #line default
        #line hidden
        
        
        #line 152 "..\..\..\HomeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal FullControls.Controls.ButtonPlus ExecuteLogout;
        
        #line default
        #line hidden
        
        
        #line 177 "..\..\..\HomeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock SectionName;
        
        #line default
        #line hidden
        
        
        #line 186 "..\..\..\HomeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal FullControls.Controls.ButtonPlus Add;
        
        #line default
        #line hidden
        
        
        #line 203 "..\..\..\HomeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal FullControls.Controls.Accordion SectionList;
        
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
            System.Uri resourceLocater = new System.Uri("/Vault;component/homewindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\HomeWindow.xaml"
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
            
            #line 18 "..\..\..\HomeWindow.xaml"
            ((Vault.HomeWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            
            #line 19 "..\..\..\HomeWindow.xaml"
            ((Vault.HomeWindow)(target)).Closed += new System.EventHandler(this.Window_Closed);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Search = ((FullControls.Controls.TextBoxPlus)(target));
            
            #line 62 "..\..\..\HomeWindow.xaml"
            this.Search.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Search_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ShowPasswords = ((FullControls.Controls.Switcher)(target));
            
            #line 68 "..\..\..\HomeWindow.xaml"
            this.ShowPasswords.Checked += new System.Windows.RoutedEventHandler(this.Navigation_Switch);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ShowNotes = ((FullControls.Controls.Switcher)(target));
            
            #line 80 "..\..\..\HomeWindow.xaml"
            this.ShowNotes.Checked += new System.Windows.RoutedEventHandler(this.Navigation_Switch);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ShowCards = ((FullControls.Controls.Switcher)(target));
            
            #line 92 "..\..\..\HomeWindow.xaml"
            this.ShowCards.Checked += new System.Windows.RoutedEventHandler(this.Navigation_Switch);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ShowDocuments = ((FullControls.Controls.Switcher)(target));
            
            #line 104 "..\..\..\HomeWindow.xaml"
            this.ShowDocuments.Checked += new System.Windows.RoutedEventHandler(this.Navigation_Switch);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ShowCategories = ((FullControls.Controls.ButtonPlus)(target));
            
            #line 120 "..\..\..\HomeWindow.xaml"
            this.ShowCategories.Click += new System.Windows.RoutedEventHandler(this.ShowCategories_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.ShowReport = ((FullControls.Controls.ButtonPlus)(target));
            
            #line 135 "..\..\..\HomeWindow.xaml"
            this.ShowReport.Click += new System.Windows.RoutedEventHandler(this.ShowReport_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.ShowSettings = ((FullControls.Controls.ButtonPlus)(target));
            
            #line 145 "..\..\..\HomeWindow.xaml"
            this.ShowSettings.Click += new System.Windows.RoutedEventHandler(this.ShowSettings_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.ExecuteLogout = ((FullControls.Controls.ButtonPlus)(target));
            
            #line 155 "..\..\..\HomeWindow.xaml"
            this.ExecuteLogout.Click += new System.Windows.RoutedEventHandler(this.ExecuteLogout_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.SectionName = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 12:
            this.Add = ((FullControls.Controls.ButtonPlus)(target));
            
            #line 198 "..\..\..\HomeWindow.xaml"
            this.Add.Click += new System.Windows.RoutedEventHandler(this.Add_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.SectionList = ((FullControls.Controls.Accordion)(target));
            
            #line 204 "..\..\..\HomeWindow.xaml"
            this.SectionList.ItemIsExpandedChanged += new System.EventHandler<FullControls.Common.ItemExpandedChangedEventArgs>(this.SectionList_ItemIsExpandedChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

