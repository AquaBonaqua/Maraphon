﻿#pragma checksum "..\..\..\3Admin\PageAdmin.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2BA01D84E14FE6CDBF040B58E6181EA80D61F761"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

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
using maraphonapp._3Admin;


namespace maraphonapp._3Admin {
    
    
    /// <summary>
    /// PageAdmin
    /// </summary>
    public partial class PageAdmin : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\3Admin\PageAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnLogout;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\3Admin\PageAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Users;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\3Admin\PageAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Charity;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\3Admin\PageAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Volunteers;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\3Admin\PageAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Inventory;
        
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
            System.Uri resourceLocater = new System.Uri("/maraphonapp;component/3admin/pageadmin.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\3Admin\PageAdmin.xaml"
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
            this.BtnLogout = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\..\3Admin\PageAdmin.xaml"
            this.BtnLogout.Click += new System.Windows.RoutedEventHandler(this.BtnLogout_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Users = ((System.Windows.Controls.Button)(target));
            return;
            case 3:
            this.Charity = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\3Admin\PageAdmin.xaml"
            this.Charity.Click += new System.Windows.RoutedEventHandler(this.Charity_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Volunteers = ((System.Windows.Controls.Button)(target));
            return;
            case 5:
            this.Inventory = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\3Admin\PageAdmin.xaml"
            this.Inventory.Click += new System.Windows.RoutedEventHandler(this.Inventory_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

