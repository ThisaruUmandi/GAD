﻿#pragma checksum "..\..\CustomerSignUp.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9BB3F7EAC7F99387621EC3AA1C23CE0634C16C4A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
using WpfApp7;


namespace WpfApp7 {
    
    
    /// <summary>
    /// CustomerSignUp
    /// </summary>
    public partial class CustomerSignUp : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\CustomerSignUp.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.DialogHost DialogHost;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\CustomerSignUp.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_id;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\CustomerSignUp.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_firstName;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\CustomerSignUp.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_lastName;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\CustomerSignUp.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_email;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\CustomerSignUp.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox txt_Password;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\CustomerSignUp.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox txt_ConfPassword;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\CustomerSignUp.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_Address;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\CustomerSignUp.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_tp;
        
        #line default
        #line hidden
        
        
        #line 96 "..\..\CustomerSignUp.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Save;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\CustomerSignUp.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Clear;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp7;component/customersignup.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\CustomerSignUp.xaml"
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
            this.DialogHost = ((MaterialDesignThemes.Wpf.DialogHost)(target));
            return;
            case 2:
            
            #line 21 "..\..\CustomerSignUp.xaml"
            ((System.Windows.Controls.Image)(target)).MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.Image_MouseUp);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 30 "..\..\CustomerSignUp.xaml"
            ((System.Windows.Controls.Image)(target)).MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.Image_Back);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txt_id = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txt_firstName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.txt_lastName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.txt_email = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.txt_Password = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 9:
            this.txt_ConfPassword = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 10:
            this.txt_Address = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.txt_tp = ((System.Windows.Controls.TextBox)(target));
            return;
            case 12:
            this.btn_Save = ((System.Windows.Controls.Button)(target));
            
            #line 97 "..\..\CustomerSignUp.xaml"
            this.btn_Save.Click += new System.Windows.RoutedEventHandler(this.Btn_Save_Click_1);
            
            #line default
            #line hidden
            return;
            case 13:
            this.btn_Clear = ((System.Windows.Controls.Button)(target));
            
            #line 100 "..\..\CustomerSignUp.xaml"
            this.btn_Clear.Click += new System.Windows.RoutedEventHandler(this.btn_Reset_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

