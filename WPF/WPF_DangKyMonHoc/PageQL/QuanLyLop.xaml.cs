using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Wpf_DangKyMonHoc.WindowQL;

namespace Wpf_DangKyMonHoc.PageQL
{
    /// <summary>
    /// Interaction logic for QuanLyLop.xaml
    /// </summary>
    public partial class QuanLyLop 
    {
        public QuanLyLop()
        {
            InitializeComponent();
        }

        private void btn_Nganh(object sender, RoutedEventArgs e)
        {
            var n = new QuanLyNganh();
            n.ShowDialog();
        }

        private void btn_NK(object sender, RoutedEventArgs e)
        {
            var n = new QuanLyNienKhoa();
            n.ShowDialog();
        }
    }
}
