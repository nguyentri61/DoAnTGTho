﻿#pragma checksum "..\..\..\..\UControls\UCTimViec.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47DFB7DC62238481B67B955DB060A38FD05631EB"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DoAnTGVL.UControls;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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


namespace DoAnTGVL.UControls {
    
    
    /// <summary>
    /// UCTimViec
    /// </summary>
    public partial class UCTimViec : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 29 "..\..\..\..\UControls\UCTimViec.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_reload;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\UControls\UCTimViec.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cboKhuVuc;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\..\UControls\UCTimViec.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cboKinhNghiem;
        
        #line default
        #line hidden
        
        
        #line 111 "..\..\..\..\UControls\UCTimViec.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbTimKiem;
        
        #line default
        #line hidden
        
        
        #line 138 "..\..\..\..\UControls\UCTimViec.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gridPage;
        
        #line default
        #line hidden
        
        
        #line 141 "..\..\..\..\UControls\UCTimViec.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.WrapPanel WpanelDanhS;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.2.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/DoAnTGVL;component/ucontrols/uctimviec.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\UControls\UCTimViec.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.2.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 27 "..\..\..\..\UControls\UCTimViec.xaml"
            ((System.Windows.Controls.Primitives.ToggleButton)(target)).Click += new System.Windows.RoutedEventHandler(this.ToggleButton_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btn_reload = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\..\UControls\UCTimViec.xaml"
            this.btn_reload.Click += new System.Windows.RoutedEventHandler(this.btn_reload_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.cboKhuVuc = ((System.Windows.Controls.ComboBox)(target));
            
            #line 39 "..\..\..\..\UControls\UCTimViec.xaml"
            this.cboKhuVuc.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.fil_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.cboKinhNghiem = ((System.Windows.Controls.ComboBox)(target));
            
            #line 80 "..\..\..\..\UControls\UCTimViec.xaml"
            this.cboKinhNghiem.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.fil_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.txbTimKiem = ((System.Windows.Controls.TextBox)(target));
            
            #line 119 "..\..\..\..\UControls\UCTimViec.xaml"
            this.txbTimKiem.KeyUp += new System.Windows.Input.KeyEventHandler(this.txbTimKiem_KeyUp);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 123 "..\..\..\..\UControls\UCTimViec.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnUploadProfile_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.gridPage = ((System.Windows.Controls.Grid)(target));
            return;
            case 8:
            this.WpanelDanhS = ((System.Windows.Controls.WrapPanel)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

