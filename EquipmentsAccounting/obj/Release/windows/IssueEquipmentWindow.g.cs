﻿#pragma checksum "..\..\..\windows\IssueEquipmentWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F90982225E8F24C87CF63C1033B76CFD816206DF79B6FA93A409ADF6E1437783"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using EquipmentsAccounting.windows;
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


namespace EquipmentsAccounting.windows {
    
    
    /// <summary>
    /// IssueEquipmentWindow
    /// </summary>
    public partial class IssueEquipmentWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 24 "..\..\..\windows\IssueEquipmentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton TypeRadioButton;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\windows\IssueEquipmentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton CharsRadioButton;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\windows\IssueEquipmentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton SerialNumRadioButton;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\windows\IssueEquipmentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox FilterTextBox;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\windows\IssueEquipmentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid EquipmentsDataGrid;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\windows\IssueEquipmentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid SelectedEquipmentsDataGrid;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\windows\IssueEquipmentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button IssueButton;
        
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
            System.Uri resourceLocater = new System.Uri("/EquipmentsAccounting;component/windows/issueequipmentwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\windows\IssueEquipmentWindow.xaml"
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
            this.TypeRadioButton = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 2:
            this.CharsRadioButton = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 3:
            this.SerialNumRadioButton = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 4:
            this.FilterTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 51 "..\..\..\windows\IssueEquipmentWindow.xaml"
            this.FilterTextBox.KeyUp += new System.Windows.Input.KeyEventHandler(this.DataFilter);
            
            #line default
            #line hidden
            return;
            case 5:
            this.EquipmentsDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 7:
            this.SelectedEquipmentsDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 9:
            this.IssueButton = ((System.Windows.Controls.Button)(target));
            
            #line 84 "..\..\..\windows\IssueEquipmentWindow.xaml"
            this.IssueButton.Click += new System.Windows.RoutedEventHandler(this.Issue);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            System.Windows.EventSetter eventSetter;
            switch (connectionId)
            {
            case 6:
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.Controls.Control.MouseDoubleClickEvent;
            
            #line 60 "..\..\..\windows\IssueEquipmentWindow.xaml"
            eventSetter.Handler = new System.Windows.Input.MouseButtonEventHandler(this.DataGridCellFocused);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            break;
            case 8:
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.Controls.Control.MouseDoubleClickEvent;
            
            #line 71 "..\..\..\windows\IssueEquipmentWindow.xaml"
            eventSetter.Handler = new System.Windows.Input.MouseButtonEventHandler(this.DataGridCellFocused);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            break;
            }
        }
    }
}

