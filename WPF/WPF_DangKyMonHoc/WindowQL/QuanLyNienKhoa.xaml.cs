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
using System.Windows.Shapes;
using Wpf_DangKyMonHoc.Models;
using Wpf_DangKyMonHoc.XuLy;

namespace Wpf_DangKyMonHoc.WindowQL
{
    /// <summary>
    /// Interaction logic for QuanLyNienKhoa.xaml
    /// </summary>
    public partial class QuanLyNienKhoa : Window
    {
        public QuanLyNienKhoa()
        {
            InitializeComponent();
            getload();
        }
        public void getload()
        {
            List<NienKhoa> list = XLNienKhoa.getds();
            if (list == null) MessageBox.Show("Lỗi tải Server!!!", "ERROR");
            list_NienKhoa.ItemsSource = list;
        }
        private void list_NienKhoa_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (list_NienKhoa.SelectedItem == null) return;
            NienKhoa cv = list_NienKhoa.SelectedItem as NienKhoa;
            txt_mank.Text = cv.MaNk;
            txt_mank.IsReadOnly = true;
            txt_tennk.Text = cv.TenNk;
        }

        private void btn_them(object sender, RoutedEventArgs e)
        {
            string ma = txt_mank.Text;
            string ten = txt_tennk.Text;
            if (ma == "" || ten == "")
            {
                MessageBox.Show("Điền đầy đủ thông tin!", "Thông báo");
                return;
            }
            NienKhoa nk = new NienKhoa { MaNk = ma, TenNk = ten };
            var result = XLNienKhoa.post(nk);
            if (result == false)
            {
                MessageBox.Show("Thêm Chức Vụ không thành công", "Thông báo");
                return;
            }
            MessageBox.Show("Thêm Thành Công", "Thông Báo");
            clean();
            getload();
        }

        private void btn_sua(object sender, RoutedEventArgs e)
        {
            NienKhoa cv = new NienKhoa { MaNk = txt_mank.Text, TenNk = txt_tennk.Text };
            var result = XLNienKhoa.put(cv);
            if (result == false)
            {
                MessageBox.Show("Chỉnh sửa không thành công! Vui lòng kiểm tra lại.", "Thông Báo");
                return;
            }
            MessageBox.Show("Chình sửa thành công!", "Thông báo");
            clean();
            getload();
        }

        private void btn_xoa(object sender, RoutedEventArgs e)
        {
            if (txt_mank.Text == "")
            {
                MessageBox.Show("Không thể xóa dữ liệu do bạn chưa chọn dữ liệu để xóa!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information); return;
            }

            MessageBoxResult result = MessageBox.Show("Bạn có chắn chắn muốn xóa?", "Thông báo", MessageBoxButton.YesNo);
            switch (result)
            {
                case MessageBoxResult.No:
                    break;
                case MessageBoxResult.Yes:
                    
                    var kq = XLNienKhoa.delete(txt_mank.Text);
                    if (kq == false)
                    {
                        MessageBox.Show("Không thể xóa dữ liệu do đã được sử dụng ở chức năng khác!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                        break;
                    }
                    MessageBox.Show("Xóa Thành Công", "Thông Báo");
                    clean();
                    getload();
                    break;
            }
        }
        public void clean()
        {
            txt_mank.IsReadOnly = false;
            txt_mank.Text = "";
            txt_tennk.Text = "";
        }

        private void btn_thoat(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btn_lamMoi(object sender, RoutedEventArgs e)
        {
            clean();
        }
    }
}
