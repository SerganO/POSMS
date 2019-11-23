﻿#pragma checksum "..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4A3E3D4E10B75AC9A3D8C1A48A0C0E5A48631FCF"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.MahApps;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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
using posms;


namespace posms {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 29 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TreeView Guest;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TreeView Quartemaster;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock QuartemasterName;
        
        #line default
        #line hidden
        
        
        #line 96 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock QuartemasterShopName;
        
        #line default
        #line hidden
        
        
        #line 157 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TreeView Admin;
        
        #line default
        #line hidden
        
        
        #line 170 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock AdminName;
        
        #line default
        #line hidden
        
        
        #line 186 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock AdminShopName;
        
        #line default
        #line hidden
        
        
        #line 231 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox List_Region;
        
        #line default
        #line hidden
        
        
        #line 313 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox List_Shop;
        
        #line default
        #line hidden
        
        
        #line 320 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Search_in_database;
        
        #line default
        #line hidden
        
        
        #line 327 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Price_monitoring;
        
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
            System.Uri resourceLocater = new System.Uri("/posms;component/mainwindow.xaml", System.UriKind.Relative);
            
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
            this.Guest = ((System.Windows.Controls.TreeView)(target));
            return;
            case 2:
            
            #line 48 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TreeViewItem)(target)).PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Exit_to_login_window);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Quartemaster = ((System.Windows.Controls.TreeView)(target));
            return;
            case 4:
            this.QuartemasterName = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            
            #line 87 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TreeViewItem)(target)).PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Go_to_shop_window);
            
            #line default
            #line hidden
            return;
            case 6:
            this.QuartemasterShopName = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            
            #line 104 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TreeViewItem)(target)).PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.OrderGoods_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 121 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TreeViewItem)(target)).PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Orders_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 138 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TreeViewItem)(target)).PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Exit_to_login_window);
            
            #line default
            #line hidden
            return;
            case 10:
            this.Admin = ((System.Windows.Controls.TreeView)(target));
            return;
            case 11:
            this.AdminName = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 12:
            
            #line 177 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TreeViewItem)(target)).PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Go_to_shop_window);
            
            #line default
            #line hidden
            return;
            case 13:
            this.AdminShopName = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 14:
            
            #line 195 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TreeViewItem)(target)).PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Set_prices_Click);
            
            #line default
            #line hidden
            return;
            case 15:
            
            #line 212 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TreeViewItem)(target)).PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Exit_to_login_window);
            
            #line default
            #line hidden
            return;
            case 16:
            this.List_Region = ((System.Windows.Controls.ComboBox)(target));
            
            #line 233 "..\..\MainWindow.xaml"
            this.List_Region.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.List_Region_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 17:
            this.List_Shop = ((System.Windows.Controls.ComboBox)(target));
            
            #line 315 "..\..\MainWindow.xaml"
            this.List_Shop.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.List_Shop_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 18:
            this.Search_in_database = ((System.Windows.Controls.Button)(target));
            
            #line 323 "..\..\MainWindow.xaml"
            this.Search_in_database.Click += new System.Windows.RoutedEventHandler(this.Search_in_database_Click);
            
            #line default
            #line hidden
            return;
            case 19:
            this.Price_monitoring = ((System.Windows.Controls.Button)(target));
            
            #line 330 "..\..\MainWindow.xaml"
            this.Price_monitoring.Click += new System.Windows.RoutedEventHandler(this.Price_monitoring_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

