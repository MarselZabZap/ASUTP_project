﻿#pragma checksum "..\..\..\windows\StockTramsferWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7920E3B633A3730F6A883253B346E6822562508F7D8B97E7D7AE019F40162835"
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
    /// StockTramsferWindow
    /// </summary>
    public partial class StockTramsferWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 31 "..\..\..\windows\StockTramsferWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox SenderComboBox;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\windows\StockTramsferWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox FilterTextBox;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\windows\StockTramsferWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton TypeRadioButton;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\windows\StockTramsferWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton CharsRadioButton;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\windows\StockTramsferWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton SerialNumRadioButton;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\windows\StockTramsferWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid SendersEquipmentDataGrid;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\..\windows\StockTramsferWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox RecevierComboBox;
        
        #line default
        #line hidden
        
        
        #line 116 "..\..\..\windows\StockTramsferWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ClearImage;
        
        #line default
        #line hidden
        
        
        #line 125 "..\..\..\windows\StockTramsferWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid RecevierEquipmentDataGrid;
        
        #line default
        #line hidden
        
        
        #line 138 "..\..\..\windows\StockTramsferWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ApplyButton;
        
        #line default
        #line hidden
        
        
        #line 147 "..\..\..\windows\StockTramsferWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CancelButton;
        
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
            System.Uri resourceLocater = new System.Uri("/EquipmentsAccounting;component/windows/stocktramsferwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\windows\StockTramsferWindow.xaml"
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
            this.SenderComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 38 "..\..\..\windows\StockTramsferWindow.xaml"
            this.SenderComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.SenderIsChange);
            
            #line default
            #line hidden
            return;
            case 2:
            this.FilterTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 54 "..\..\..\windows\StockTramsferWindow.xaml"
            this.FilterTextBox.KeyUp += new System.Windows.Input.KeyEventHandler(this.Filtration);
            
            #line default
            #line hidden
            return;
            case 3:
            this.TypeRadioButton = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 4:
            this.CharsRadioButton = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 5:
            this.SerialNumRadioButton = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 6:
            this.SendersEquipmentDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 8:
            this.RecevierComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 113 "..\..\..\windows\StockTramsferWindow.xaml"
            this.RecevierComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.RecevierIsChange);
            
            #line default
            #line hidden
            return;
            case 9:
            this.ClearImage = ((System.Windows.Controls.Image)(target));
            
            #line 122 "..\..\..\windows\StockTramsferWindow.xaml"
            this.ClearImage.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.ClearRecevierTableClick);
            
            #line default
            #line hidden
            return;
            case 10:
            this.RecevierEquipmentDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 12:
            this.ApplyButton = ((System.Windows.Controls.Button)(target));
            return;
            case 13:
            this.CancelButton = ((System.Windows.Controls.Button)(target));
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
            case 7:
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.Controls.Control.MouseDoubleClickEvent;
            
            #line 82 "..\..\..\windows\StockTramsferWindow.xaml"
            eventSetter.Handler = new System.Windows.Input.MouseButtonEventHandler(this.SendersEquipmentDataGridCellFocused);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            break;
            case 11:
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.Controls.Control.MouseDoubleClickEvent;
            
            #line 132 "..\..\..\windows\StockTramsferWindow.xaml"
            eventSetter.Handler = new System.Windows.Input.MouseButtonEventHandler(this.RecevierEquipmentDataGridCellFocused);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            break;
            }
        }
    }
}

