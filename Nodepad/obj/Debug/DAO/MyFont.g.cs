﻿#pragma checksum "..\..\..\DAO\MyFont.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B35472ECB0D7E4CFEF0EE35E24D9D4E4"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Nodepad.DAO;
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


namespace Nodepad.DAO {
    
    
    /// <summary>
    /// MyFont
    /// </summary>
    public partial class MyFont : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 38 "..\..\..\DAO\MyFont.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbFontFamily;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\DAO\MyFont.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbFontStyle;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\DAO\MyFont.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbFontSize;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\DAO\MyFont.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox libFontFamily;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\DAO\MyFont.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox libFontStyle;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\DAO\MyFont.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox libFontSize;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\DAO\MyFont.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txblDemo;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\DAO\MyFont.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbScript;
        
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
            System.Uri resourceLocater = new System.Uri("/Nodepad;component/dao/myfont.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\DAO\MyFont.xaml"
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
            
            #line 11 "..\..\..\DAO\MyFont.xaml"
            ((Nodepad.DAO.MyFont)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            
            #line 12 "..\..\..\DAO\MyFont.xaml"
            ((Nodepad.DAO.MyFont)(target)).ContentRendered += new System.EventHandler(this.Window_ContentRendered);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txbFontFamily = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txbFontStyle = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txbFontSize = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.libFontFamily = ((System.Windows.Controls.ListBox)(target));
            return;
            case 6:
            this.libFontStyle = ((System.Windows.Controls.ListBox)(target));
            return;
            case 7:
            this.libFontSize = ((System.Windows.Controls.ListBox)(target));
            return;
            case 8:
            this.txblDemo = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.cbScript = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 10:
            
            #line 82 "..\..\..\DAO\MyFont.xaml"
            ((System.Windows.Documents.Hyperlink)(target)).RequestNavigate += new System.Windows.Navigation.RequestNavigateEventHandler(this.Hyperlink_RequestNavigate);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 85 "..\..\..\DAO\MyFont.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

