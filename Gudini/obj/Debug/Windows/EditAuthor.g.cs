﻿#pragma checksum "..\..\..\Windows\EditAuthor.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F3715F3B27BB1172DDD786725C8459B83CB773F2C175B1B6D73771E5A7AAE4B6"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using BuckApp.Windows;
using DevExpress.Xpf.DXBinding;
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


namespace BuckApp.Windows {
    
    
    /// <summary>
    /// EditAuthor
    /// </summary>
    public partial class EditAuthor : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\Windows\EditAuthor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox author;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Windows\EditAuthor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox lname;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Windows\EditAuthor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox fname;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\Windows\EditAuthor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox mname;
        
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
            System.Uri resourceLocater = new System.Uri("/BuckApp;component/windows/editauthor.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\EditAuthor.xaml"
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
            this.author = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            this.lname = ((System.Windows.Controls.TextBox)(target));
            
            #line 33 "..\..\..\Windows\EditAuthor.xaml"
            this.lname.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.lname_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.fname = ((System.Windows.Controls.TextBox)(target));
            
            #line 37 "..\..\..\Windows\EditAuthor.xaml"
            this.fname.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.fname_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.mname = ((System.Windows.Controls.TextBox)(target));
            
            #line 41 "..\..\..\Windows\EditAuthor.xaml"
            this.mname.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.mname_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 45 "..\..\..\Windows\EditAuthor.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 50 "..\..\..\Windows\EditAuthor.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

