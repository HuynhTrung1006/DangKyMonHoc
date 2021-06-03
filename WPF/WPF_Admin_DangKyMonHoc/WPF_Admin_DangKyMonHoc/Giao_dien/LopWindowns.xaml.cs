using API_DangKyMonHoc.Models;
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
using WPF_Admin_DangKyMonHoc.XuLy;

namespace WPF_Admin_DangKyMonHoc.Giao_dien
{
    /// <summary>
    /// Interaction logic for LopWindowns.xaml
    /// </summary>
    public partial class LopWindowns : Window
    {
        public LopWindowns()
        {
            InitializeComponent();
        }
        private void hienthi()
        {
            List<Lop> ds = CXuLyLop.getDSMonhoc();
            if (ds == null)
            {
                MessageBox.Show("Thì thôi nha");

            }
            else
            {
                DTLop.ItemsSource = ds;
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            hienthi();
        }

        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            Lop l = new Lop();
            l.MaLop = txtMaLop.Text;
            l.TenLop   = txtTenLop.Text;
            l.SiSo = (byte)int.Parse(txtSiSo.Text);
            l.NienKhoa = txtNienKhoa.Text  ;
            
            bool kq = CXuLyLop.themLop(l);
            if (kq == true)
            {
                hienthi();
            }
            else
            {
                MessageBox.Show("Thêm ko thành công");
            }
        }

        private void btnXoa_Click(object sender, RoutedEventArgs e)
        {
            if (DTLop.SelectedValue == null) return;
            string MaLop = DTLop.SelectedValue.ToString();
            bool ok = CXuLyLop.xoaLop(MaLop);
            if (ok == true) hienthi();
            else MessageBox.Show("Khong xoa duoc !!!");
        }

        private void btnSua_Click(object sender, RoutedEventArgs e)
        {
            Lop l = new Lop();
            l.MaLop = txtMaLop.Text;
            l.TenLop = txtTenLop.Text;
            l.SiSo = (byte)int.Parse(txtSiSo.Text);
            l.NienKhoa = txtNienKhoa.Text;
            bool ok = CXuLyLop.suaLop(l);
            if (ok == true)
            {
                hienthi();
                return;
            }
            else
            {
                MessageBox.Show("Khong sua duoc!!!");
            }
        }
    }
}
