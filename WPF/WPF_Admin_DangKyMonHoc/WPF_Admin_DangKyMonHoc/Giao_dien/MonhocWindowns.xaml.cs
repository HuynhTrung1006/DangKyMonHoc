
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
    /// Interaction logic for MonhocWindowns.xaml
    /// </summary>
    public partial class MonhocWindowns : Window
    {
        public MonhocWindowns()
        {
            InitializeComponent();
        }
        private void hienthi()
        {
            List<MonHoc> ds = CXuLyMonHoc.getDSMonhoc();
            if (ds == null)
            {
                MessageBox.Show("Thì thôi nha");

            }
            else
            {
                DTmonhoc.ItemsSource = ds;
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            hienthi();
        }

        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            MonHoc mh = new MonHoc();
            mh.MaMh = txtMsmh.Text;
            mh.TenMh = txtTenmh.Text;
            mh.Sotc = (byte)int.Parse(txtSoTC.Text);
            mh.HeSoHp = (byte)int.Parse(txtHeSoHp.Text);
            if(ChTH.IsChecked==true)
            {
                mh.ThucHanh = true;

            } 
            else
            {
                mh.ThucHanh = false;
            }    
            mh.MaKhoi = txtMaKhoi.Text;
            bool kq = CXuLyMonHoc.themMonhoc(mh);
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
            
            bool ok = CXuLyMonHoc.xoaMonhoc(txtMsmh.Text);
            if (ok == true) hienthi();
            else MessageBox.Show("Khong xoa duoc !!!");
        }

        private void btnSua_Click(object sender, RoutedEventArgs e)
        {
            MonHoc mh = new MonHoc();
            mh.MaMh = txtMsmh.Text;
            mh.TenMh = txtTenmh.Text;
            mh.Sotc = (byte)int.Parse(txtSoTC.Text);
            mh.HeSoHp = (byte)int.Parse(txtHeSoHp.Text);
            if (ChTH.IsChecked == true)
            {
                mh.ThucHanh = true;

            }
            else
            {
                mh.ThucHanh = false;
            }
            mh.MaKhoi = txtMaKhoi.Text;
            bool ok = CXuLyMonHoc.suaMonhoc(mh);
            if (ok == true) hienthi();

            else
            {
                MessageBox.Show("Khong sua duoc!!!");
            }
        }

        private void DTmonhoc_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DTmonhoc.SelectedItem == null) return;
            MonHoc mh = DTmonhoc.SelectedItem as MonHoc;
            txtMsmh.Text = mh.MaMh;
            txtTenmh.Text = mh.TenMh;
            txtSoTC.Text = mh.Sotc.ToString();
            txtHeSoHp.Text = mh.HeSoHp.ToString();
            if (mh.ThucHanh == true) ChTH.IsChecked = true;
            else 
                ChTH.IsChecked = false;
            txtMaKhoi.Text = mh.MaKhoi;

        }
    }
}
