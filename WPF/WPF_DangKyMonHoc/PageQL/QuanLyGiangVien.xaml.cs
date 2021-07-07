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
    /// Interaction logic for QuanLyGiangVien.xaml
    /// </summary>
    public partial class QuanLyGiangVien 
    {
		private Xuly_Chung xlc = new Xuly_Chung();
		public QuanLyGiangVien()
        {
            InitializeComponent();
			getLoad();
        }

		public void getLoad()
		{
			List<GiangVien> list = XLGiangVien.getAll();
			if (list == null) MessageBox.Show("Lỗi tải Server!!!", "ERROR");
			listgiangvien.ItemsSource = list;

			List<Khoa> listkhoa = XLKhoa.getds();
			if (listkhoa == null) MessageBox.Show("Lỗi tải Lớp từ Server!", "ERROR");
			cmb_khoa.ItemsSource = listkhoa;

			List<ChucVu> listcv = XLChucVu.dschucvu();
			if (listcv == null) MessageBox.Show("Lỗi tải Lớp từ Server!", "ERROR");
			cmb_chucvu.ItemsSource = listcv;

			
			List<HocHam> listhh = xlc.GetHocHams();
			if (listhh == null) MessageBox.Show("Lỗi tải Lớp từ Server!", "ERROR");
			cmb_hocham.ItemsSource = listhh;
		}
		public void clean()
		{
			txt_ma.Text = "";
			txt_ten.Text = "";
			txt_dienthoai.Text = "";
			txt_email.Text = "";
			txt_cmnd.Text = "";
			txt_diachi.Text = "";
			date_ngaysinh.SelectedDate = null;
			txt_matkhau.Text = "";
			btn_trangthai.IsChecked = false;

			txt_ma.IsReadOnly = false;
			txt_matkhau.IsReadOnly =false;
		}
		private void btn_them(object sender, RoutedEventArgs e)
		{
			HocHam hh = cmb_hocham.SelectedItem as HocHam;
			GiangVien sv = new GiangVien
			{
				MaGv = txt_ma.Text,
				TenGv = txt_ten.Text,
				Sdt = txt_dienthoai.Text,
				Email = txt_email.Text,
				Cmnd = txt_cmnd.Text,
				Diachi = txt_diachi.Text,
				Matkhau = txt_matkhau.Text,
				Ngaysinh = date_ngaysinh.SelectedDate.Value,
				MaChucVu = cmb_chucvu.SelectedValue.ToString(),
				Phai = (isnam.IsChecked == true) ? true : false,
				Hinhanh = "",
				Trangthai = btn_trangthai.IsChecked == true ? true : false,
				MaKhoa= cmb_khoa.SelectedValue.ToString(),
				Hocham=hh.tenHocHam
			};
			var result = XLGiangVien.PostThemGiangVien(sv);
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
			GiangVien b = listgiangvien.SelectedItem as GiangVien;
			//GiangVien sv = new GiangVien
			//{
			//	MaGv = txt_ma.Text,
			//	TenGv = txt_ten.Text,
			//	Sdt = txt_dienthoai.Text,
			//	Email = txt_email.Text,
			//	Cmnd = txt_cmnd.Text,
			//	Diachi = txt_diachi.Text,
			//	Matkhau = txt_matkhau.Text,
			//	Ngaysinh = date_ngaysinh.SelectedDate.Value,
			//	MaChucVu = cmb_chucvu.SelectedValue.ToString(),
			//	Phai = (isnam.IsChecked == true) ? true : false,
			//	Hinhanh = "",
			//	Trangthai = btn_trangthai.IsChecked == true ? true : false,
			//	MaKhoa = cmb_khoa.SelectedValue.ToString(),
			//	Hocham = cmb_hocham.SelectedValue.ToString()
			//};
			b.TenGv = txt_ten.Text;
			b.Sdt = txt_dienthoai.Text;
			b.Email = txt_email.Text;
			b.Cmnd = txt_cmnd.Text;
			b.Diachi = txt_diachi.Text;
			b.Ngaysinh = date_ngaysinh.SelectedDate.Value;
			b.Trangthai = btn_trangthai.IsChecked == true ? true : false;
			HocHam hh = cmb_hocham.SelectedItem as HocHam;
			b.Hocham = hh.tenHocHam;

            bool result = XLGiangVien.PutSuaTTGiangVien(b);

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
			if (listgiangvien.SelectedItem == null) return;
			MessageBoxResult result = MessageBox.Show("Bạn có chắn chắn muốn xóa?", "Thông báo", MessageBoxButton.YesNo);
			switch (result)
			{
				case MessageBoxResult.No:
					break;
				case MessageBoxResult.Yes:
					bool kq = XLGiangVien.DeleteXoaGiangVien(listgiangvien.SelectedValue.ToString());
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
			if (listgiangvien.SelectedItem == null) return;
			GiangVien sv = listgiangvien.SelectedItem as GiangVien;
			txt_ma.Text = sv.MaGv.Trim();
			txt_ten.Text = sv.TenGv.Trim();
			txt_diachi.Text = sv.Diachi.Trim();
			txt_email.Text = sv.Email.Trim();
			txt_dienthoai.Text = sv.Sdt.Trim();
			txt_cmnd.Text = sv.Cmnd.Trim();
			date_ngaysinh.SelectedDate = sv.Ngaysinh;
			txt_matkhau.Text = "*****";
			if (sv.Phai == true)
			{
				isnam.IsChecked = true;
			}
			cmb_chucvu.SelectedValue = sv.MaChucVu;
			if (sv.Trangthai == true)
			{
				btn_trangthai.IsChecked = true;
			}
			else
			{
				btn_trangthai.IsChecked = false;
			}

			HocHam a = xlc.hienthihh(sv.Hocham);
			cmb_hocham.SelectedValue = a.ID;
			cmb_khoa.SelectedValue = sv.MaKhoa;

			txt_ma.IsReadOnly = true;
			txt_matkhau.IsReadOnly = true;
			
		}

		private void btn_lammoi(object sender, RoutedEventArgs e)
		{
			clean();
		}
	}
}
