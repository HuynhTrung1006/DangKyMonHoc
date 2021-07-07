using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Input;
using Wpf_DangKyMonHoc.Models;

namespace Wpf_DangKyMonHoc.XuLy
{
    class Xuly_Chung
    {

        public string local()
        {
            return @"https://localhost:44319/api/";
        }
        public void textNumber(TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        public List<GioiTinh> getGT()
        {
            List<GioiTinh> gt = new List<GioiTinh>();
            gt.Add(new GioiTinh { ID = true, TenGT = "Nam" });
            gt.Add(new GioiTinh { ID = false, TenGT = "Nữ" });
            return gt;
        }

        public List<HocHam> GetHocHams()
        {
            List<HocHam> hh = new List<HocHam>();
            hh.Add(new HocHam { ID = 1, tenHocHam = "Cử Nhân" });
            hh.Add(new HocHam { ID = 2, tenHocHam = "Thạc Sĩ" });
            hh.Add(new HocHam { ID = 3, tenHocHam = "Tiến Sĩ" });
            //hh.Add(new HocHam { ID = 4, tenHocHam = "Tiến Sĩ Khoa Học" });
            hh.Add(new HocHam { ID = 4, tenHocHam = "PGS.Tiến Sĩ" });
            hh.Add(new HocHam { ID = 5, tenHocHam = "GS.Tiến Sĩ" });
            return hh; 
        }

        public HocHam hienthihh(string ten)
        {
            List<HocHam> list = GetHocHams();
            foreach(var a in list)
            {
                if (a.tenHocHam.Contains(ten.Trim()))
                    return a;
            }
            return null;
        }
    }
}
