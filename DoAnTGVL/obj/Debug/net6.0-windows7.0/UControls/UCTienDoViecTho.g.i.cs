﻿#pragma checksum "..\..\..\..\UControls\UCTienDoViecTho.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "A6DD5A3938E0122F24EA6195B328F34E51C07B3E"
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
    /// UCTienDoViecTho
    /// </summary>
    public partial class UCTienDoViecTho : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 23 "..\..\..\..\UControls\UCTienDoViecTho.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox chbChuaThucHien;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\UControls\UCTienDoViecTho.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox chbDangThuchien;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\UControls\UCTienDoViecTho.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox chbDaHoanThanh;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\..\UControls\UCTienDoViecTho.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbTimKiem;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\..\UControls\UCTienDoViecTho.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ngayBanbutton;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\..\UControls\UCTienDoViecTho.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lsvDSCV;
        
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
            System.Uri resourceLocater = new System.Uri("/DoAnTGVL;V1.0.0.0;component/ucontrols/uctiendoviectho.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\UControls\UCTienDoViecTho.xaml"
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
            this.chbChuaThucHien = ((System.Windows.Controls.CheckBox)(target));
            
            #line 25 "..\..\..\..\UControls\UCTienDoViecTho.xaml"
            this.chbChuaThucHien.Click += new System.Windows.RoutedEventHandler(this.chboxChuaThucHien_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.chbDangThuchien = ((System.Windows.Controls.CheckBox)(target));
            
            #line 29 "..\..\..\..\UControls\UCTienDoViecTho.xaml"
            this.chbDangThuchien.Click += new System.Windows.RoutedEventHandler(this.chboxDangThucHien_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.chbDaHoanThanh = ((System.Windows.Controls.CheckBox)(target));
            
            #line 33 "..\..\..\..\UControls\UCTienDoViecTho.xaml"
            this.chbDaHoanThanh.Click += new System.Windows.RoutedEventHandler(this.chboxDaHoanThanh_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txbTimKiem = ((System.Windows.Controls.TextBox)(target));
            
            #line 56 "..\..\..\..\UControls\UCTienDoViecTho.xaml"
            this.txbTimKiem.KeyUp += new System.Windows.Input.KeyEventHandler(this.txbTimKiem_KeyUp);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ngayBanbutton = ((System.Windows.Controls.Button)(target));
            
            #line 63 "..\..\..\..\UControls\UCTienDoViecTho.xaml"
            this.ngayBanbutton.Click += new System.Windows.RoutedEventHandler(this.ngayBanbutton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.lsvDSCV = ((System.Windows.Controls.ListView)(target));
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.2.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 7:
            
            #line 125 "..\..\..\..\UControls\UCTienDoViecTho.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btn_Sua);
            
            #line default
            #line hidden
            break;
            case 8:
            
            #line 135 "..\..\..\..\UControls\UCTienDoViecTho.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btn_Xoa);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

