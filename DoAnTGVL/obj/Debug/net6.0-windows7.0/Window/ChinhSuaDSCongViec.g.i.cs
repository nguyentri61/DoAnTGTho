﻿#pragma checksum "..\..\..\..\Window\ChinhSuaDSCongViec.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D72C2BC3588040231E1111125AAF8103AE8ED889"
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
    /// ChinhSuaDSCongViec
    /// </summary>
    public partial class ChinhSuaDSCongViec : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 95 "..\..\..\..\Window\ChinhSuaDSCongViec.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox RadioButtonGroupChoiceChip;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\..\..\Window\ChinhSuaDSCongViec.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBoxItem cthlstItem;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\..\..\Window\ChinhSuaDSCongViec.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBoxItem dthlstItem;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\..\..\Window\ChinhSuaDSCongViec.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBoxItem dhtlstItem;
        
        #line default
        #line hidden
        
        
        #line 107 "..\..\..\..\Window\ChinhSuaDSCongViec.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Commfirm;
        
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
            System.Uri resourceLocater = new System.Uri("/DoAnTGVL;component/window/chinhsuadscongviec.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Window\ChinhSuaDSCongViec.xaml"
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
            this.RadioButtonGroupChoiceChip = ((System.Windows.Controls.ListBox)(target));
            
            #line 94 "..\..\..\..\Window\ChinhSuaDSCongViec.xaml"
            this.RadioButtonGroupChoiceChip.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ListBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.cthlstItem = ((System.Windows.Controls.ListBoxItem)(target));
            return;
            case 3:
            this.dthlstItem = ((System.Windows.Controls.ListBoxItem)(target));
            return;
            case 4:
            this.dhtlstItem = ((System.Windows.Controls.ListBoxItem)(target));
            return;
            case 5:
            this.btn_Commfirm = ((System.Windows.Controls.Button)(target));
            
            #line 107 "..\..\..\..\Window\ChinhSuaDSCongViec.xaml"
            this.btn_Commfirm.Click += new System.Windows.RoutedEventHandler(this.btnCapNhat_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 114 "..\..\..\..\Window\ChinhSuaDSCongViec.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnHuy_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

