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
	/// Interaction logic for SignIn_View.xaml
	/// </summary>
	public partial class SignIn_View : Window
	{
		public SignIn_View()
		{
			InitializeComponent();
		}

		private void btnDangNhap_Click(object sender, RoutedEventArgs e)
		{
			NhanVien a = new NhanVien();
			a.MaNv = txtTaikhoan.Text;
			a.MatKhau = txtMatkhau.Password;
			bool kq = CXulyDangNhap.Login(a);
			if(kq==true)
			{
				MessageBox.Show("Đăng nhập thành công !");
				MainWindow w = new MainWindow();
				this.Hide();
				w.ShowDialog();
			}
			else
			{
				MessageBox.Show("Đăng nhập thất bại, vui lòng kiểm tra lại tài khoản hoặc mật khẩu!");
				txtTaikhoan.Focus();
				return;
			}
		}
	}
}
