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
using WPF_Admin_DangKyMonHoc.ModelsClass;
using WPF_Admin_DangKyMonHoc.XuLy;

namespace WPF_Admin_DangKyMonHoc.View
{
	/// <summary>
	/// Interaction logic for QLNV_View.xaml
	/// </summary>
	public partial class QLNV_View : Window
	{
		public QLNV_View()
		{
			InitializeComponent();
		}

		private void dgNhanVien_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (dgNhanVien.SelectedItem == null)
				return;
			NhanVien a = dgNhanVien.SelectedItem as NhanVien;
			txtMaNV.Text = a.MaNv;
			txtTenNV.Text = a.TenNv;
			txtSodt.Text = a.SdtNv;
			txtEmail.Text = a.EmailNv;
			txtChucvu.Text = a.Chucvu;
			txtMatkhau.Text = a.MatKhau;
			dpNgaysinh.SelectedDate = a.NgaysinhNv;
			if (a.Trangthai == true)
				radHD.IsChecked = true;
			else
				radNHD.IsChecked = true;
		}

		private void btnSua_Click(object sender, RoutedEventArgs e)
		{
			NhanVien a = dgNhanVien.SelectedItem as NhanVien;
			a.TenNv = txtTenNV.Text;
			a.SdtNv = txtSodt.Text;
			a.EmailNv = txtEmail.Text;
			a.Chucvu = txtChucvu.Text;
			a.NgaysinhNv = dpNgaysinh.SelectedDate;
			a.MatKhau = txtMatkhau.Text;
			a.Trangthai = radHD.IsChecked;
			bool kq = CXulyQLNV.PutSuaNV(a);
			if (kq == true)
			{
				MessageBox.Show("Sửa thành công !");
				hienthi();
			}
			else
			{
				MessageBox.Show("Sửa thất bại");
				return;
			}
		}

		private void btnXoa_Click(object sender, RoutedEventArgs e)
		{
			NhanVien a = dgNhanVien.SelectedItem as NhanVien;
			bool kq = CXulyQLNV.DeleteXoaNV(a.MaNv);
			if(kq==true)
			{
				MessageBox.Show("Xóa thành công !");
				hienthi();
			}
			else
			{
				MessageBox.Show("Xóa thất bại !");
				hienthi();
			}	
		}

		private void btnThem_Click(object sender, RoutedEventArgs e)
		{
			NhanVien a = new NhanVien();
			a.MaNv = txtMaNV.Text;
			a.TenNv = txtTenNV.Text;
			a.SdtNv = txtSodt.Text;
			a.EmailNv = txtEmail.Text;
			a.Chucvu = txtChucvu.Text;
			a.NgaysinhNv = dpNgaysinh.SelectedDate;
			a.MatKhau = txtMatkhau.Text;
			a.Trangthai = radHD.IsChecked;
			bool kq = CXulyQLNV.PostThemNV(a);
			if(kq==true)
			{
				MessageBox.Show("Thêm thành công !");
				hienthi();
			}
			else
			{
				MessageBox.Show("Thêm thất bại");
				return;
			}
		}

		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			hienthi();
		}
		private void hienthi()
		{
			List<NhanVien> dsnv = CXulyQLNV.getAllDSNV();
			if(dsnv==null)
			{
				MessageBox.Show("Lỗi kết nối dữ liệu", "Warning");

			}
			dgNhanVien.ItemsSource = dsnv;
			txtMaNV.Clear();
			txtTenNV.Clear();
			txtSodt.Clear();
			txtEmail.Clear();
			txtMatkhau.Clear();
			txtChucvu.Clear();
			radHD.IsChecked = true;
		}
	}
}
