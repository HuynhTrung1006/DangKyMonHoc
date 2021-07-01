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
	/// Interaction logic for FixAfterLogin.xaml
	/// </summary>
	public partial class FixAfterLogin : Window
	{
		public FixAfterLogin()
		{
			InitializeComponent();
		}

		private void btnQuanLyGiangVien_Click(object sender, RoutedEventArgs e)
		{
			Main.Content = new Page_QLGiangVien();
		}
	}
}
