﻿#pragma checksum "..\..\Admin_Page.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E39EA9569066AC1B734C3CA7DFECD699D932ACE6E8D0C70B147FB96F86215A67"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Faculty;
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


namespace Faculty {
    
    
    /// <summary>
    /// Admin_Page
    /// </summary>
    public partial class Admin_Page : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\Admin_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid Data_Grid;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\Admin_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Combo;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\Admin_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Search_txt;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\Admin_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ID_txt;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\Admin_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Dep_txt;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\Admin_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Search_btn;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\Admin_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Delete_btn;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\Admin_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Update_btn;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\Admin_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Refresh_btn;
        
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
            System.Uri resourceLocater = new System.Uri("/Faculty;component/admin_page.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Admin_Page.xaml"
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
            this.Data_Grid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.Combo = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.Search_txt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.ID_txt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.Dep_txt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.Search_btn = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\Admin_Page.xaml"
            this.Search_btn.Click += new System.Windows.RoutedEventHandler(this.Search_btn_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Delete_btn = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\Admin_Page.xaml"
            this.Delete_btn.Click += new System.Windows.RoutedEventHandler(this.Delete_btn_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Update_btn = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\Admin_Page.xaml"
            this.Update_btn.Click += new System.Windows.RoutedEventHandler(this.Update_btn_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.Refresh_btn = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\Admin_Page.xaml"
            this.Refresh_btn.Click += new System.Windows.RoutedEventHandler(this.Refresh_btn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

