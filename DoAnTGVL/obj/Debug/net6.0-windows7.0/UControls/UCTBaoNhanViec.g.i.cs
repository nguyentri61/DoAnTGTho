﻿#pragma checksum "..\..\..\..\UControls\UCTBaoNhanViec.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "BDD00FF439E1038862C5627B9ACBA51D51AAE92C"
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
    /// UCTBaoNhanViec
    /// </summary>
    public partial class UCTBaoNhanViec : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\..\UControls\UCTBaoNhanViec.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TxtTieuDe;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\UControls\UCTBaoNhanViec.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnChiTiet;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\UControls\UCTBaoNhanViec.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button nvButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.11.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/DoAnTGVL;V1.0.0.0;component/ucontrols/uctbaonhanviec.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\UControls\UCTBaoNhanViec.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.11.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.TxtTieuDe = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.btnChiTiet = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\..\UControls\UCTBaoNhanViec.xaml"
            this.btnChiTiet.Click += new System.Windows.RoutedEventHandler(this.btnChiTiet_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.nvButton = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\..\..\UControls\UCTBaoNhanViec.xaml"
            this.nvButton.Click += new System.Windows.RoutedEventHandler(this.btnXacNhan_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 46 "..\..\..\..\UControls\UCTBaoNhanViec.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnHuy_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

