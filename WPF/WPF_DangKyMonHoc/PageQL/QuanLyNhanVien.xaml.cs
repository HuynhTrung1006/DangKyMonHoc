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
using Wpf_DangKyMonHoc.Models;
using Wpf_DangKyMonHoc.XuLy;

namespace Wpf_DangKyMonHoc.Page
{
    /// <summary>
    /// Interaction logic for QuanLyNhanVien.xaml
    /// </summary>
    public partial class QuanLyNhanVien 
    {
		private readonly Xuly_Chung xlc = new Xuly_Chung();
        public QuanLyNhanVien()
        {
            InitializeComponent();
			getLoad();
        }

		public void getLoad()
		{
			List<NhanVien> list = XLNhanVien.getAll();
			if (list == null) MessageBox.Show("Lỗi tải Server!!!", "ERROR");
			listnhanvien.ItemsSource = list;

			List<ChucVu> listcv = XLChucVu.dschucvu();
			if (listcv == null) MessageBox.Show("Lỗi tải Lớp từ Server!", "ERROR");
			cmb_chucvu.ItemsSource = listcv;
		}
		public void clean()
		{
			txt_manv.Text = "";
			txt_tennv.Text = "";
			txt_sdt.Text = "";
			txt_email.Text = "";
			txt_cmnd.Text = "";
			txt_diachi.Text = "";
			date_ngaysinh.SelectedDate = null;
			txt_matkhau.Text = "";
			txt_manv.IsReadOnly = false;
			txt_matkhau.IsReadOnly = false;
		}
		private void btn_them(object sender, RoutedEventArgs e)
		{
			NhanVien sv = new NhanVien
			{
				MaNv = txt_manv.Text,
				TenNv = txt_tennv.Text,
				Sdt = txt_sdt.Text,
				Email = txt_email.Text,
				Cmnd = txt_cmnd.Text,
				Diachi = txt_diachi.Text,
				Matkhau = txt_matkhau.Text,
				Ngaysinh = date_ngaysinh.SelectedDate.Value,
				MaChucVu=cmb_chucvu.SelectedValue.ToString(),
				Phai = (isnam.IsChecked == true) ? true : false,
				Hinhanh = "",
				Trangthai = btn_trangthai.IsChecked == true ? true : false
			};
			var result = XLNhanVien.PostThemNhanVien(sv);
			if (result == false)
			{
				MessageBox.Show("Thêm SINH VIÊN không thành công, Bạn kiểm tra lại dữ liệu nhập vào", "Thông báo");
				return;
			}
			MessageBox.Show("Thêm thành công", "Thông báo");
			clean();
			getLoad();
		}

		private void btn_sua(object sender, RoutedEventArgs e)
		{
			
			NhanVien sv = listnhanvien.SelectedItem as NhanVien;
			sv.TenNv = txt_tennv.Text;
			sv.Sdt = txt_sdt.Text;
			sv.Email = txt_email.Text;
			sv.Cmnd = txt_cmnd.Text;
			sv.Diachi = txt_diachi.Text;
			sv.Ngaysinh = date_ngaysinh.SelectedDate.Value;
			sv.Phai = (isnam.IsChecked == true) ? true : false;
			//Hinhanh = "",
			sv.Trangthai = btn_trangthai.IsChecked == true ? true : false;

            bool result = XLNhanVien.PutSuaTTNhanVien(sv);

			if (result == false)
			{
				MessageBox.Show("Sửa không thành công !", "Thông báo");
				return;

			}
			MessageBox.Show("Sửa thành công", "Thông báo");
			clean();
			getLoad();

		}
		private void btn_xoa(object sender, RoutedEventArgs e)
		{
			if (listnhanvien.SelectedItem == null) return;
			MessageBoxResult result = MessageBox.Show("Bạn có chắn chắn muốn xóa?", "Thông báo", MessageBoxButton.YesNo);
			switch (result)
			{
				case MessageBoxResult.No:
					break;
				case MessageBoxResult.Yes:
					bool kq =XLNhanVien.DeleteXoaNhanVien(listnhanvien.SelectedValue.ToString());
					if (kq == false)
					{
						MessageBox.Show("Không thể xóa dữ liệu do đã được sử dụng ở chức năng khác!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information); break;
					}
					MessageBox.Show("Xóa Thành Công", "Thông Báo");
					clean();
					getLoad();
					break;
			}
		}

		private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
		{
			xlc.textNumber(e);
		}

        private void listnhanvien_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
			if (listnhanvien.SelectedItem == null) return;
			NhanVien sv = listnhanvien.SelectedItem as NhanVien;
			txt_manv.Text = sv.MaNv.Trim();
			txt_tennv.Text = sv.TenNv.Trim();
			txt_diachi.Text = sv.Diachi.Trim();
			txt_email.Text = sv.Email.Trim();
			txt_sdt.Text = sv.Sdt.Trim();
			txt_cmnd.Text = sv.Cmnd.Trim();
			date_ngaysinh.SelectedDate = sv.Ngaysinh;
			txt_matkhau.Text = "*****";
			if (sv.Phai == true)
			{
				isnam.IsChecked = true;
			}
            else
            {
				isnu.IsChecked = true;
            }
			cmb_chucvu.SelectedValue=sv.MaChucVu;
			if (sv.Trangthai == true)
			{ 
				btn_trangthai.IsChecked = true; 
			}
			else
			{
				btn_trangthai.IsChecked = false;
			}

			txt_manv.IsReadOnly = true;
			txt_matkhau.IsReadOnly = true;
		}

        private void btn_lammoi(object sender, RoutedEventArgs e)
        {
			clean();
        }

        private void textnumberinput(object sender, TextCompositionEventArgs e)
        {
			xlc.textNumber(e);
        }
    }
}
