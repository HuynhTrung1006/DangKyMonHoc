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

namespace WPF_Admin_DangKyMonHoc
{
    /// <summary>
    /// Interaction logic for WPF_QLSV.xaml
    /// </summary>
    public partial class WPF_QLSV : Window
    {
        public WPF_QLSV()
        {
            InitializeComponent();
        }

        public void showDSSinhVien()
        {
            List<SinhVien> ds = XuLyQLSV.getlist();
            if (ds == null)
            {
                MessageBox.Show("Truy Cập Hệ Thông Bị Lỗi. Kiểm Tra Lại. Xin Cảm Ơn", "Thông Báo");
            }
            dg_sinhvien.ItemsSource = ds;
        }
        
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            showDSSinhVien();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void dg_sinhvien_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dg_sinhvien.SelectedItem == null) return;
            SinhVien sv = dg_sinhvien.SelectedItem as SinhVien;
            txt_mssv.Text = sv.MsSv;
            txt_hoten.Text = sv.TenSv;
            txt_diachi.Text = sv.Diachi;
            txt_email.Text = sv.Email;
            txt_cmnd.Text = sv.Cmnd;
            txt_matkhau.Text = sv.Matkhau;
            txt_khoa.Text = sv.MaKhoa;
            txt_lop.Text = sv.MaLop;
            txt_hedaotao.Text = sv.Hedaotao;
            if(sv.Phai==true)
            {
                rad_Nam.IsChecked=true;
            }
            else
            {
                rad_Nu.IsChecked = true;
            }
            

            Date_ngaysinh.SelectedDate = sv.Ngaysinh;
            if (sv.Trangthai == true) check_hoatdong.IsChecked = true;
        }

        private void btn_Them_Click(object sender, RoutedEventArgs e)
        {
            SinhVien sv = new SinhVien();
            sv.MsSv=txt_mssv.Text;
            sv.TenSv=txt_hoten.Text;
            sv.Diachi=txt_diachi.Text;
            sv.Email=txt_email.Text;
            sv.Cmnd=txt_cmnd.Text;
            sv.Matkhau=txt_matkhau.Text;
            sv.MaKhoa=txt_khoa.Text;
            sv.MaLop=txt_lop.Text;
            sv.Hedaotao=txt_hedaotao.Text;
            if (rad_Nam.IsChecked == true)
            {
                sv.Phai=true;
            }
            else
            {
                sv.Phai = false;
            }


            sv.Ngaysinh=Date_ngaysinh.SelectedDate;
            if (check_hoatdong.IsChecked == true) sv.Trangthai = true;
            sv.Trangthai = false;

            bool check = XuLyQLSV.postSinhVien(sv);
            if(check==false)
            {
                MessageBox.Show("Thêm Sinh Viên KHÔNG Thành Công", "Thông Báo");
                return;
            }
            MessageBox.Show("Thêm Sinh Viên Thành Công", "Thông Báo");
            showDSSinhVien();
        }

        private void btn_Xoa_Click(object sender, RoutedEventArgs e)
        {
            if (dg_sinhvien.SelectedItem == null) return;
            string id = dg_sinhvien.SelectedItem as string;
            bool check = XuLyQLSV.deleteSinhVien(id);
            if (check == false)
            {
                MessageBox.Show("Xóa Sinh Viên KHÔNG Thành Công", "Thông Báo");
                return;
            }
            MessageBox.Show("Xóa Sinh Viên Thành Công", "Thông Báo");
            showDSSinhVien();
        }

        private void btn_Sua_Click(object sender, RoutedEventArgs e)
        {
            SinhVien sv = new SinhVien();
            sv.MsSv = txt_mssv.Text;
            sv.TenSv = txt_hoten.Text;
            sv.Diachi = txt_diachi.Text;
            sv.Email = txt_email.Text;
            sv.Cmnd = txt_cmnd.Text;
            sv.Matkhau = txt_matkhau.Text;
            sv.MaKhoa = txt_khoa.Text;
            sv.MaLop = txt_lop.Text;
            sv.Hedaotao = txt_hedaotao.Text;
            if (rad_Nam.IsChecked == true)
            {
                sv.Phai = true;
            }
            else
            {
                sv.Phai = false;
            }


            sv.Ngaysinh = Date_ngaysinh.SelectedDate;
            if (check_hoatdong.IsChecked == true) sv.Trangthai = true;
            sv.Trangthai = false;

            bool check = XuLyQLSV.updateSinhVien(sv);
            if (check == false)
            {
                MessageBox.Show("Sửa Sinh Viên KHÔNG Thành Công", "Thông Báo");
                return;
            }
            MessageBox.Show("Sửa Sinh Viên Thành Công", "Thông Báo");
            showDSSinhVien();
        }

        private void btn_Thoat_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow n = new MainWindow();
            n.Close();
        }
    }
}
