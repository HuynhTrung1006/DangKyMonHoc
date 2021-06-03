using API_DangKyMonHoc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Admin_DangKyMonHoc.XuLy
{
    class CXuLyLop
    {
        private static HttpClient hc = new HttpClient();
        public static List<Lop> getDSMonhoc()
        {
            try
            {
                string url = @"https://localhost:44357/api/lop";
                var kq = hc.GetAsync(url);
                kq.Wait();
                if (kq.Result.IsSuccessStatusCode == false) return null;

                var list = kq.Result.Content.ReadAsAsync<List<Lop>>();
                list.Wait();
                return list.Result.ToList();
            }
            catch (Exception)
            {
                return null;

            }

        }
        public static bool themLop(Lop l)
        {
            try
            {
                string url = @"https://localhost:44357/api/lop";
                var kq = hc.PostAsJsonAsync(url, l);
                kq.Wait();
                return kq.Result.IsSuccessStatusCode;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static bool xoaLop(string MaLop)
        {
            try
            {
                string url = @"https://localhost:44357/api/lop/" + MaLop;
                var kq = hc.DeleteAsync(url);
                kq.Wait();
                return kq.Result.IsSuccessStatusCode;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static bool suaLop(Lop l)
        {
            try
            {
                string url = @"https://localhost:44357/api/lop";
                var kq = hc.PutAsJsonAsync(url, l);
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
