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
using System.Windows.Shapes;
using WPF_Admin_DangKyMonHoc.XuLy;

namespace WPF_Admin_DangKyMonHoc
{
    /// <summary>
    /// Interaction logic for WPF_Khoa.xaml
    /// </summary>
    public partial class WPF_Khoa : Window
    {
         public WPF_Khoa()
        {
            InitializeComponent();
        }
        public void Show()
        {
            List<Khoa> ds = XuLyKhoa.getlist();

            if (ds == null)
            {
                MessageBox.Show("ERROR:404", "WARNING");
            }
            else
            {
                dg_Khoa.ItemsSource = ds;

            }
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Show();
        }

        private void dg_Khoa_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dg_Khoa.SelectedItem == null) return;
            Khoa k = dg_Khoa.SelectedItem as Khoa;
            txt_makhoa.Text = k.MaKhoa;
            txt_tenkhoa.Text = k.TenKhoan;

            txt_makhoa.IsReadOnly = true;
        }

        private void btn_Them_Click(object sender, RoutedEventArgs e)
        {
            if(txt_makhoa.Text.Trim()==""|| txt_makhoa.Text.Trim() == "")
            {
                MessageBox.Show("Bạn Điền Chưa Đầy Đủ Thông Tin", "Thông Báo");
                return;
            }    
            Khoa k = new Khoa();
            k.MaKhoa = txt_makhoa.Text;
            k.TenKhoan = txt_tenkhoa.Text;
            bool check = XuLyKhoa.postKhoa(k);
            if(check ==false)
            {
                MessageBox.Show("Thêm Khoa Chưa Thành Công!! Vui lòng kiểm tra lại", "Thông Báo");
                return;
            }
            MessageBox.Show("Thêm Khoa Thành Công!! ", "Thông Báo");
            Show();
        }

        private void btn_Xoa_Click(object sender, RoutedEventArgs e)
        {
            if (txt_makhoa.Text.Trim() == "" || txt_makhoa.Text.Trim() == "")
            {
                MessageBox.Show("Bạn Chưa Chọn Phần Tử Xóa", "Thông Báo");
                return;
            }
            bool check = XuLyKhoa.deleteKhoa(txt_makhoa.Text.Trim());
            if (check == false)
            {
                MessageBox.Show("Xóa Khoa Chưa Thành Công!! Vui lòng kiểm tra lại", "Thông Báo");
                return;
            }
            MessageBox.Show("Xóa Khoa Thành Công!! ", "Thông Báo");
            Show();
        }

        private void btn_Sua_Click(object sender, RoutedEventArgs e)
        {
            if (txt_makhoa.Text.Trim() == "" || txt_makhoa.Text.Trim() == "")
            {
                MessageBox.Show("Bạn Điền Chưa Đầy Đủ Thông Tin", "Thông Báo");
                return;
            }
            Khoa k = new Khoa();
            k.MaKhoa = txt_makhoa.Text;
            k.TenKhoan = txt_tenkhoa.Text;
            bool check = XuLyKhoa.updateKhoa(k);
            if (check == false)
            {
                MessageBox.Show("Sửa Khoa Chưa Thành Công!! Vui lòng kiểm tra lại", "Thông Báo");
                return;
            }
            MessageBox.Show("Sửa Khoa Thành Công!! ", "Thông Báo");
            Show();
        }

        private void btn_Reset_Click(object sender, RoutedEventArgs e)
        {
            Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow n = new MainWindow();
            n.Close();
        }
    }
}
