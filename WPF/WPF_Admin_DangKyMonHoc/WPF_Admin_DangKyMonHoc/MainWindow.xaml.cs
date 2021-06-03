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
using WPF_Admin_DangKyMonHoc;
using WPF_Admin_DangKyMonHoc.Giao_dien;

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
        private void btnMonhoc_Click(object sender, RoutedEventArgs e)
        {
            Giao_dien.MonhocWindowns w = new MonhocWindowns();
            w.Show();
        }

        private void btnLop_Click(object sender, RoutedEventArgs e)
        {
            Giao_dien.LopWindowns w = new LopWindowns();
            w.Show();


        }
    }
}
