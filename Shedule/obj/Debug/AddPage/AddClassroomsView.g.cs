﻿#pragma checksum "..\..\..\AddPage\AddClassroomsView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "65EE3FEA4F4A16601BECB3926B179ADA8D5394421787065A11A88F2BA49AD1CF"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Shedule.ViewPages;
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


namespace Shedule.ViewPages {
    
    
    /// <summary>
    /// AddClassroomsView
    /// </summary>
    public partial class AddClassroomsView : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\AddPage\AddClassroomsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Grid;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\AddPage\AddClassroomsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox number;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\AddPage\AddClassroomsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox building;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\AddPage\AddClassroomsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox affiliationCB;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\AddPage\AddClassroomsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button save_butt;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\AddPage\AddClassroomsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button back;
        
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
            System.Uri resourceLocater = new System.Uri("/Shedule;component/addpage/addclassroomsview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\AddPage\AddClassroomsView.xaml"
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
            this.Grid = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.number = ((System.Windows.Controls.TextBox)(target));
            
            #line 24 "..\..\..\AddPage\AddClassroomsView.xaml"
            this.number.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.number_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 3:
            this.building = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.affiliationCB = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.save_butt = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\AddPage\AddClassroomsView.xaml"
            this.save_butt.Click += new System.Windows.RoutedEventHandler(this.save_butt_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.back = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\AddPage\AddClassroomsView.xaml"
            this.back.Click += new System.Windows.RoutedEventHandler(this.back_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

