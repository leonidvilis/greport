﻿#pragma checksum "..\..\..\Views\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "F8601B05653BD728D7A816E69318F22536DBAA63"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using GetReport.Views;
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


namespace GetReport.Views {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Controls.Ribbon.RibbonWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 45 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Ribbon.Ribbon RibbonWin;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Ribbon.RibbonButton Save;
        
        #line default
        #line hidden
        
        
        #line 108 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Ribbon.RibbonGroup ClipboardGroup;
        
        #line default
        #line hidden
        
        
        #line 129 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Ribbon.RibbonGroup Report;
        
        #line default
        #line hidden
        
        
        #line 142 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Ribbon.RibbonCheckBox Expand1;
        
        #line default
        #line hidden
        
        
        #line 144 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Ribbon.RibbonCheckBox Expand2;
        
        #line default
        #line hidden
        
        
        #line 146 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Ribbon.RibbonCheckBox Expand3;
        
        #line default
        #line hidden
        
        
        #line 160 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Ribbon.RibbonGroup Export;
        
        #line default
        #line hidden
        
        
        #line 183 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ScrollViewer scvwr;
        
        #line default
        #line hidden
        
        
        #line 186 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox sessionReportList;
        
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
            System.Uri resourceLocater = new System.Uri("/GetReport;component/views/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\MainWindow.xaml"
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
            this.RibbonWin = ((System.Windows.Controls.Ribbon.Ribbon)(target));
            return;
            case 2:
            
            #line 53 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Ribbon.RibbonButton)(target)).Click += new System.Windows.RoutedEventHandler(this.RibbonButtonInfo_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Save = ((System.Windows.Controls.Ribbon.RibbonButton)(target));
            return;
            case 4:
            
            #line 79 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Ribbon.RibbonApplicationMenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.RibbonButtonNewSession_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 84 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Ribbon.RibbonApplicationMenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.RibbonButtonOpen_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 89 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Ribbon.RibbonApplicationMenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.RibbonButtonSave_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ClipboardGroup = ((System.Windows.Controls.Ribbon.RibbonGroup)(target));
            return;
            case 8:
            
            #line 110 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Ribbon.RibbonButton)(target)).Click += new System.Windows.RoutedEventHandler(this.RibbonButtonNewSession_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 116 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Ribbon.RibbonButton)(target)).Click += new System.Windows.RoutedEventHandler(this.RibbonButtonOpen_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 122 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Ribbon.RibbonButton)(target)).Click += new System.Windows.RoutedEventHandler(this.RibbonButtonSave_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.Report = ((System.Windows.Controls.Ribbon.RibbonGroup)(target));
            return;
            case 12:
            
            #line 131 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Ribbon.RibbonButton)(target)).Click += new System.Windows.RoutedEventHandler(this.RibbonButtonAddReport_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 137 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Ribbon.RibbonButton)(target)).Click += new System.Windows.RoutedEventHandler(this.RibbonButtonRemoveReport_Click);
            
            #line default
            #line hidden
            return;
            case 14:
            this.Expand1 = ((System.Windows.Controls.Ribbon.RibbonCheckBox)(target));
            return;
            case 15:
            this.Expand2 = ((System.Windows.Controls.Ribbon.RibbonCheckBox)(target));
            return;
            case 16:
            this.Expand3 = ((System.Windows.Controls.Ribbon.RibbonCheckBox)(target));
            return;
            case 17:
            this.Export = ((System.Windows.Controls.Ribbon.RibbonGroup)(target));
            return;
            case 18:
            
            #line 164 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Ribbon.RibbonButton)(target)).Click += new System.Windows.RoutedEventHandler(this.RibbonButtonPublishWord_Click);
            
            #line default
            #line hidden
            return;
            case 19:
            this.scvwr = ((System.Windows.Controls.ScrollViewer)(target));
            return;
            case 20:
            this.sessionReportList = ((System.Windows.Controls.ListBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

