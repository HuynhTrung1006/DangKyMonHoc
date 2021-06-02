using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Admin_DangKyMonHoc.XuLy
{
    class XuLyKhoa
    {
        private static HttpClient hc = new HttpClient();

        public static List<Khoa> getlist()
        {
            try
            {
                string url = @"https://localhost:44357/api/Khoa";
                var kq = hc.GetAsync(url);
                kq.Wait();
                if (kq.Result.IsSuccessStatusCode == false) return null;
                var ok = kq.Result.Content.ReadAsAsync<List<Khoa>>();
                ok.Wait();
                return ok.Result.ToList();

            }
            catch (Exception)
            {
                return null;
            }
        }
        public static bool postKhoa(Khoa sv)
        {
            try
            {
                string url = @"https://localhost:44357/api/Khoa";
                var kq = hc.PostAsJsonAsync(url, sv);
                kq.Wait();
                return kq.Result.IsSuccessStatusCode;

            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool deleteKhoa(string id)
        {
            try
            {
                string url = @"https://localhost:44357/api/Khoa/" + id;
                var kq = hc.DeleteAsync(url);
                kq.Wait();
                return kq.Result.IsSuccessStatusCode;

            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool updateKhoa(Khoa sv)
        {
            try
            {
                string url = @"https://localhost:44357/api/Khoa/"+sv.MaKhoa;
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
