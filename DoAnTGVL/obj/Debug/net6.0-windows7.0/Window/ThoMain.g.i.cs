﻿#pragma checksum "..\..\..\..\WINDOW\ThoMain.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1C64F627C9B047F654EE81F25C9C67341099CCD6"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DoAnTGVL;
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


namespace DoAnTGVL {
    
    
    /// <summary>
    /// ThoMain
    /// </summary>
    public partial class ThoMain : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 56 "..\..\..\..\WINDOW\ThoMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gridMain;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\..\WINDOW\ThoMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gridMainWin;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\..\WINDOW\ThoMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gridMainmenu;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\..\WINDOW\ThoMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonOpenMenu;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\..\..\WINDOW\ThoMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonCloseMenu;
        
        #line default
        #line hidden
        
        
        #line 197 "..\..\..\..\WINDOW\ThoMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem mnuLogout;
        
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
            System.Uri resourceLocater = new System.Uri("/DoAnTGVL;V1.0.0.0;component/window/thomain.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\WINDOW\ThoMain.xaml"
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
            this.gridMain = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.gridMainWin = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.gridMainmenu = ((System.Windows.Controls.Grid)(target));
            
            #line 63 "..\..\..\..\WINDOW\ThoMain.xaml"
            this.gridMainmenu.MouseLeave += new System.Windows.Input.MouseEventHandler(this.gridMainmenu_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ButtonOpenMenu = ((System.Windows.Controls.Button)(target));
            
            #line 80 "..\..\..\..\WINDOW\ThoMain.xaml"
            this.ButtonOpenMenu.Click += new System.Windows.RoutedEventHandler(this.ButtonOpenMenu_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ButtonCloseMenu = ((System.Windows.Controls.Button)(target));
            
            #line 83 "..\..\..\..\WINDOW\ThoMain.xaml"
            this.ButtonCloseMenu.Click += new System.Windows.RoutedEventHandler(this.ButtonCloseMenu_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 93 "..\..\..\..\WINDOW\ThoMain.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MnuTrangChu_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 107 "..\..\..\..\WINDOW\ThoMain.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MnuTimViec_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 122 "..\..\..\..\WINDOW\ThoMain.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.mnuDSVL_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 137 "..\..\..\..\WINDOW\ThoMain.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.mnuLichSu_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 152 "..\..\..\..\WINDOW\ThoMain.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.mnLuotDGia_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 167 "..\..\..\..\WINDOW\ThoMain.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.mnuThongKe_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 182 "..\..\..\..\WINDOW\ThoMain.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.btn_ThongTin_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.mnuLogout = ((System.Windows.Controls.MenuItem)(target));
            
            #line 197 "..\..\..\..\WINDOW\ThoMain.xaml"
            this.mnuLogout.Click += new System.Windows.RoutedEventHandler(this.MnuLogout_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

