#pragma checksum "..\..\..\..\PageQL\QuanLyLop.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5A6B6C6AD3CEBC5362637771A16054AD38ACEBC6"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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
using Wpf_DangKyMonHoc.PageQL;


namespace Wpf_DangKyMonHoc.PageQL {
    
    
    /// <summary>
    /// QuanLyLop
    /// </summary>
    public partial class QuanLyLop : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 47 "..\..\..\..\PageQL\QuanLyLop.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_malop;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\..\PageQL\QuanLyLop.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_tenlop;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\..\PageQL\QuanLyLop.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_siso;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\..\PageQL\QuanLyLop.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmb_nienkhoa;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\..\PageQL\QuanLyLop.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmb_nganh;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\..\..\PageQL\QuanLyLop.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView listLop;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Wpf_DangKyMonHoc;component/pageql/quanlylop.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\PageQL\QuanLyLop.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 18 "..\..\..\..\PageQL\QuanLyLop.xaml"
            ((Wpf_DangKyMonHoc.PageQL.QuanLyLop)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txt_malop = ((System.Windows.Controls.TextBox)(target));
            
            #line 47 "..\..\..\..\PageQL\QuanLyLop.xaml"
            this.txt_malop.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.NumberValidationTextBox);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txt_tenlop = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txt_siso = ((System.Windows.Controls.TextBox)(target));
            
            #line 49 "..\..\..\..\PageQL\QuanLyLop.xaml"
            this.txt_siso.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.NumberValidationTextBox);
            
            #line default
            #line hidden
            return;
            case 5:
            this.cmb_nienkhoa = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.cmb_nganh = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            
            #line 72 "..\..\..\..\PageQL\QuanLyLop.xaml"
            ((System.Windows.Documents.Hyperlink)(target)).Click += new System.Windows.RoutedEventHandler(this.btn_NK);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 81 "..\..\..\..\PageQL\QuanLyLop.xaml"
            ((System.Windows.Documents.Hyperlink)(target)).Click += new System.Windows.RoutedEventHandler(this.btn_HDT);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 88 "..\..\..\..\PageQL\QuanLyLop.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btn_them);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 89 "..\..\..\..\PageQL\QuanLyLop.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btn_sua);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 90 "..\..\..\..\PageQL\QuanLyLop.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btn_xoa);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 91 "..\..\..\..\PageQL\QuanLyLop.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btn_lammoi);
            
            #line default
            #line hidden
            return;
            case 13:
            this.listLop = ((System.Windows.Controls.ListView)(target));
            
            #line 105 "..\..\..\..\PageQL\QuanLyLop.xaml"
            this.listLop.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.listLop_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

