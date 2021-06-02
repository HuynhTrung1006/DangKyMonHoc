using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WPF_Admin_DangKyMonHoc.ModelsClass;

namespace WPF_Admin_DangKyMonHoc.XuLy
{
    class XuLyQLSV
    {
        private static HttpClient hc = new HttpClient();

        public static List<SinhVien> getlist()
        {
            try
            {
                string url = @"https://localhost:44357/api/QLSV";
                var kq = hc.GetAsync(url);
                kq.Wait();
                if (kq.Result.IsSuccessStatusCode == false) return null;
                var ok = kq.Result.Content.ReadAsAsync<List<SinhVien>>();
                ok.Wait();
                return ok.Result.ToList();

            }
            catch (Exception)
            {
                return null;
            }
        }
        public static bool postSinhVien(SinhVien sv)
        {
            try
            {
                string url = @"https://localhost:44357/api/QLSV";
                var kq = hc.PostAsJsonAsync(url, sv);
                kq.Wait();
                return kq.Result.IsSuccessStatusCode;

            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool deleteSinhVien(string id)
        {
            try
            {
                string url = @"https://localhost:44357/api/QLSV/" + id;
                var kq = hc.DeleteAsync(url);
                kq.Wait();
                return kq.Result.IsSuccessStatusCode;

            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool updateSinhVien(SinhVien sv)
        {
            try
            {
                string url = @"https://localhost:44357/api/QLSV/"+sv.MsSv;
                var kq = hc.PutAsJsonAsync(url, sv);
                kq.Wait();
                return kq.Result.IsSuccessStatusCode;

            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
