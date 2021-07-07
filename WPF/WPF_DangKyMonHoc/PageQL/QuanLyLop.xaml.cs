using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Wpf_DangKyMonHoc.Models;
using Wpf_DangKyMonHoc.WindowQL;
using Wpf_DangKyMonHoc.Xuly;
using Wpf_DangKyMonHoc.XuLy;

namespace Wpf_DangKyMonHoc.PageQL
{
    /// <summary>
    /// Interaction logic for QuanLyLop.xaml
    /// </summary>
    public partial class QuanLyLop 
    {
        private readonly Xuly_Chung xlc = new Xuly_Chung();
        public QuanLyLop()
        {
            InitializeComponent();
        }

        private void btn_Khoa(object sender, RoutedEventArgs e)
        {
            var n = new QuanLyKhoa();
            n.ShowDialog();
            List<Nganh> listnganh = XLNganh.getds();
            if (listnganh == null) MessageBox.Show("Lỗi tải Ngành!!!", "ERROR");
            cmb_nganh.ItemsSource = listnganh;
        }

        private void btn_NK(object sender, RoutedEventArgs e)
        {
            var n = new QuanLyNienKhoa();
            n.ShowDialog();
            List<NienKhoa> listnienkhoa = XLNienKhoa.getds();
            if (listnienkhoa == null) MessageBox.Show("Lỗi tải Niên khóa!!!", "ERROR");
            cmb_nienkhoa.ItemsSource = listnienkhoa;
        }

        public void getLoad()
        {
            List<Lop> list = XLLop.get();
            if (list == null) MessageBox.Show("Lỗi tải Lớp!!!", "ERROR");
            listLop.ItemsSource = list;

            List<Nganh> listnganh = XLNganh.getds();
            if (listnganh == null) MessageBox.Show("Lỗi tải Ngành!!!", "ERROR");
            cmb_nganh.ItemsSource = listnganh;

            List<NienKhoa> listnienkhoa = XLNienKhoa.getds();
            if (listnienkhoa == null) MessageBox.Show("Lỗi tải Niên khóa!!!", "ERROR");
            cmb_nienkhoa.ItemsSource = listnienkhoa;

            List<HeDaoTao> listhedaotao = Xuly_HDT.getAllHeDaoTao();
            if (listhedaotao == null) MessageBox.Show("Lỗi tải Hệ Đào Tạo!!!", "ERROR");
            cmb_hedaotao.ItemsSource = listhedaotao;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            getLoad();
        }

        private void btn_them(object sender, RoutedEventArgs e)
        {
            byte siso = 0;
            if(txt_siso.Text!="") siso = byte.Parse(txt_siso.Text);
            if (txt_malop.Text == "" || txt_tenlop.Text == "" || cmb_hedaotao.SelectedValue.ToString() == null || cmb_nganh.SelectedValue.ToString() == null
                || cmb_nienkhoa.SelectedValue.ToString() == null || siso > 0)
            {
                MessageBox.Show("Điền đầy đủ thông tin hoặc thông tin chưa chính xác!", "Thông báo");
                return;
            }
            Lop lop = new Lop
            {
                MaLop = txt_malop.Text,
                TenLop = txt_tenlop.Text,
                MaNganh = cmb_nganh.SelectedValue.ToString(),
                MaNk = cmb_nienkhoa.SelectedValue.ToString(),
                MaDt = cmb_hedaotao.SelectedValue.ToString(),
                Siso = siso
            };
            var result = XLLop.Post(lop);
            if (result == false)
            {
                MessageBox.Show("Thêm hệ đào tạo không thành công", "Thông báo");
                return;
            }
            MessageBox.Show("Thêm hệ đào tạo thành công", "Thông báo");
            //clean();
            getLoad();
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            xlc.textNumber(e);
        }

        private void btn_HDT(object sender, RoutedEventArgs e)
        {
            var n = new Hedaotao_Window(); n.ShowDialog();
            List<HeDaoTao> listhedaotao = Xuly_HDT.getAllHeDaoTao();
            if (listhedaotao == null) MessageBox.Show("Lỗi tải Hệ Đào Tạo!!!", "ERROR");
            cmb_hedaotao.ItemsSource = listhedaotao;
        }

        private void btn_xoa(object sender, RoutedEventArgs e)
        {
            if (listLop.SelectedValue.ToString() == null) return;
            MessageBoxResult result = MessageBox.Show("Bạn có chắn chắn muốn xóa?", "Thông báo", MessageBoxButton.YesNo);
            switch (result)
            {
                case MessageBoxResult.No:
                    break;
                case MessageBoxResult.Yes:
                    
                    bool kq = XLLop.Delete(listLop.SelectedValue.ToString());
                    if (kq == false)
                    {
                        MessageBox.Show("Không thể xóa dữ liệu do đã được sử dụng ở chức năng khác!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                        break;
                    }
                    MessageBox.Show("Xóa Thành Công", "Thông Báo");
                    //clean();
                    getLoad();
                    break;
            }
        }

        private void btn_lammoi(object sender, RoutedEventArgs e)
        {
            txt_malop.IsReadOnly = false;
            cmb_hedaotao.IsReadOnly = false;
            cmb_nganh.IsReadOnly =  false;
            cmb_nienkhoa.IsReadOnly = false;
            txt_malop.Text = "";
            txt_tenlop.Text = "";
            txt_siso.Text = "";
            getLoad();
        }

        private void listLop_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listLop.SelectedItem == null)
                return;
            Lop l = listLop.SelectedItem as Lop;
            txt_malop.Text = l.MaLop;
            txt_tenlop.Text = l.TenLop;
            txt_siso.Text = l.Siso.ToString() ;
            cmb_hedaotao.SelectedValue = l.MaDt;
            cmb_nienkhoa.SelectedValue = l.MaNk;
            cmb_nganh.SelectedValue = l.MaNganh;

            txt_malop.IsReadOnly = true;
            cmb_hedaotao.IsReadOnly = true;
            cmb_nganh.IsReadOnly = true;
            cmb_nienkhoa.IsReadOnly = true;
        }

        private void btn_sua(object sender, RoutedEventArgs e)
        {
            if (listLop.SelectedValue.ToString() == null)
                return;
            Lop lop = listLop.SelectedItem as Lop;
            lop.TenLop = txt_tenlop.Text;
            lop.Siso = byte.Parse(txt_siso.Text);
            bool result = XLLop.Put(lop);

            if (result == false)
            {
                MessageBox.Show("Sửa không thành công !", "Thông báo");
                return;

            }
            MessageBox.Show("Sửa thành công", "Thông báo");
            txt_malop.IsReadOnly = false;
            cmb_hedaotao.IsReadOnly = false;
            cmb_nganh.IsReadOnly = false;
            cmb_nienkhoa.IsReadOnly = false;
            txt_malop.Text = "";
            txt_tenlop.Text = "";
            txt_siso.Text = "";
            getLoad();
        }
    }
}
