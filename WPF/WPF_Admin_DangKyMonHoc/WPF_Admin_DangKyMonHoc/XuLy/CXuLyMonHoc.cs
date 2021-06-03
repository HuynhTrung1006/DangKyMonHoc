using API_DangKyMonHoc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Admin_DangKyMonHoc.XuLy
{
    class CXuLyMonHoc
    {
        private static HttpClient hc = new HttpClient();
        public static List<MonHoc> getDSMonhoc()
        {
            try
            {
                string url = @"https://localhost:44357/api/monhoc";
                var kq = hc.GetAsync(url);
                kq.Wait();
                if (kq.Result.IsSuccessStatusCode == false) return null;

                var list = kq.Result.Content.ReadAsAsync<List<MonHoc>>();
                list.Wait();
                return list.Result.ToList();
            }
            catch (Exception)
            {
                return null;

            }

        }
        public static bool themMonhoc(MonHoc mh)
        {
            try
            {
                string url = @"https://localhost:44357/api/monhoc";
                var kq = hc.PostAsJsonAsync(url, mh);
                kq.Wait();
                return kq.Result.IsSuccessStatusCode;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static bool xoaMonhoc(string Msmh)
        {
            try
            {
                string url = @"https://localhost:44357/api/monhoc/" + Msmh;
                var kq = hc.DeleteAsync(url);
                kq.Wait();
                return kq.Result.IsSuccessStatusCode;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static bool suaMonhoc(MonHoc mh)
        {
            try
            {
                string url = @"https://localhost:44357/api/monhoc";
                var kq = hc.PutAsJsonAsync(url, mh);
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
