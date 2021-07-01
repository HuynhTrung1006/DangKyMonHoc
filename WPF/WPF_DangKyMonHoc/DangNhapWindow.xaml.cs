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

namespace Wpf_DangKyMonHoc
{
	/// <summary>
	/// Interaction logic for DangNhapWindow.xaml
	/// </summary>
	public partial class DangNhapWindow : Window
	{
		public DangNhapWindow()
		{
			InitializeComponent();
		}

		private void btnDangNhap_Click(object sender, RoutedEventArgs e)
		{
			FixAfterLogin b = new FixAfterLogin();
			b.Show();
		}

		private void btnThoat_Click(object sender, RoutedEventArgs e)
		{
			
		}
	}
}
