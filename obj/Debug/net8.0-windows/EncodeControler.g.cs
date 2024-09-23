﻿#pragma checksum "..\..\..\EncodeControler.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "401E84A63FC407B37C48163C00DB9B99CBE4A235"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace SteganographyToolUI {
    
    
    /// <summary>
    /// EncodeControler
    /// </summary>
    public partial class EncodeControler : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 82 "..\..\..\EncodeControler.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgDisplay;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\..\EncodeControler.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox toggleSwitch;
        
        #line default
        #line hidden
        
        
        #line 116 "..\..\..\EncodeControler.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox MethodSelectionComboBox;
        
        #line default
        #line hidden
        
        
        #line 126 "..\..\..\EncodeControler.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox inputTextBox;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.8.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/MyStegoTool;V1.0.0.0;component/encodecontroler.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\EncodeControler.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.8.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.imgDisplay = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            
            #line 95 "..\..\..\EncodeControler.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnUploadImage_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.toggleSwitch = ((System.Windows.Controls.CheckBox)(target));
            
            #line 108 "..\..\..\EncodeControler.xaml"
            this.toggleSwitch.Checked += new System.Windows.RoutedEventHandler(this.ToggleSwitch_Checked);
            
            #line default
            #line hidden
            
            #line 109 "..\..\..\EncodeControler.xaml"
            this.toggleSwitch.Unchecked += new System.Windows.RoutedEventHandler(this.ToggleSwitch_Unchecked);
            
            #line default
            #line hidden
            return;
            case 4:
            this.MethodSelectionComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.inputTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            
            #line 148 "..\..\..\EncodeControler.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnEncodeImage);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 157 "..\..\..\EncodeControler.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnDecodeImage);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

