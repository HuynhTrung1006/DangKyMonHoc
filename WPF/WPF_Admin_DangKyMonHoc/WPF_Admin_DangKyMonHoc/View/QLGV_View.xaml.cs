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
	/// Interaction logic for QLGV_View.xaml
	/// </summary>
	public partial class QLGV_View : Window
	{
		
		public QLGV_View()
		{
			InitializeComponent();
		}
		public void hienthi()
		{
			List<GiangVien> dsgv = CXulyQLGV.getAllGV();
			if (dsgv == null)
				MessageBox.Show("Lỗi kết nối dữ liệu");
			dgGiangVien.ItemsSource = dsgv;
			cboKhoa.ItemsSource = CXulyKhoa.getAllGV();
			txtMaGV.Clear();
			txtTenGV.Clear();
			txtEmail.Clear();
			txtDiaChi.Clear();
			txtHocHam.Clear();
			txtChucvu.Clear();
			txtSodt.Clear();
			dpNgaylapHD.ClearValue(UidProperty);
			cboKhoa.ClearValue(UidProperty);
			radNu.IsChecked = true;

		}

		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			hienthi();
		}

		private void btnThem_Click(object sender, RoutedEventArgs e)
		{
			GiangVien a = new GiangVien();
			a.MaGv = txtMaGV.Text;
			a.TenGv = txtTenGV.Text;
			a.Phai = radNam.IsChecked;
			a.Ngaysinh = dpNgaylapHD.SelectedDate;
			a.Sdt = txtSodt.Text;
			a.Email = txtEmail.Text;
			a.Diachi = txtDiaChi.Text;
			a.Chucvu = txtChucvu.Text;
			a.HocHam = txtHocHam.Text;
			a.MaKhoa = cboKhoa.SelectedValue.ToString();
			bool kq = CXulyQLGV.PostThemGV(a);
			if (kq == false)
				MessageBox.Show("Thêm giảng viên thất bại");
			else
			{
				MessageBox.Show("Thêm thành công !");
				hienthi();
			}
		}

		private void cboKhoa_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{

		}

		private void dgGiangVien_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (dgGiangVien.SelectedItem == null)
				return;
			else
			{
				GiangVien a = dgGiangVien.SelectedItem as GiangVien;
				txtMaGV.Text = a.MaGv;
				txtMaGV.IsReadOnly = true;
				txtTenGV.Text = a.TenGv;
				dpNgaylapHD.SelectedDate = a.Ngaysinh;
				txtDiaChi.Text = a.Diachi;
				if (a.Phai == true)
					radNam.IsChecked = true;
				else
					radNu.IsChecked = true;
				txtEmail.Text = a.Email;
				txtSodt.Text = a.Sdt;
				cboKhoa.SelectedValue = a.MaKhoa;
				txtHocHam.Text = a.HocHam;
				txtChucvu.Text = a.Chucvu;
			}
			
		}

		private void btnXoa_Click(object sender, RoutedEventArgs e)
		{
			GiangVien a = dgGiangVien.SelectedItem as GiangVien;
			bool kq = CXulyQLGV.DeleteXoaGV(a.MaGv);
			if(kq==true)
			{
				MessageBox.Show("Xóa thành công !");
				hienthi();
			}
			else
			{
				MessageBox.Show("Xóa thất bại !");
			}

		}

		private void btnSua_Click(object sender, RoutedEventArgs e)
		{
			GiangVien a = dgGiangVien.SelectedItem as GiangVien;
			a.TenGv = txtTenGV.Text;
			a.Phai = radNam.IsChecked;
			a.Ngaysinh = dpNgaylapHD.SelectedDate;
			a.Sdt = txtSodt.Text;
			a.Email = txtEmail.Text;
			a.Diachi = txtDiaChi.Text;
			a.Chucvu = txtChucvu.Text;
			a.HocHam = txtHocHam.Text;
			a.MaKhoa = cboKhoa.SelectedValue.ToString();
			bool kq = CXulyQLGV.PutSuaGiangVien(a);
			if(kq==true)
			{
				MessageBox.Show("Sửa thành công !");
				hienthi();
			}	
			else
			{
				MessageBox.Show("Sửa thất bại !");
			}	
		}

	
	}
}
