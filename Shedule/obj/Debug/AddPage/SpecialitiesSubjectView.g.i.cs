﻿#pragma checksum "..\..\..\AddPage\SpecialitiesSubjectView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "21875017391EF8D02E0464E66BFB14B771F1C9750600A5E5773AD955410618FB"
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
    /// SpecialitiesSubjectView
    /// </summary>
    public partial class SpecialitiesSubjectView : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\AddPage\SpecialitiesSubjectView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Grid;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\AddPage\SpecialitiesSubjectView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox code;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\AddPage\SpecialitiesSubjectView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox nameCB;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\AddPage\SpecialitiesSubjectView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button edit_butt;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\AddPage\SpecialitiesSubjectView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button save_butt;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\AddPage\SpecialitiesSubjectView.xaml"
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
            System.Uri resourceLocater = new System.Uri("/Shedule;component/addpage/specialitiessubjectview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\AddPage\SpecialitiesSubjectView.xaml"
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
            this.code = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.nameCB = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.edit_butt = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\AddPage\SpecialitiesSubjectView.xaml"
            this.edit_butt.Click += new System.Windows.RoutedEventHandler(this.edit_butt_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.save_butt = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\AddPage\SpecialitiesSubjectView.xaml"
            this.save_butt.Click += new System.Windows.RoutedEventHandler(this.save_butt_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.back = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\AddPage\SpecialitiesSubjectView.xaml"
            this.back.Click += new System.Windows.RoutedEventHandler(this.back_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

