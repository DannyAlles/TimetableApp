﻿#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F872191D5597D575E966D3894A4D7B8171927AFF42675A132E541A55759EA276"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using GraduateWorkCompany;
using GraduateWorkCompany.Properties;
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


namespace GraduateWorkCompany {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 37 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame MainFrame;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock LoginLB;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView MenuList;
        
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
            System.Uri resourceLocater = new System.Uri("/GraduateWorkCompany;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
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
            this.MainFrame = ((System.Windows.Controls.Frame)(target));
            return;
            case 2:
            this.LoginLB = ((System.Windows.Controls.TextBlock)(target));
            
            #line 46 "..\..\MainWindow.xaml"
            this.LoginLB.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.TextBlock_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.MenuList = ((System.Windows.Controls.ListView)(target));
            return;
            case 4:
            
            #line 66 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.ListViewItem)(target)).MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.ListViewItem_MouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 67 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.ListViewItem)(target)).MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.ListViewItem_MouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 68 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.ListViewItem)(target)).MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.ListViewItem_MouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 69 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.ListViewItem)(target)).MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.ListViewItem_MouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 70 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.ListViewItem)(target)).MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.ListViewItem_MouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

