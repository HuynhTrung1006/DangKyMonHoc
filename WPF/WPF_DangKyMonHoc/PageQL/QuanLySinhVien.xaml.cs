﻿using Microsoft.AspNetCore.Http;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
using Wpf_DangKyMonHoc.Xuly;
using Wpf_DangKyMonHoc.XuLy;

namespace Wpf_DangKyMonHoc.PageQL
{
    /// <summary>
    /// Interaction logic for QuanLySinhVien.xaml
    /// </summary>
    public partial class QuanLySinhVien
    {
		private readonly Xuly_Chung xlc = new Xuly_Chung();
        public QuanLySinhVien()
        {
            InitializeComponent();
			getLoad();
        }

        private void litsinhvien_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
			if (listsinhvien.SelectedItem == null) return;
			SinhVien sv = listsinhvien.SelectedItem as SinhVien;
			txt_masv.Text = sv.MaSv;
			txt_ten.Text = sv.TenSv;
			txt_diachi.Text = sv.Diachi;
			txt_email.Text = sv.Email;
			txt_sdt.Text = sv.Sdt;
			txt_cmnd.Text = sv.Cnmd;
			date_ngaysinh.SelectedDate = sv.Ngaysinh;
			txt_matkhau.Text = "*****";
			cmb_phai.SelectedValue = sv.Phai;

            cmb_Lop.SelectedValue = sv.MaLop;
			if (sv.Trangthai == true)
			{ 
				btn_trangthai.IsChecked = true; 
			}
			else
            {
				btn_trangthai.IsChecked = false;
			}

			txt_masv.IsReadOnly = true;
			txt_matkhau.IsReadOnly = true;
			

        }

		public void getLoad()
		{
			List<SinhVien> list = XLSinhVien.getAll();
			if (list == null) MessageBox.Show("Lỗi tải Server!!!", "ERROR");
			listsinhvien.ItemsSource = list;

			List<Lop> listlop = XLLop.get();
			if (listlop == null) MessageBox.Show("Lỗi tải Lớp từ Server!", "ERROR");
			cmb_Lop.ItemsSource = listlop;

			cmb_phai.ItemsSource = xlc.getGT();
		}
		public void clean()
		{
			txt_masv.Text = "";
			txt_ten.Text = "";
			txt_sdt.Text = "";
			txt_email.Text = "";
			txt_cmnd.Text = "";
			txt_diachi.Text = "";
			date_ngaysinh.SelectedDate = null;
			txt_matkhau.Text = "";
			txt_masv.IsReadOnly = false;
			txt_matkhau.IsReadOnly = false;
			btn_trangthai.IsChecked = false;
		}
		private void btn_them(object sender, RoutedEventArgs e)
		{
			GioiTinh gt = cmb_phai.SelectedItem as GioiTinh;
			SinhVien sv = new SinhVien
			{
				MaSv = txt_masv.Text,
				TenSv = txt_ten.Text,
				Sdt = txt_sdt.Text,
				Email = txt_email.Text,
				Cnmd = txt_cmnd.Text,
				Diachi = txt_diachi.Text,
				Matkhau = txt_matkhau.Text,
				Ngaysinh = date_ngaysinh.SelectedDate.Value,
				MaLop = cmb_Lop.SelectedValue.ToString(),
				Phai = gt.ID,
				Hinhanh = "",
				Trangthai = btn_trangthai.IsChecked == true ? true : false
			};
			var result = XLSinhVien.PostThemSinhVien(sv);
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
			GioiTinh gt = cmb_phai.SelectedItem as GioiTinh;
			SinhVien sv = listsinhvien.SelectedItem as SinhVien;
			sv.TenSv = txt_ten.Text;
			sv.Sdt = txt_sdt.Text;
			sv.Email = txt_email.Text;
			sv.Cnmd = txt_cmnd.Text;
			sv.Ngaysinh = date_ngaysinh.SelectedDate.Value;
			//sv.Hinhanh = "";
			sv.Trangthai = btn_trangthai.IsChecked == true ? true : false;

            bool result = XLSinhVien.PutSuaTTSinhVien(sv);

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
			SinhVien sv = listsinhvien.SelectedItem as SinhVien;
			if (sv == null) return;
			MessageBoxResult result = MessageBox.Show("Bạn có chắn chắn muốn xóa?", "Thông báo", MessageBoxButton.YesNo);
            switch (result)
            {
                case MessageBoxResult.No:
                    break;
                case MessageBoxResult.Yes:
					bool kq = XLNhanVien.DeleteXoaNhanVien(listsinhvien.SelectedValue.ToString());
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

        private void btn_chonanh(object sender, RoutedEventArgs e)
        {
			OpenFileDialog dlg = new OpenFileDialog();
			if (dlg.ShowDialog() == true)
			{
				FileStream f = new FileStream(dlg.FileName, FileMode.Open, FileAccess.Read);
				byte[] buf = new byte[f.Length];
				f.Read(buf, 0, (int)f.Length);
				f.Close();
				MemoryStream ms = new MemoryStream(buf);
				BitmapImage bm = new BitmapImage();
				bm.BeginInit();
				bm.StreamSource = ms;
				bm.EndInit();
				imgHinh.Source = bm;
			}
		}

        private void btn_test(object sender, RoutedEventArgs e)
        {
			IFormFile file = imgHinh.Source as IFormFile;
			string ten = "SinhVien";
			FileUpload a = new FileUpload { Files = file, name = ten };
			bool result = XLAnh.Post(a);
			if(result==false)
            {
				MessageBox.Show("không được rồi Trung ơi");
				return;
            }
			MessageBox.Show("Thành công");
        }

        private void btn_lammoi(object sender, RoutedEventArgs e)
        {
			clean();
        }
    }
}
