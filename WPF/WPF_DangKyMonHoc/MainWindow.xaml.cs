using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Wpf_DangKyMonHoc.Page;
using Wpf_DangKyMonHoc.PageQL;
using Wpf_DangKyMonHoc.WindowQL;

namespace Wpf_DangKyMonHoc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           ContentArea.Content = new QuanLyNhanVien();

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ContentArea.Content = new QuanLyGiangVien();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            var wn = new QuanLyChucVu();
            wn.ShowDialog();
        }

        private void Button_Click_Khoa(object sender, RoutedEventArgs e)
        {
            var k = new QuanLyKhoa();
            k.ShowDialog();
        }

        private void Btn_Nganh(object sender, RoutedEventArgs e)
        {
            var n = new QuanLyNganh(); n.ShowDialog();
        }

        private void Btn_NienKhoa(object sender, RoutedEventArgs e)
        {
            var nk = new QuanLyNienKhoa(); nk.ShowDialog();
        }

        private void btn_lop(object sender, RoutedEventArgs e)
        {
            ContentArea.Content = new QuanLyLop();
        }

        private void btn_SV(object sender, RoutedEventArgs e)
        {
            ContentArea.Content = new QuanLySinhVien();
        }
    }
}
