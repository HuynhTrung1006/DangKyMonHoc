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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPF_Admin_DangKyMonHoc.View;
namespace WPF_Admin_DangKyMonHoc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

		private void btnQLNV_Click(object sender, RoutedEventArgs e)
		{

            View.QLNV_View view = new QLNV_View();
            view.Show();
		}

		private void btnQLGV_Click(object sender, RoutedEventArgs e)
		{
            View.QLGV_View view = new View.QLGV_View();
            view.Show();
        }

		private void btnDangXuat_Click(object sender, RoutedEventArgs e)
		{
            this.Close();
            View.SignIn_View view = new SignIn_View();
            view.Show();

		}
	}
}
