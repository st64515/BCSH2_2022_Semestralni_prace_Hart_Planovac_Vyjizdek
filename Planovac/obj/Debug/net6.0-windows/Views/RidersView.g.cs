﻿#pragma checksum "..\..\..\..\Views\RidersView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "669A823E5A3922F44687EB5232C12D8C5D54433C"
//------------------------------------------------------------------------------
// <auto-generated>
//     Tento kód byl generován nástrojem.
//     Verze modulu runtime:4.0.30319.42000
//
//     Změny tohoto souboru mohou způsobit nesprávné chování a budou ztraceny,
//     dojde-li k novému generování kódu.
// </auto-generated>
//------------------------------------------------------------------------------

using Planovac.ViewModels;
using Planovac.Views;
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


namespace Planovac.Views {
    
    
    /// <summary>
    /// RidersView
    /// </summary>
    public partial class RidersView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\..\Views\RidersView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid master;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\Views\RidersView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn riderFirstName;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\Views\RidersView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn riderLastName;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\Views\RidersView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn hasLicense;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\Views\RidersView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn isAdult;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\Views\RidersView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn Description;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\..\Views\RidersView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Planovac.Views.Detail detail;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Planovac;component/views/ridersview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\RidersView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.master = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.riderFirstName = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 3:
            this.riderLastName = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 4:
            this.hasLicense = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 5:
            this.isAdult = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 6:
            this.Description = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 7:
            this.detail = ((Planovac.Views.Detail)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
